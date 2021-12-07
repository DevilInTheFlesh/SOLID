using System;
using System.Collections.Generic;

class Cake
{
    public string Name { get; set; }
    public string Recipe { get; set; }
    public int Price { get; set; }

}

class Bakery
{
    List<Cake> cakes = new List<Cake>();
    public ICakeReader Reader { get; set; }
    public ICakeBinder Binder { get; set; }
    public ICakeValidator Validator { get; set; }


    public Bakery(ICakeReader reader, ICakeBinder binder, ICakeValidator validator)
    {
        this.Reader = reader;
        this.Binder = binder;
        this.Validator = validator;
    }



    public void Process()
    {
        string[] data = Reader.GetInputData();
        Cake cake = Binder.BakeCake(data);
        if (Validator.IsValid(cake))
        {
            cakes.Add(cake);
            Console.WriteLine("Торт создан");
        }
        else
        {
            Console.WriteLine("Некорректные данные");
        }
    }
}

    interface ICakeReader
    {
        string[] GetInputData();
    }
    class CakeReader : ICakeReader
    {
        public string[] GetInputData()
        {
            Console.WriteLine("Введите название торта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            string price = Console.ReadLine();
            Console.WriteLine("Введите название рецепта:");
            string recipe = Console.ReadLine();
            return new string[] { name, price, recipe };
        }
    }

    interface ICakeBinder
    {
        Cake BakeCake(string[] data);
    }

    class CakeBinder : ICakeBinder
    {
        public Cake BakeCake(string[] data)
        {
            if (data.Length >= 3)
            {
                int price = 0;
                if (Int32.TryParse(data[1], out price))
                {
                    return new Cake { Name = data[0], Price = price, Recipe = data[2] };
                }
                else
                {
                    throw new Exception("Некорректные данные для цены");
                }
            }
            else
            {
                throw new Exception("Недостаточно данных для создания торта");
            }
        }
    }

    interface ICakeValidator
    {
        bool IsValid(Cake cake);
    }

    class CakeValidator : ICakeValidator
    {
        public bool IsValid(Cake cake)
        {
            if (String.IsNullOrEmpty(cake.Name) || cake.Price <= 0)
                return false;

            return true;
        }
    }
