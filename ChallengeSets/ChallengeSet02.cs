using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Schema;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
           // throw new NotImplementedException();
           
            return  Char.IsLetter(c);
            
           
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            // see the count of elements
            int count = 0;
           for (int i = 0; i < vals.Length; i++)
            {
                count++;
            }
            var newCount = count;

            if (count %2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

           

        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            //easy working with 
            if (number % 2 == 0){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            //find min
            // loop through a  collection 
            //var min =  numbers.Min();
           

            //find max
           // var max = numbers.Max() ;

            //find sum of min and max 
           // var sum = min + max;
           if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();

            if (str1.Length > str2.Length) {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {

            //throw new NotImplementedException();
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
                int sum = 0;
            
           foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            int evens = 0;
            foreach( int num in numbers)
            {
                if(num %2 ==0)
                {
                    evens += num;
                }
                
            }
            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
                
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();

            //if sum of numbers below number presented is odd together
            //then return that number
            if ( number <= 0)
            {
                return 0;
            }
            return number / 2;



        }
    }
}
