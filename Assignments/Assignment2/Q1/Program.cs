using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public char Div
        {
            get { return div; }
            set { div = value; }
        }

        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region Parameterized Constructor
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }
        #endregion

        #region Accept Details
        public static void AcceptDetails(out Student student)
        {
            student = new Student();
            Console.WriteLine("Enter name:");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter gender (true for male, false for female):");
            student.Gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter age:");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter std:");
            student.Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter div:");
            student.Div = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter marks:");
            student.Marks = Convert.ToDouble(Console.ReadLine());
        }
        #endregion

        #region Display Details
        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + (Gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Std: " + Std);
            Console.WriteLine("Div: " + Div);
            Console.WriteLine("Marks: " + Marks);
        }
        #endregion

        #region Create Array Method
        public static void CreateArray(out Student[] students)
        {
            Console.WriteLine("Enter the number of students:");
            int size = Convert.ToInt32(Console.ReadLine());
            students = new Student[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nEnter details for student {i + 1}:");
                Student.AcceptDetails(out students[i]);
            }
        }
        #endregion

        #region Reverse Array
        public static void ReverseArray(Student[] students, out Student[] reversedStudents)
        {
            int size = students.Length;
            reversedStudents = new Student[size];

            for (int i = 0; i < size; i++)
            {
                reversedStudents[i] = students[size - 1 - i];
            }
        }
        #endregion
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students;

            // Create and populate the array
            Student.CreateArray(out students);

            // Display details of all students
            Console.WriteLine("\nStudent Details:");
            foreach (var student in students)
            {
                student.DisplayDetails();
                Console.WriteLine();
            }

            // Reverse the array
            Student.ReverseArray(students, out Student[] reversedStudents);

            // Display details of reversed students
            Console.WriteLine("\nReversed Student Details:");
            foreach (var student in reversedStudents)
            {
                student.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
