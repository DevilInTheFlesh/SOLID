using System;
using System.Collections.Generic;

namespace Bad_Design
{
    /*public interface IEmployee
    {
        bool AddDetailsEmployee();
    }

    Фирма попросила сделать так, чтообы читались данные только для мясников и мы добавим этот метод в интерфейс
    */

    public interface IEmployee
    {
        bool AddDetailsEmployee();
        string ShowEmployeeDetails(int id);
    }
    //Но теперь у нас и пекари будут показывать свои данные

    public class Baker : IEmployee
    {
        public bool AddDetailsEmployee()
        {
            return true;
        }

        public string ShowEmployeeDetails(int emplId)
        {
            return "Bakery worker";
        }
    }

    public class Butcher : IEmployee
    {
        public bool AddDetailsEmployee()
        {
            return true;
        }

        public string ShowEmployeeDetails(int emplId)
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
                Console.WriteLine(emp.ShowEmployeeDetails(999));
            }
        }
    }
}
