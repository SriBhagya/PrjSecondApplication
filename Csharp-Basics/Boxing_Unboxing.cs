using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
	class Boxing_Unboxing
	{
		static void Main()
		{
			//value type
			int petrol = 100;
			int deisel=85; //added new int value
			//reference type
			//boxing converting value type to reference type
			object o = petrol;
			Console.WriteLine("value type to reference type:{0}", o);

			//refernce value to value type
			string oilprice = "10.00";
			//int o = Convert.ToInt32(Console.Read());
			Console.WriteLine("Reference value convertedto value type:{0}", oilprice);
			Console.ReadLine();


		}
	}
}
