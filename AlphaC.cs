using System;

namespace AlphaC.CS
{
	class Animal3
	{
		private String name;
		private int weight;

		public Animal3()
		{ }

		public String Name
		{
			get{return name;}
			set{name = value;}
		}

		public int Weight
		{
			get{return weight;}
			set{weight = value;}
		}

        public void MakeSound3()
        {
        	Console.WriteLine("{0} makes sound!!",name);
        }

		public void Walk3()
		{
			Console.WriteLine("{0} Walks slowly.",name);
		}

		public void Run3()
		{
			Console.WriteLine("{0} runs swiftly.",name);
			Console.WriteLine("{1} weighs {0} kgs.",weight,name);
		}
	}


	class AlphaC
	{
		static void Main(String[] args)
		{
			Animal3 x = new Animal3();
			x.Name = "Neko";
			x.Weight = 15;
			x.MakeSound3();
			x.Walk3();
			x.Run3();
			Console.WriteLine("I Am accesing it using get name and the name of the animal is {0} which weighs {1} kgs ",x.Name,x.Weight);
		}
	}
}