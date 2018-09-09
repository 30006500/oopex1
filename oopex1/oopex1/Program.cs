using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oopex1
{
    class Program
    {
       static int counter = 0;
        static string user;
        static string pass;
        static string choice;
        public static List<Managers> Manager = new List<Managers>();
        public static List<GeneralStaff> Staff = new List<GeneralStaff>();
        
       
        static void Main()
        {
            
           do
            {
            if (counter == 0)
            {
                Manager.Add(new Managers("Admin", "Admin", "1", 0, "Admin", "Admin"));
                Console.WriteLine("Restaurant Management System");
                Console.WriteLine("");
                Console.WriteLine("Welcome Admin, please change your password before you continue");
                Manager[0].Password = Console.ReadLine();
                Console.WriteLine("Password has been set to {0}", Manager[0].Password);
                Console.ReadLine();
            }

            else
            {
            Console.Clear();
                    Console.WriteLine("Restaurant Management System");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter your username or type Exit");
                    user = Console.ReadLine();
                    if (user == "exit" || user == "Exit") { Environment.Exit(0); }
                    Console.WriteLine("Please enter your password");
                    pass = Console.ReadLine();
                    foreach (Managers m in Manager)
                    {
                        if (user == m.Username && pass == m.Password) { FullMenu(); }
                        Console.WriteLine(m.Name);
                    }
                    foreach (GeneralStaff s in Staff)
                    {
                        if (user == s.Username && pass == s.Password) { PartMenu(); }
                        Console.WriteLine(s.Name);
                    }
               }
                counter++;
           } while (user != "Exit" && user != "exit");
          
        }
       static void FullMenu()
        {
            int option = 0;
            bool check = true;
            do { 
            
            Console.Clear();
            Console.WriteLine("Restaurant Management System");
            Console.WriteLine();
            Console.WriteLine("1) Create new staff member profile");
            Console.WriteLine("2) View staff member profiles");
            Console.WriteLine("3) Enter new customer profile");
            Console.WriteLine("4) Search customer records");
            Console.WriteLine("5) Log Out and Return to Login Screen");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of your choice");
            check = int.TryParse(Console.ReadLine(), out option);
            if (check == false)
            {
                Console.WriteLine("Invalid entry, please enter a number");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }

            else if (option > 5)
            {
                Console.WriteLine("Please enter a number between 1 and 5");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {

                switch (option)
                {
                    case 1:
                            StaffAdd();
                        break;
                    case 2:
                            StaffProfiles();
                            break;
                    case 3:
                            CustomerAdd();
                        break;
                    case 4:
                            CustomerSearch();
                            break;
                    case 5:
                        break;
                    default:
                        break;


                }
            }
        } while (option != 5) ;
            

        }

        static void PartMenu()
        {
           
            int option = 0;
            bool check = true;
            do
            {

                Console.Clear();
                Console.WriteLine("Restaurant Management System");
                Console.WriteLine();               
                Console.WriteLine("1) Enter new customer profile");
                Console.WriteLine("2) Search customer records");
                Console.WriteLine("3) Log Out and Return to Login Screen");
                Console.WriteLine();
                Console.WriteLine("Please enter the number of your choice");
                check = int.TryParse(Console.ReadLine(), out option);
                if (check == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (option > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {

                    switch (option)
                    {
                       
                        case 1:
                            CustomerAdd();
                            break;
                        case 2:
                            CustomerSearch();
                            break;
                        case 3:
                            break;
                        default:
                            break;


                    }
                }
            } while (option != 3);

        }
        static void StaffAdd()
        {
            int option;
            bool check;
            do {                
                Console.Clear();
                Console.WriteLine("Which type of staff memeber would you like to add?");
                Console.WriteLine("1) General Staff Member");
                Console.WriteLine("2) Manager"); 
                Console.WriteLine("3) Return To Previous Menu");
                check = int.TryParse(Console.ReadLine(), out option);
                if (check == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (option > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    if (option == 1)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Create New General Staff Record");
                            Console.WriteLine();
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Address: ");
                            string address = Console.ReadLine();
                            Console.WriteLine("Phone: ");
                            string phone = Console.ReadLine();
                            Console.WriteLine("Payrate: ");
                            int pay = int.Parse(Console.ReadLine());
                            Console.WriteLine("Username: ");
                            string user = Console.ReadLine();
                            Console.WriteLine("Password: ");
                            string pass = Console.ReadLine();
                            Staff.Add(new GeneralStaff(name, address, phone, pay, user, pass));
                            Console.WriteLine("Would you like to enter another staff record?");
                            choice = Console.ReadLine();
                        } while (choice == "y" || choice == "Y" || choice == "yes" || choice == "Yes" || choice == "YES");
                    }
                    else if (option == 2)
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Create New Manager Staff Record");
                            Console.WriteLine();
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Address: ");
                            string address = Console.ReadLine();
                            Console.WriteLine("Phone: ");
                            string phone = Console.ReadLine();
                            Console.WriteLine("Payrate: ");
                            int pay = int.Parse(Console.ReadLine());
                            Console.WriteLine("Username: ");
                            string user = Console.ReadLine();
                            Console.WriteLine("Password: ");
                            string pass = Console.ReadLine();
                            Manager.Add(new Managers(name, address, phone, pay, user, pass));
                            foreach (Managers z in Manager)
                            {
                                Console.WriteLine(z.Name);
                            }
                            Console.WriteLine("Would you like to enter another staff record?");
                            choice = Console.ReadLine();
                        } while (choice == "y" || choice == "Y" || choice == "yes" || choice == "Yes" || choice == "YES");
                    }
                    else
                    {
                    }

                }
            } while (option != 3); 
        }
    
        static void StaffProfiles()
        {

        }

        static void CustomerAdd()
        {
        
        }

        static void CustomerSearch()
        {

        }

        static void AddManager(string _name, string _address, string _phone, int _pay, string _user, string _pass)
        {
            Manager.Add(new Managers(_name, _address, _phone, _pay, _user, _pass));
        }

    }

}
