using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }

                if (numbers[i] % 2 != 0)
                {
                    sum -= numbers[i];
                }
            }

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var str1A = str1.ToCharArray();
            var str2A = str2.ToCharArray();
            var str3A = str3.ToCharArray();
            var str4A = str4.ToCharArray();
            if (str1A.Length <= str2A.Length && str1A.Length <= str3A.Length && str1A.Length <= str4A.Length)
            {
                return str1A.Length;
            }

            if (str2A.Length <= str3A.Length && str2A.Length <= str4A.Length && str2A.Length <= str1A.Length)
            {
                return str2A.Length;
            }

            if (str3A.Length <= str4A.Length && str3A.Length <= str2A.Length && str3A.Length <= str1A.Length)
            {
                return str3A.Length;
            }
            else
            {
                return str4A.Length;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }

            if (number2 <= number1 && number2 <= number4 && number2 <= number3)
            {
                return number2;
            }

            if (number3 <= number2 && number3 <= number4 && number3 <= number1)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength2 + sideLength3 <= sideLength1 || sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            var canParse = double.TryParse(input, out double number);
            if (canParse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
           double sumOfNulls = 0;

           for (int i = 0; i < objs.Length; i++)
           {
               if (objs[i] == null)
               {
                   sumOfNulls++;
               }
           }
           double nullsOverLength = sumOfNulls / objs.Length;
           if (nullsOverLength > .5)
           {
               return true;
           }
           else
           {
               return false;
           }
        }

        public double AverageEvens(int[] numbers)
        {
            var evens = new List<double>();
            double sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }
            for (int i = 0; i < evens.Count; i++)
            {
                sum += evens[i];
            }
            if (evens.Count == 0)
            {
                return 0;
            }
            return sum / evens.Count;
        }

        public int Factorial(int number)
        {
           int answer = 1;

           for (int i = 1; i <= number; i++)
           {
               answer *= i;
           }
           return answer;
        }
    }
}
