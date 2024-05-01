using Structure.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.EmployeeAggregate.Lookup
{
    public class Countries : LookpBase
    {
        public string Name { get; protected set; }
        public string Nationality { get; protected set; }

        public string PhoneCodeNumber { get; protected set; }
        public string PhoneNumberLength { get; protected set; }

    }
}
