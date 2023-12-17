namespace Bai6_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] number = new int[5] { 1, 2, 3 , 4, 6};
            double[] score = {1,2,3,4,5,6, 9, 7};
            //string[] fruits = new string[5];
            //fruits[0] = "orange";

            Console.WriteLine("value elemtn 2st = " + number[1]);
            Console.WriteLine("value elemtn 4st = " + number[3]);

            int lenght = score.Length;
            double lastElement = score[lenght - 1];
            
            double lastEle = score[^1];
            */


            int[] numArray = new int[5] { 1, 9, 11, 4, 6 };
            Services getSum = new  Services();

            //getSum.GetSumArray();
            
            Console.WriteLine("sum = " + getSum.SumArray2(numArray));
            Console.WriteLine("Max = " + getSum.findMax(numArray));
            Console.WriteLine("avg = " + getSum.GetSumOddAvg(numArray));
            Console.ReadKey();
        }
    }
}