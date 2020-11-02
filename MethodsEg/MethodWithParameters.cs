using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
	class MethodWithParameters
	{
		void Byvalue(string ph)
		{
			ph = "0000000000";
			Console.WriteLine("value changed inside method :ph:{0}", ph);

		}
		static void Main()
		{
			string phno = "9912299526";
			MethodWithParameters mobj = new MethodWithParameters();
			Console.WriteLine("before calling.byvalue method:phno:{0}:", phno);
			mobj.Byvalue(phno);
			Console.Read();
		}
			
	}
}
