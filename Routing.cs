using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidInterview
{
	class Routing
	{
		public bool routingCheck(int[] intarray)
		{			
			bool result = false;			
			if (intarray.Length < 9)
			{
				result = false;
			}
			int mod = 3 * (intarray[0] + intarray[3] + intarray[6]) + 7 * (intarray[1] + intarray[4] + intarray[7]) + (intarray[2] + intarray[5] + intarray[8]);
			if (mod % 10 == 0)
			{
				result = true;
			}			
			return result;
		}

		public int[] GetIntArray(int num)
		{
			List<int> listOfInts = new List<int>();
			while (num > 0)
			{
				listOfInts.Add(num % 10);
				num = num / 10;
			}
			listOfInts.Reverse();
			return listOfInts.ToArray();
		}
	}
}
