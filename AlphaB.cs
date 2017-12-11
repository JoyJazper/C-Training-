using System;

namespace AlphaB.cs
{
	class Animal2
	{
		private String name;
		private int weight;

		public Animal2()
		{ }



		public void SetName(string Name)
		{
			name = Name;
		}

		public string GetName()
		{
			return name;
		}



		public void SetWeight(int Weight)
		{
			weight = Weight;
		}

		public int GetWeight()
		{
			return weight;
		} 



        public void makeSound2()
        {
        	Console.WriteLine("{0} makes sound!!",name);
        }

		public void walk2()
		{
			Console.WriteLine("{0} Walks slowly.",name);
		}

		public void run2()
		{
			Console.WriteLine("{0} runs swiftly.",name);
			Console.WriteLine("{1} weighs {0} kgs.",weight,name);
		}
	}


	class AlphaB
	{
		static void Main(String[] args)
		{
			Animal2 x = new Animal3();
			x.SetName("Neko");
			x.SetWeight(15);
			x.makeSound2();
			x.walk2();
			x.run2();
			Console.WriteLine("I Am accesing it using get name and the name of the animal is {0} which weighs {1} kgs ",x.GetName(),x.GetWeight());

		}
	}
}