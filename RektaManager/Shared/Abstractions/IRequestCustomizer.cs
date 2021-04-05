using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public interface IRequestCustomizer
    {
        int Skip { get; set; }

        int Take { get; set; }

        string OrderBy { get; set; }

        string SearchString { get; set; }
    }
}
