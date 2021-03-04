using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RektaManager.Shared.Abstractions;

namespace RektaManager.Shared
{
    public class StaffShift : DomainModelBase
    {
        public ApplicationUser Staff { get; set; }

        public string StaffId { get; set; }

        public DateTimeOffset ShiftStartsAt { get; set; }

        public DateTimeOffset ShiftEndsAt { get; set; }


        //There are quite a number of business rules that you must encapsulate with regards to 
        //orgranizing shifts for workers in Rekta. Find those out and work them into the 
        //solution.
    }
}
