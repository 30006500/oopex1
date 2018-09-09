using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopex1
{
   
    class Employee : Person
        
    {
        double hourlyrate;
        string username;
        string password;

        public override string Name { get; }
        public override string Address { get; }

        public override string Phone { get; }

        public override string Level { get; set; }
        
        public virtual double HourlyRate { get { return hourlyrate; } }

        public virtual string Username { get { return username; } }

        public virtual string Password { get { return password; } set { password = value; } }


        public Employee(string _name, string _address, string _phone, double _hourlyrate, string _username, string _password) : base(_name, _address, _phone)
        {
            hourlyrate = _hourlyrate;
            username = _username;
            password = _password;
            Name = _name;
            Address = _address;
            Phone = _phone;
        }
    }
}
