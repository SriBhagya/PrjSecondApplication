using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
	class StringEg
	{
		static void Main()
		{
			string firstname = "Bhagya";
			Console.WriteLine("length of the string:{0}", firstname.Length);
			Console.WriteLine("converting to uppercase", firstname.ToUpper());
			Console.WriteLine("contains :{0}", firstname.Contains("bha"));
			Console.WriteLine("Index s:{0}", firstname.IndexOf("a"));
			Console.WriteLine("checks wheather" + "first character starts with:{0}", firstname.StartsWith("B"));
			Console.Read();
		}
	}
}
