using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.Abstractions
{
    public class BaseUpsertComponentModel
    {
        public DateTime Timestamp { get; set; }

        public int Id { get; set; }

    }
}
