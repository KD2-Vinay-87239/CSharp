using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    using System;

    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Parameterized Constructor
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // Default Constructor
        public Date() { }

        // Static method to calculate age
        public static int CalculateAge(Date birthDate)
        {
            var today = DateTime.Now;
            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }

    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        // Default Constructor
        public Person()
        {
            name = "Unknown";
            gender = true; // Default: Male
            birth = new Date(1, 1, 2000);
            address = "Not Specified";
        }

        // Parameterized Constructor
        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return Date.CalculateAge(birth); }
        }

        // Accept method to input data from console
        public void Accept()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (Male = true, Female = false): ");
            gender = bool.Parse(Console.ReadLine());

            Console.Write("Enter Birth Date (DD MM YYYY): ");
            var birthInput = Console.ReadLine().Split(' ');
            birth = new Date(int.Parse(birthInput[0]), int.Parse(birthInput[1]), int.Parse(birthInput[2]));

            Console.Write("Enter Address: ");
            address = Console.ReadLine();
        }

        // Print method to display data
        public void Print()
        {
            Console.WriteLine(ToString());
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Name: {name}\n" +
                   $"Gender: {(gender ? "Male" : "Female")}\n" +
                   $"Birth Date: {birth}\n" +
                   $"Age: {Age}\n" +
                   $"Address: {address}";
        }
    }

    public enum DepartmentType
    {
        HR,
        IT,
        Sales,
        Finance,
        Training
    }

    public class Employee : Person
    {
        private static int count = 0;
        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        // Default Constructor
        public Employee() : base()
        {
            id = ++count;
            salary = 0.0;
            designation = "Not Specified";
            dept = DepartmentType.IT;
        }

        // Parameterized Constructor
        public Employee(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept)
            : base(name, gender, birth, address)
        {
            id = ++count;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        // Properties
        public int Id
        {
            get { return id; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        // Accept method to input data from console
        public new void Accept()
        {
            base.Accept();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Designation: ");
            designation = Console.ReadLine();

            Console.WriteLine("Select Department: 0 = HR, 1 = IT, 2 = Sales, 3 = Finance");
            dept = (DepartmentType)int.Parse(Console.ReadLine());
        }

        // Print method to display data
        public new void Print()
        {
            Console.WriteLine(ToString());
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"ID: {id}\n" +
                   $"Salary: {salary:C}\n" +
                   $"Designation: {designation}\n" +
                   $"Department: {dept}";
        }
    }

    public class Manager : Employee
    {
        private double bonus;

        // Default Constructor
        public Manager() : base()
        {
            Salary = 0.0;
            bonus = 0.0;
            Designation = "Manager";
        }

        // Parameterized Constructor
        public Manager(string name, bool gender, Date birth, string address, double salary, double bonus, DepartmentType dept)
            : base(name, gender, birth, address, salary, "Manager", dept)
        {
            this.bonus = bonus;
        }

        // Property
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        // Accept method to input data from console
        public new void Accept()
        {
            base.Accept();
            Console.Write("Enter Bonus: ");
            bonus = double.Parse(Console.ReadLine());
            Designation = "Manager"; // Ensures the designation is fixed to "Manager"
        }

        // Print method to display data
        public new void Print()
        {
            Console.WriteLine(ToString());
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Bonus: {bonus:C}";
        }
    }

    public class Supervisor : Employee
    {
        private int subordinates;

        // Default Constructor
        public Supervisor() : base()
        {
            Salary = 0.0;
            subordinates = 0;
            Designation = "Supervisor";
        }

        // Parameterized Constructor
        public Supervisor(string name, bool gender, Date birth, string address, double salary, int subordinates, DepartmentType dept)
            : base(name, gender, birth, address, salary, "Supervisor", dept)
        {
            this.subordinates = subordinates;
        }

        // Property
        public int Subordinates
        {
            get { return subordinates; }
            set { subordinates = value; }
        }

        // Accept method to input data from console
        public new void Accept()
        {
            base.Accept();
            Console.Write("Enter Number of Subordinates: ");
            subordinates = int.Parse(Console.ReadLine());
            Designation = "Supervisor"; // Ensures the designation is fixed to "Supervisor"
        }

        // Print method to display data
        public new void Print()
        {
            Console.WriteLine(ToString());
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Subordinates: {subordinates}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Supervisor object
            Supervisor supervisor = new Supervisor();

            // Accept data from user
            Console.WriteLine("Enter supervisor details:");
            supervisor.Accept();

            // Print the entered data
            Console.WriteLine("\nSupervisor Details:");
            supervisor.Print();

            
        }
    }

}
