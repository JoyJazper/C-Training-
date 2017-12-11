using System;

namespace StaticKeyW
{
	class Student
	{
		public string stdName;
		public int roll;

		public Student( string stdName , int roll )
		{
			this.stdName = stdName;
			this.roll = roll;
		}

		public void Display()
		{
			Console.WriteLine("The name of the student no {1} is: {0}",stdName,roll);
		}

		//Static Sectiom

		public static int c = 0;

		public static int AddStudent()
		{
			c++;
			return (c);
		}
		//end section
	}

	class Registrar
	{
		public static void Main()
		{
			Student x = new Student("Rahul", 25);
			x.Display();
			int a = Student.AddStudent();
			Console.WriteLine("Total Number of Students : {0} ", Student.c);
		}
	}
}