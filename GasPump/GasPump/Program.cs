using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

		static void Main(string[] args)
		{
            // your implementation here suhas

            Console.Write("Please enter purchased gas type, Q/q to quit :");
            Console.ReadLine();

            Console.WriteLine("Please enter purchased gas Amount, Q/q to quit :");
            Console.Read();
        }

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

            // your implementation here

            if (userInput.Equals ('Q') )
                result = true;
           else if (  userInput.Equals ( 'q'))
                result = true;

            return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;

			// your implementation here
			
			return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;

			// your implementation here

			return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;

			// your implementation here

			return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;

            // your implementation here

            if (gasType.Equals(GasType.RegularGas))
                result = 1.94;
            else if (gasType.Equals(GasType.MidgradeGas))
                result = 2;

           else  if (gasType.Equals(GasType.PremiumGas))
                result = 2.24;

            else  if (gasType.Equals(GasType.DieselFuel))
                result = 2.17;


            return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
			// your implementation here
		}
	}
}
