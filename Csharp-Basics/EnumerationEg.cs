using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
	enum Feedback
	{
		poor=12, fair, good, excellent
	}

	class EnumerationEg
	{

		static void Main()
			
		{
			string Ename = "sai";
			//Console.WriteLine("name:{0}||Feedback:{1}",Ename,Feedback.fair);
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("name:{0}||Feedback:{1}", Ename,(int)Feedback.fair);
			//or
			//Console.WriteLine("name:{0}||Feedback:{1}", Ename, Convert.ToInt32(Feedback.fair));
			
			Console.Read();
		}


	}
}
