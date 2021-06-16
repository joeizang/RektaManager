using RektaManagerApp.Shared.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.ComponentModels.Bookings
{
    public class BookedItemUpsertComponentModel : BaseUpsertComponentModel
    {
        public decimal Price { get; set; }

        public string Name { get; set; }

    }
}
