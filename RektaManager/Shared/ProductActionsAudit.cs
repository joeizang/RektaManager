using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class ProductActionsAudit : DomainModelBase, IBaseAudit
    {
        public string Changes { get; set; }
        public ActionPerformed Actions { get; set; }
    }
}
