using System;

namespace AlphaA.cs
{
	class Animal1
	{
		public String name1;
		public int weight1;

		public Animal1()
		{}

        public void makeSound1()
        {
        	Console.WriteLine("{0} makes sound!!",name1);
        }

		public void walk1()
		{
			Console.WriteLine("{0} Walks slowly.",name1);
		}

		public void run1()
		{
			Console.WriteLine("{0} runs swiftly.",name1);
			Console.WriteLine("{1} weighs {0} kgs.",weight1,name1);
		}
	}


	class AlphaA
	{
		static void Main(String[] args)
		{
			Animal x = new Animal();
			x.name1 = "Neko";
			x.weight1 = 15;
			x.makeSound1();
			x.walk1();
			x.run1();
		}
	}
}