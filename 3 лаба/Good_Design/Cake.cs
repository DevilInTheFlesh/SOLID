using System;


class Cake
{
	public string Name { get; set; }
	public int Size { get; set; }

	public Cake(string name, int size)
	{
		this.Name = name;
		this.Size = size;
	}

	public void BakePastry(IBakery bakery)
    {
		bakery.Bake();
    }
}
interface IBakery
{
	void Bake();
}


class Pie: IBakery
{
	public void Bake()
	{
		Console.WriteLine("Начинаем выпечку пирога");
		Console.WriteLine("Готовим муку, вливаем молоко, месим тесто");
		Console.WriteLine("Добавляем ягод");
		Console.WriteLine("Кладем в печь и дожидаемся выпечки");
	}
}

class Tart : IBakery
{
	public void Bake()
	{
		Console.WriteLine("Начинаем выпечку тарта");
		Console.WriteLine("Готовим муку, сливки и сахарную пудру, все перемешиваем");
		Console.WriteLine("Чистим яблоки и укладываем их");
		Console.WriteLine("Кладем в печь и дожидаемся выпечки");
	}
}