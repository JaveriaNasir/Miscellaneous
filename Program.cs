using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlaidInterview
{
	class Program
	{
		static void Main(string[] args)
		{
			bool finalResult = false;
			Routing routingobj = new Routing();				
			string strroutingnum = "111000025"; // valid  routing number
			//string strroutingnum = "111ABCD25";	 // Invalid routing number		
			if (!strroutingnum.All(char.IsDigit)) //checks for any non-digit value
			{
				finalResult = false;
			}
			else if (string.IsNullOrEmpty(strroutingnum)) //check for the empty values
			{
				finalResult = false;
			}
			else
			{
				int num1;
				int.TryParse(strroutingnum, out num1);
				int[] intarray = routingobj.GetIntArray(num1); //this method converts the string to an intArray
				finalResult = routingobj.routingCheck(intarray); //this method acutally check for the right routing number if Modulus == 0
			}
			Console.WriteLine("The rountingcheck returned{0} " + finalResult);
			Console.ReadLine();
		}
	}
}
