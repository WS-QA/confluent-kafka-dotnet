using System;
using System.Collections.Generic;
using System.Text;

namespace Confluent.Kafka.Examples.ConsumerExample
{
    /// <summary>
    /// sammple.
    /// </summary>
    public static class StringUtilsExtended
    {
        /// <summary>
        /// aaa.
        /// </summary>
        /// <param name="toPrint">bbbb.</param>
        /// <returns>dddd.</returns>
        public static string ExtendedRecurly(this string toPrint)
        {
			Console.WriteLine(toPrint);
			SomeOtherFunction();
			return "boom!";
        }
		
		public static void SomeOtherFunction()
		{
		    try
            {
				PeterO.Cbor.CBORObject.DecodeFromBytes(default);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
		}
    }
}
