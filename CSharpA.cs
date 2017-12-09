using System;
//using System.Collections.Generics;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CSharpA.cs
{

	class program
	{
		static void Main(string[] args)
		{
			/* DATA TYPE DESCRIPTION ... Dont neglect the neglected part... */
			/*int q;
			short w;
			long e;
			float r;
			double t;
			decimal y;
			byte u;
			bool i;
			sbyte o;
			uint p;
			char s;
			string d;
			ushort f;
			ulong g;*/

			Console.WriteLine("int = {0} to {1}",int.MaxValue,int.MinValue);
			Console.WriteLine("short = {0} to {1}",short.MaxValue,short.MinValue);
			Console.WriteLine("long = {0} to {1}",long.MaxValue,long.MinValue);
			Console.WriteLine("float = {0} to {1}",float.MaxValue,float.MinValue);
			Console.WriteLine("double = {0} to {1}",double.MaxValue,double.MinValue);
			Console.WriteLine("decimal = {0} to {1}",decimal.MaxValue,decimal.MinValue);
			Console.WriteLine("byte = {0} to {1}",byte.MaxValue,byte.MinValue);
			//Console.WriteLine("bool = {0} to {1}",bool.MaxValue,bool.MinValue);
			Console.WriteLine("sbyte = {0} to {1}",sbyte.MaxValue,sbyte.MinValue);
			Console.WriteLine("uint = {0} to {1}",uint.MaxValue,uint.MinValue);
			//Console.WriteLine("char = {0} to {1}",char.MaxValue,char.MinValue);
			//Console.WriteLine("string= {0} to {1}",string.MaxValue,string.MinValue);
			Console.WriteLine("ushort = {0} to {1}",ushort.MaxValue,ushort.MinValue);
			Console.WriteLine("ulong = {0} to {1}",ulong.MaxValue,ulong.MinValue);

			DateTime a = new DateTime(15-5-2014);
			DateTime b = a.AddDays(4);
			b = a.AddMonths(2);
			b = a.AddYears(2);

			Console.WriteLine("HelloWorld this is joy.");
			Console.WriteLine("The old year = {0}",a);
			Console.WriteLine("The new year = {1}",b);

			
		}
	}
}