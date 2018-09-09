using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopex1
{
    class VipCustomer : Customer
    {
        public override string Name { get; }
        public override string Address { get; }

        public override string Phone { get; }

        public override string Level { get; set; }


        public VipCustomer(string _name, string _address, string _phone) : base(_name, _address, _phone)
        {
            Name = _name;
            Address = _address;
            Phone = _phone;
            Level = "VIP";
        }
    }

}
