using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RektaManagerApp.Shared.Abstractions
{
    public class BaseActionsAudit : DomainModelBase, IBaseAudit
    {
        public string Changes { get; set; }
        public ActionPerformed Actions { get; set; }
    }
}
