namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chuyen anh
            EngStudent eng1 = new EngStudent("nam", 20, 6, 7, 8);
            var avg1 = eng1.CaculateAvg();


            Student eng2 = new EngStudent("nu", 21, 4, 5, 6);
            var avg2 = eng2.CaculateAvg();
           


            //chuyen su
            var his1 = new HisStudent("hoang", 20, 4, 6, 8);
            var his2 = new HisStudent("anna", 20, 6, 7, 8);

            var listStudent = new List<Student>() { eng1, eng2, his1, his2 };  
            foreach(var student in listStudent)
            {
                Console.WriteLine(student.CaculateAvg());
            }

            foreach(var item in listStudent)
            {
                if(item is HisStudent)
                {
                    Console.Write("avg of His = ");
                    Console.WriteLine(item.CaculateAvg());
                }
            }

            Console.ReadKey();
        }
    }
}