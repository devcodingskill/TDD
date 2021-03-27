using System;
using System.Collections.Generic;

namespace TDDTest
{
    internal class StringCalculator
    {
        public static int Add(string input)
        {
            if(input == null)
            return 0;
            List<int> nagetiveNumber = new List<int>();
            if (input.Contains(","))
            {
                int result = 0;
                var t = input.Split(',');
                foreach (var tt in t)
                {
                    var temp =Int32.TryParse(tt, out Int32 a) ? a : 0;
                    if (temp < 0)
                        nagetiveNumber.Add(temp);
                    else
                        result += temp;
                }
                if (nagetiveNumber.Count > 0)
                {
                    var exceptionMessage = $"Negative numbers not allowed: {nagetiveNumber}.";
                    throw new ArgumentException(exceptionMessage);
                }
                else
                    return result;
            }
            return Int32.TryParse(input, out Int32 j) ? j : 0;
            
        }
    }
}