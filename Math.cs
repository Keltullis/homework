using System;

namespace homework
{
    public class ClsMath
    {
       
        public int sum(int[] numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }

       
        public int max(int[] numbers)
        {
           
            if (numbers.Length == 0) return 0;
           
            int result = numbers[0];
            foreach (var number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }

       
        public int min(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
           
            int result = numbers[0];
            foreach (var number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }

       
        public int count(int[] numbers)
        {
            return numbers.Length;
        }
    }
}