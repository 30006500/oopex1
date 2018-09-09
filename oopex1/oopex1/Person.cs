using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopex1
{
     abstract class Person
    {
        string name;
        string address;
        string phone;
        string level;
         abstract public string Name { get; }
         abstract public string Address { get; }
         abstract public string Phone { get; }
         public virtual string Level { get { return level; } set { level = value; } }
        public Person(string _name, string _address, string _phone)
        {
            name = _name;
            address = _address;
            phone = _phone;
        }
    }
}
