//Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
//В классе MultiBuilding реализовать следующие элементы:

//конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//свойство get/set доступа к внутреннему полю класса;
//метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//Класс MultiBuilding сделать таким, что не может быть унаследован.


namespace HomeWork13
{
	sealed class MultiBuilding : Building
	{
		int levels;
		int Levels
		{
			get { return levels; }
			set 			
			{
				if (value >0) levels = value; 
				else levels = 0;
			}
		}

		public MultiBuilding(string address, double lenght, double width, double height, int levels)
            : base(address,lenght, width, height)
		{
			Levels = levels;
		}

		public string Print()
		{
			return base.Print() + $" {levels}";
		}
    }
}
