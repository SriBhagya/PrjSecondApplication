using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
	class TwoDimensionalArray
	{
		static void Main()
		{
			int[,] matrix = new int[2, 2] { { 10, 20 }, { 30, 40 } };
			for(int i=0;i<2;i++) //row
			{
				for(int j=0;j<2;j++)
				{
					Console.WriteLine(matrix[i, j]);

				}
			}
			Console.Read();
		}
	}
}
