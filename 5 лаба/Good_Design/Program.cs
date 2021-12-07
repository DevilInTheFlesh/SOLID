using System;

namespace Good_Design
{
    //Разделим интерфейсы
    public interface IEmployeeAdd
    {
        bool AddDetailsEmployee();
    }

    public interface IEmployeeShow
    { 
        string ShowEmployeeDetails(int id);
    }
   
    public class Baker : IEmployeeAdd
    {
        public bool AddDetailsEmployee()
        {
            return true;
        }

    }

    public class Butcher : IEmployeeAdd, IEmployeeShow
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
            Butcher butcher = new Butcher();
            Console.WriteLine(butcher.ShowEmployeeDetails(999));
        }
    }
}
