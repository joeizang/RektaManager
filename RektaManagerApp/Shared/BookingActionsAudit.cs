using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManagerApp.Shared.Abstractions;

namespace RektaManagerApp.Shared
{
    public class BookingActionsAudit : DomainModelBase, IBaseAudit
    {
        public string Changes { get; set; }
        public ActionPerformed Actions { get; set; }
    }
}
