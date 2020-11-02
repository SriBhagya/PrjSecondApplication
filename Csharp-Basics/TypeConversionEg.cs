using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
	class TypeConversionEg
	{
		static void Main()
		{
			//implicit conversion
			//value type
			int salary = 20000;
		float f = salary;
		double d = f;
			Console.WriteLine("Implicit conversion");
		Console.WriteLine("Int :{0} || float:{1}||double:{2}",salary,f,d);
			//explicit value higher to lower
			float sal = 30000.78f;
			int i = Convert.ToInt32(sal);
			Console.WriteLine("Implicit conversion");
			Console.WriteLine("float to int :{0}", i);


			Console.ReadLine();
		}
	}
}
