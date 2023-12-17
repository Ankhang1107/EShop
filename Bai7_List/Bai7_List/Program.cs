namespace Bai7_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>();
            var number1 = new List<int>() {1, 3, 5, 7 };
            var number2 = new List<int>() { 2, 4, 6, 8};

            var student = new List<string>();

            student.Add("nam");
            student.Add("khang");
            student.Add("chuong");
            student.Add("luy");

            student.Remove("khang");
            




            //add phần tử
            number.Add(4);
            number.Add(5);
            number.AddRange(number1);

            //remove phần tử
            var length =  number2.Count;
            number2.Remove(2); 

            Console.ReadKey();
        }
    }
}