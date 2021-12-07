using System;
using System.Collections.Generic;

namespace Good_Design
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int emplId);
    }

    public interface IWork
    {
        string GetWorkDetails(int emplId);
    }

    public class Baker : IWork, IEmployee
    {
        public string GetWorkDetails(int emplId)
        {
            return "Bake cakes";
        }

        public string GetEmployeeDetails(int emplId)
        {
            return "Bakery worker";
        }
    }

    public class Butcher : IEmployee
    {
        public string GetEmployeeDetails(int emplId)
        {
            return "Butchery shop worker";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> list = new List<IEmployee>();
            list.Add(new Baker());
            list.Add(new Butcher());

            foreach (IEmployee emp in list)
            {
                Console.WriteLine(emp.GetEmployeeDetails(999));
            }
        }
    }
}
