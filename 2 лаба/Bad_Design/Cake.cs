using System;

class Cake
{
    string name;
    string recipe;
    int price;

    public Cake(string _name, string _recipe, int _price)
    {
        name = _name;
        recipe = _recipe;
        price = _price;
    }

    //В соответствии с принципом единственной ответственности класс должен решать лишь какую-то одну задачу. Он же решает аж три( получает данные, проводит их валидацию и создает новый объект этого класса)
    //Это "божественный класс", поэтому нам нужно разнести однотипные методы по разным классам.
    public void Process()
    {
        Console.WriteLine("Введите название торта:");
        string name_tmp = Console.ReadLine();
        Console.WriteLine("Введите название рецепта для этого торта:");
        string recipe_tmp = Console.ReadLine();
        Console.WriteLine("Введите цену:");
        int price_tmp = 0;
        bool result = Int32.TryParse(Console.ReadLine(), out price_tmp);

        if (result == false || price_tmp <= 0 || String.IsNullOrEmpty(name_tmp) || String.IsNullOrEmpty(recipe_tmp))
        {
            throw new Exception("Некорректно введены данные");
        }
        else
        {
            Cake NewCake = new Cake(name_tmp, recipe_tmp, price_tmp);
            Console.WriteLine("Данные о торте созданы");
        }
    }
)
