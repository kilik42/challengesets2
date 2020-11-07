using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            List<int>[] arr = ;
            
            for (int i = startNumber; i < 100; i++)
            {
                if (i % n == 0)
                {
                    arr.Add();//this is not working for some reason
                }
            }
            throw new NotImplementedException();

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //var business = new Business();
            foreach(Business bus in businesses)
            {
                if (bus.TotalRevenue < 0)
                {
                    //change name
                    bus.Name = "closed";
                }
            }
            //throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            IEnumerable<int> sortAscending =
                from num in numbers
                orderby num
                select num;

            Console.WriteLine($"Ascending");
            foreach (int s in sortAscending)
            {
                Console.WriteLine(s);
                
            }
            return true;


            //throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
            //throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            foreach(string word in words)
            {
                sentence += word + " ";
            }
            Console.WriteLine(sentence) ;
            return sentence;
            //throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {

            foreach(double element in elements)
            {

            }
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
