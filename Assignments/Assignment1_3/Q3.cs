using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            string value;
            Console.WriteLine("Menu Driven Calculator ");
            Console.Write("Enter a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b :");
            int b = Convert.ToInt32(Console.ReadLine());


            do
            {
                Console.WriteLine("Select any operation to be performed -->");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Division");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your result is " + Add(a, b));
                        break;

                    case 2:
                        Console.WriteLine("Your result is " + Sub(a, b));
                        break;

                    case 3:
                        Console.WriteLine("Your result is " + Mult(a, b));
                        break;

                    case 4:
                        Console.WriteLine("Your result is " + Div(a, b));
                        break;
                }

                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            } while (value=="y" || value=="Y");



        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

       public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static float Div(int a, int b)
        {
            return a / b;
        }
    }
}

