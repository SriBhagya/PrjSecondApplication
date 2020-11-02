using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
	//method with parameters
	class Eg2
	{

		
		void DisplayUserDeatils(string cn,string ci,string g,string mail)
		{
			Console.WriteLine("name:{0}||city:{1}||gender:{2}||email:{4}",cn,ci,g,mail);
		}
		int Total(int[] marray)
		{
			//local to this method
			int sum = 0;
			for(int i=0;i<marray.Length;i++)
			{
				sum = sum + marray[i]; //i=0:0+89=89 //i=1:89+90=179 //i=2:179+67=246
			}
			return sum;

		}
		static void Main()
		{
			string CName, City, gender, email;
			int[] mark = new int[3] { 89, 90, 67 };
			Console.WriteLine("Enter CName");
			CName = Console.ReadLine();
			Console.WriteLine("Enter City");
			City = Console.ReadLine();
			Console.WriteLine("Enter gender");
			gender = Console.ReadLine();
			Console.WriteLine("Enter email");
			email = Console.ReadLine();
			Eg2 eg2 = new Eg2();
			eg2.DisplayUserDeatils(CName,City,gender,email);
			Console.WriteLine("sum of marks is:{0}", eg2.Total(mark));
			Console.ReadLine();


		}
	}
}
