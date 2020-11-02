using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
	//array is a collection of homogeneous datatypes
	class ArrayEg
	{
		static void Main()
		{
			//datatype[] arrname=new datatype[size];
			//new--allocates memory
			string[] flower = new string[4]; //0,1,2,3
			flower[0] = "lily";
			flower[0] = "rose";
			flower[0] = "jasmine";
			flower[0] = "lotus";
			Console.Write(flower[0]);
			for(int i=0;i<flower.Length;i++)
			{
				Console.WriteLine("index{0}:{1}", i, flower[i]);
			}
			Console.Read();

			
		}
	}
}
