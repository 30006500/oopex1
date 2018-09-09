using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopex1
{
    class Managers : Employee
    {
        public override string Name { get; }
        public override string Address { get; }

        public override string Phone { get; }

        public override string Level { get; set; }

        public override double HourlyRate { get; }

        public override string Username { get; }

        public override string Password { get; set; }


        public Managers(string _name, string _address, string _phone, double _hourlyrate, string _username, string _password) : base(_name, _address, _phone, _hourlyrate, _username, _password)
        {
            HourlyRate = _hourlyrate;
            Username = _username;
            Password = _password;
            Name = _name;
            Address = _address;
            Phone = _phone;
            Level = "Elevated";
        }
    }

}
