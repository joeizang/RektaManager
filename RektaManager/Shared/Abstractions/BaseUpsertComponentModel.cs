using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public class BaseUpsertComponentModel
    {
        public byte[] Timestamp { get; set; }

        public int Id { get; set; }

    }
}
