﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RektaManagerApp.Server.Data;
using RektaManagerApp.Shared;
using RektaManagerApp.Shared.ComponentModels.Services;

namespace RektaManagerApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly RektaManagerAppContext _context;

        public ServicesController(RektaManagerAppContext context)
        {
            _context = context;
        }

        // GET: api/Services
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceComponentModel>>> GetServices()
        {
            return await _context.Services.AsNoTracking().Select(s => new ServiceComponentModel
            {
                Name = s.Name,
                Price = s.Price,
                ServiceId = s.Id
            }).ToListAsync().ConfigureAwait(false);
        }

        [HttpGet("servicesDropDown", Name = "GetServicesDropDown")]
        public async Task<ActionResult<IEnumerable<ServiceDropdownModel>>> GetDropDown()
        {
            var result = await _context.Services.AsNoTracking()
                .Select(s => new ServiceDropdownModel
                {
                    ServiceId = s.Id,
                    ServiceName = s.Name
                }).ToListAsync().ConfigureAwait(false);
            return result;
        }

        //[HttpGet("serviceSummary", Name ="GetServiceSummaryList")]
        //public async Task<ActionResult<IEnumerable<ServiceSummaryListModel>>> GetSelectedServiceSummary(string )
        //{

        //}

        // GET: api/Services/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetService(int id)
        {
            var service = await _context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return service;
        }

        // PUT: api/Services/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutService(int id, Service service)
        {
            if (id != service.Id)
            {
                return BadRequest();
            }

            _context.Entry(service).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Services
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Service>> PostService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetService", new { id = service.Id }, service);
        }

        // DELETE: api/Services/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServiceExists(int id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
