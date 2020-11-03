using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
	class Eg1
	{
			//Method with void return type
			void Welcome()
			{
				Console.WriteLine("WELCOME ALL");
				//return 0;
			}
			//Method with string return type
			string GetName()
			{
				return "sri";
			}
			//Method with int return type
			int GetAge()
			{
				return 22;
			}
			char GetInitial()
		    {
			return 'K';
		    }
		static void Main()
		{
			Eg1 eg1 = new Eg1();
			Console.WriteLine("Name:{0}", eg1.GetName());
			Console.WriteLine("Age:{0}", eg1.GetAge());
			Console.WriteLine("Initail:{0}", eg1.GetInitial());
			Console.WriteLine("Age method Updated");
			//eg1.Welcome;
			Console.Read();
		}
				
	
	}
}
