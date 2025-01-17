using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6b
{
    // HRMS Application using EmployeeLib as a private assembly

    // Include necessary namespaces
    
    using EmployeeLib;

    class HRMS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HRMS Application\n");

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Manager");
                Console.WriteLine("2. Add Supervisor");
                Console.WriteLine("3. Add Wage Employee");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddManager();
                        break;
                    case 2:
                        AddSupervisor();
                        break;
                    case 3:
                        AddWageEmployee();
                        break;
                    case 4:
                        Console.WriteLine("Exiting HRMS Application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddManager()
        {
            Console.WriteLine("Enter Manager Details:");

            Manager manager = new Manager();
            manager.Accept();

            Console.WriteLine("\nManager Details:");
            manager.Print();
        }

        static void AddSupervisor()
        {
            Console.WriteLine("Enter Supervisor Details:");

            Supervisor supervisor = new Supervisor();
            supervisor.Accept();

            Console.WriteLine("\nSupervisor Details:");
            supervisor.Print();
        }

        static void AddWageEmployee()
        {
            Console.WriteLine("Enter Wage Employee Details:");

            WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();

            Console.WriteLine("\nWage Employee Details:");
            wageEmp.Print();
        }
    }

}
