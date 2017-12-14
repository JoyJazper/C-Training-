using System;
using System.Collections;
using System.Collections.Generic;
// This is to Show the power of array List
namespace Tester {
	class MainClass {
		public static void Main (string[] args) {
			Test M = new Test ();
			Console.WriteLine ("This is a demonstration of Collecion/ArrayList!");
			var aa = Console.ReadLine ();
			M.AddData (aa);
			M.AddData (25);
			M.AddData ("Joy");
			M.AddData (32);
			M.AddData ("Rahul");
			M.AddData ("Ajay");
			M.ShowData ();
			Console.ReadLine ();
		}
	}

	class Test {
		ArrayList B = new ArrayList ();

		public void AddData (object T) {
			B.Add (T);
		}

		/*public void AddData(string Y)
		{
			B.Add (Y);
		}*/

		public void ShowData () {
			foreach (var x in B) {
				Console.WriteLine ($"The data is :{x}");
			}
		}
	}
}