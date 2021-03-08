using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RektaManager.Server.Commands.Inventories;
using RektaManager.Shared;

namespace RektaManager.Server.AutoMapperProfiles
{
    public class InventoryProfile : Profile
    {
        public InventoryProfile()
        {
            CreateMap<PutInventoryCommand, Inventory>();
        }
    }
}
