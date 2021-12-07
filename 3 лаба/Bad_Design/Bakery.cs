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

	public void BakeCake()
    {
		Console.WriteLine("Начинаем выпечку торта");
		Console.WriteLine("Готовим муку");
		Console.WriteLine("Вливаем молоко, месим тесто");
		Console.WriteLine("Кладем в печь и дожидаемся выпечки");
	}

	//В кондитерской готовятся на только торты. И в этом случае мы подходим к необходимости изменения функционала класса, а именно метода BakeCake. 
	//Но в соответствии с рассматриваемым нами принципом классы должны быть открыты для расширения, но закрыты для изменения.

}
