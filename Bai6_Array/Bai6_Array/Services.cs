using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Array
{
    internal class Services
    {
        public void GetSumArray()
        {
            int elementOfArray = 0;
            double sum = 0;
            Console.Write("number of elements = ");
            elementOfArray = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < elementOfArray; i++)
            {
                Console.Write("Value of element " + i + " = ");
                double elements = double.Parse(Console.ReadLine());
                if(elements %2 == 0)
                {
                    sum += elements;
                }
                
            }
            Console.Write("sum of array = " + sum);
        }


        public int SumArray1(int[] numbers)
        {
            int sum = 0;
            for (int i = 0;i < numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;

        }

        public int SumArray2(int[] numbers)
        {
            int sum = 0;
            
            foreach (int num in numbers)
            {
                if (num %2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public int GetSumOddAvg(int[] numbers)
        {
            int sum = 0;
            int count = 0;
            int avg = 0;
            foreach(int num in numbers)
            {
                if(num %2 != 0)
                {
                    sum += num;
                    count++;                   
                }               
            }
            avg = sum / count;
            return avg;
        }

        public int findMax(int[] numbers)
        {
            int max = numbers[0];
            int count = numbers.Length;
            /*
            for (int i =0; i< count; i++ )
            {
               
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
            }
            */

            foreach (int i in numbers)
            {
                if (i >= max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
