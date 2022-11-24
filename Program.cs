//driver code
using System;
using System.IO;

namespace PrimeNumbers{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			//s.solve();

			// var result2 = s.getNumberOfFactors(Convert.ToInt32( args[0] ));
			// Console.WriteLine(result2 );

			// var result = s.isPrime(Convert.ToInt32( args[0] ));
			// Console.WriteLine(result );
			
			var result3 = s.GetAllPrimes(args[0]);
				Console.WriteLine("Total prime count : " + result3.Count);
			foreach (var item in result3)
			{
				Console.Write(item + " ");
			}

		}
	}
}
