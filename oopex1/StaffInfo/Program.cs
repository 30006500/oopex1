using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StaffInfo
{
    public class Program
    {
        static void Main()
        {
        }

        public static void StaffAdd()
        {
            Console.WriteLine("Add New Staff Memeber");
            Console.WriteLine("");
            Console.WriteLine("Please add staff member name");
            string name = Console.ReadLine();
            Console.WriteLine("Please add staff member address");
            string address = Console.ReadLine();
            Console.WriteLine("Please add staff member phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Please add staff member hourly payrate");
            int pay = int.Parse(Console.ReadLine());
            Console.WriteLine("Please add staff member username");
            string username = Console.ReadLine();
            Console.WriteLine("Please add staff member password");
            string password = Console.ReadLine();
            

        }
        

        public static void StaffProfiles()
        {
            Console.WriteLine("Staff Profiles");
            Console.ReadLine();
        }
    }
}
