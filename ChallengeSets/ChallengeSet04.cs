using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            var sum = 0;
            foreach (var num in numbers)
            {
                //add even numbers
                if (num % 2 == 0)
                {
                    sum += num;

                }
                //subtract odd numbers
                else
                {
                    sum -= num;

                }

            }

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            //string[] totalStrings = { str1, str2, str3, str4 };
            //List<int> len = new List<int>();
            //var lowest = 0;
            // foreach ( var str in totalStrings)
            // {
            //create a new num array from the totalStrings array
            //     len.Add(str.Length);

            //  }
            //  lowest = len.Min();
            //  return lowest;

            // int[] totalStrings = { str1.Length, str2.Length, str3.Length, str4.Length };

            // var lowest = 0;
            // foreach(var str in totalStrings)
            // {

            // }

            int shortestLength = 100000;
            if (str1.Length < shortestLength)
            {
                shortestLength = str1.Length;
            }
            if (str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }
            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }
            if (str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int lowestValue = 100000;
            if (number1 < lowestValue)
            {
                lowestValue = number1;
            }
            if (number2 < lowestValue)
            {
                lowestValue = number2;
            }
            if (number3 < lowestValue)
            {
                lowestValue = number3;
            }
            if (number4 < lowestValue)
            {
                lowestValue = number4;
            }
            return lowestValue;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
               && sideLength1 + sideLength3 > sideLength2
               && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int items = objs.Length;
            int nulls = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nulls++;
            }
            if (nulls > items / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0) return 1;
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return number;
            }
        }
    }
}
    }
}
