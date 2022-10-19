//driver code
using System;
using System.IO;

namespace PrimeNumbers{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			//s.solve();

			var result2 = s.getNumberOfFactors(Convert.ToInt32( args[0] ));
			Console.WriteLine(result2 );

			var result = s.isPrime(Convert.ToInt32( args[0] ));
			Console.WriteLine(result );
			
			

		}
	}
}
