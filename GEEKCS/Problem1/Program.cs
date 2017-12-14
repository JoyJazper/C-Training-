using System;
using System.Collections;
using System.Collections.Generic;
/* Problem 1 :
			Input : str1 = geekforgeeks, str2 = geeks
			Output : Yes
			Here, string2 can be formed from string1.
			http://www.geeksforgeeks.org/check-whether-second-string-can-formed-first-string-using-count-array/

		I am also gonna include everything about string.	
*/
namespace Problem1 {

	//This is solution for problem statement 1
	class MainClass {
		public static void Main (string[] args) {

			String str1 = "geeksforgeeks";
			string str2 = "geeks";
			bool a = str1.Contains (str2);
			Console.WriteLine ($"the a = {str1}  and b = {str2}");
			Console.WriteLine ($"Does string 1 contains string 2 ?  {a}");
			Console.ReadKey ();

			StringInfo A = new StringInfo ();
			A.Alpha ();

		}
	}

	// This is everything about String
	class StringInfo {

		public void Alpha () {
			// ---------- STRINGS ----------
			// Strings store a series of characters
			string randString = "This is a string";

			// Get number of characters in string
			Console.WriteLine ("String Length : {0}", randString.Length);

			// Check if string contains other string
			Console.WriteLine ("String Contains is : {0}",
				randString.Contains ("is"));

			// Index of string match
			Console.WriteLine ("Index of is : {0}",
				randString.IndexOf ("is"));

			// Remove number of characters starting at an index
			Console.WriteLine ("Remove string : {0}",
				randString.Remove (10, 6));

			// Add a string starting at an index
			Console.WriteLine ("Insert String : {0}",
				randString.Insert (10, "short "));

			// Replace a string with another
			Console.WriteLine ("Replace String : {0}",
				randString.Replace ("string", "sentence"));

			// Compare strings and ignore case
			// < 0 : str1 preceeds str2
			// = : Zero
			// > 0 : str2 preceeds str1
			Console.WriteLine ("Compare A to B : {0}",
				String.Compare ("A", "B", StringComparison.OrdinalIgnoreCase));

			// Check if strings are equal
			Console.WriteLine ("A = a : {0}",
				String.Equals ("A", "a", StringComparison.OrdinalIgnoreCase));

			// Add padding left
			Console.WriteLine ("Pad Left : {0}",
				randString.PadLeft (20, '.'));

			// Add padding right
			Console.WriteLine ("Pad Right : {0} Stuff",
				randString.PadRight (20, '.'));

			// Trim whitespace
			Console.WriteLine ("Trim : {0}",
				randString.Trim ());

			// Make uppercase
			Console.WriteLine ("Uppercase : {0}",
				randString.ToUpper ());

			// Make lowercase
			Console.WriteLine ("Lowercase : {0}",
				randString.ToLower ());

			// Use Format to create strings
			string newString = String.Format ("{0} saw a {1} {2} in the {3}",
				"Paul", "rabbit", "eating", "field");

			// You can add newlines with \n and join strings with +
			Console.Write (newString + "\n");

			// Other escape characters
			// \' \" \\ \t \a

			// Verbatim strings ignore escape characters
			Console.Write (@"Exactly What I Typed");

			// Excepts input up until a newline, but it is here to 
			// keep the console open after output
			// Read() excepts a single character
			Console.ReadLine ();
		}
	}
}