namespace LearnFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            service sv = new service();

            //double result = sv.sum(1, 2);
            //double shcn = sv.Shcn(2, 4);
            //double sht = sv.Sht(3);
            double avgResult = StaticService.CaculateAvg(5, 6);
            double accResult = StaticService.acc(5,6);
            Console.WriteLine(avgResult);
            Console.WriteLine(accResult);

            //Console.WriteLine(result);
            //Console.WriteLine(shcn);
            //Console.WriteLine(sht);

            //service check = new service();

            service test = new service();
             
            //Console.Write("Diem = ");
            //check.CheckLevel();
            test.EvaluateStudent(6);

            Console.WriteLine();
        }

        
    }
}