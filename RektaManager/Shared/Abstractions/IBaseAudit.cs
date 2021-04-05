using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManager.Shared.Abstractions
{
    public interface IBaseAudit
    {
        public string Changes { get; set; }

        public ActionPerformed Actions { get; set; }
    }
}
