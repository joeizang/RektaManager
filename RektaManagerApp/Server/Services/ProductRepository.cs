﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Abstractions;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.Abstractions;
using RektaManagerApp.Shared.ComponentModels.Products;

namespace RektaManagerApp.Server.Services
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        private readonly RektaManagerAppContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public ProductRepository(RektaManagerAppContext context, IHttpContextAccessor htttpContext) : base(context, htttpContext)
        {
            _context = context;
            _httpContext = htttpContext;
        }


        public async Task Update(ProductUpsertComponentModel entity)
        {
            try
            {
                var target = await _context.Products.FindAsync(entity.Id);

                if (Convert.ToBase64String(entity.Timestamp) == Convert.ToBase64String(target.Timestamp))
                {
                    target.Id = entity.Id;
                    target.CostPrice = entity.CostPrice;
                    target.QuantityBought = entity.QuantityBought;
                    target.Name = entity.Name;
                    target.Timestamp = entity.Timestamp;
                    target.ProductInventory = new Inventory { Id = entity.ProductInventoryId };
                    target.ProductUniqueIdentifier = entity.ProductUniqueIdentifier;
                    target.UnitMeasure = entity.UnitMeasure;
                    target.ProductInventoryId = entity.ProductInventoryId;
                    target.Description = entity.Description;
                    _context.Entry(target).State = EntityState.Modified;
                }
                else
                {
                    entity.Timestamp = target.Timestamp; //once serious concurrency is attained, update this strategy
                    target.Id = entity.Id;
                    target.CostPrice = entity.CostPrice;
                    target.QuantityBought = entity.QuantityBought;
                    target.Name = entity.Name;
                    target.ProductInventory = new Inventory { Id = entity.ProductInventoryId };
                    target.ProductUniqueIdentifier = entity.ProductUniqueIdentifier;
                    target.UnitMeasure = entity.UnitMeasure;
                    target.ProductInventoryId = entity.ProductInventoryId;
                    target.Description = entity.Description;
                    _context.Products.Update(target);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Product> GetProductBy(string searchTerm)
        {
            var result = await _context.Products.AsNoTracking()
                .Include(p => p.ProductInventory)
                .Where(p => p.Name.Equals(searchTerm.ToUpper()) ||
                            p.ProductUniqueIdentifier.Equals(searchTerm) ||
                            p.Description.Contains(searchTerm.ToUpper()) ||
                            p.ProductInventory.Name.Equals(searchTerm) ||
                            p.CostPrice.Equals(decimal.Parse(searchTerm)) ||
                            p.QuantityBought.Equals(double.Parse(searchTerm)))
                .SingleOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<ProductComponentModel>> Get(RequestCustomizer query = null)
        {
            if (query is null)
            {
                return await _context.Products.AsNoTracking()
                    .Include(p => p.ProductInventory)
                    .Select(p => new ProductComponentModel()
                    {
                        CostPrice = p.CostPrice,
                        TotalCostPrice = (decimal)p.QuantityBought * p.CostPrice,
                        Description = p.Description,
                        InventoryName = p.ProductInventory.Name,
                        Name = p.Name,
                        ProductUniqueIdentifier = p.ProductUniqueIdentifier,
                        ProductId = p.Id,
                        QuantityBought = p.QuantityBought,
                        UnitMeasure = p.UnitMeasure
                    })
                    .Skip(0)
                    .Take(10)
                    .OrderBy(p => p.Name)
                    .ToListAsync();
            }

            var deferred = _context.Products.AsNoTracking()
                .Include(p => p.ProductInventory).AsQueryable();

            if (!string.IsNullOrEmpty(query.OrderBy))
                deferred = deferred.OrderBy(query.OrderBy);
            if (!string.IsNullOrEmpty(query.SearchString))
            {
                deferred = deferred.Where(p =>
                    p.Name.Equals(query.SearchString) ||
                    p.ProductUniqueIdentifier.Equals(query.SearchString) ||
                    p.Description.Contains(query.SearchString) ||
                    p.ProductInventory.Name.Equals(query.SearchString) ||
                    p.CostPrice.Equals(decimal.Parse(query.SearchString)) ||
                    p.QuantityBought.Equals(double.Parse(query.SearchString)));
            }
            var result = await deferred.Select(p => new ProductComponentModel()
            {
                CostPrice = p.CostPrice,
                //TotalCostPrice = (decimal)p.QuantityBought * p.CostPrice,
                Description = p.Description,
                InventoryName = p.ProductInventory.Name,
                Name = p.Name,
                ProductUniqueIdentifier = p.ProductUniqueIdentifier,
                ProductId = p.Id,
                QuantityBought = p.QuantityBought,
                UnitMeasure = p.UnitMeasure
            })
                .Skip(query.Skip)
                .Take(query.Take)
                .OrderBy(p => p.Name)
                .ToListAsync();

            result.ForEach(product =>
            {
                product.TotalCostPrice = product.CostPrice * (decimal)product.QuantityBought;
            });
            return result;

        }
    }
}