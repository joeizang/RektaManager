using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public abstract class RequestCustomizer : IRequestCustomizer
    {
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 10;
        public string OrderBy { get; set; } = string.Empty;
        public string SearchString { get; set; } = string.Empty;
    }
}
