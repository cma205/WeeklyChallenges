using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }

            //return char.IsLetter(c);
            //another solution^
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int x = vals.Length; //you can remove this and do the below instead
            if (x % 2 == 0) //if(vals.Length % 2 == 0)
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
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0)
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
            
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }

            //could also do: return (str1.Length < str2.length) ? str1.Length : str2.Length; << "in-line if" aka ternary operator.
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else //you can remove else and it's scope and just put return numbers.Sum(); and get the same result.
            {
                return numbers.Sum();
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                var i = numbers.Where(x => x % 2 == 0);
                return i.Sum();

                //could also remove else scope and do: return numbers.Where(num => num % 2 == 0).Sum();
            }

        }

        public bool IsSumOdd(List<int> numbers)
        {
            var x = numbers.Sum();
            
            if (x % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //instead do:
            //if(numbers == null || numbers.Count == 0)
            //{return false;}
            //return (numbers.Sum() % 2 != 0) ? true: false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
            
            
            
            

            

            
                

                
            
        

            


