using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle t = new Tabletop (4.5, 7.5);
    //        t.Display();
    //        Console.ReadLine();
    //    }
    //}
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }

        public virtual void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w)
        {

        }
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
        
    }

    public class Employee4
    {
        public string id;
        public string name;
        public Employee4()
        {

        }
        public Employee4(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public static int employeeCounter;
        public static int AddEmployee()
        {
            return ++employeeCounter;
        }

    }
    class MainClass : Employee4
    {
        static void Main()
        {
            Console.WriteLine("Enter the employee's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the employee's ID: ");
            string id = Console.ReadLine();

            Employee4 e = new Employee4(name, id);
            Console.WriteLine("Enter the current number of employees: ");
            string n = Console.ReadLine();
            Employee4.employeeCounter = Int32.Parse(n);
            Employee4.AddEmployee();

            Console.WriteLine("Name: {0}", e.name);
            Console.WriteLine("ID:  {0}", e.id);
            Console.WriteLine("New Number of Employees: {0}", Employee4.employeeCounter);

        }
    }

}
