namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var messi = new Students();

            var ronaldo = new Students() { Name = "CR7", Age = 38, Math = 8, English = 8 };

            


            var john = new Teacher();

            Console.WriteLine(ronaldo.Infor);
            john.Name = "John";
            john.Age = 40;

            /* messi.name = "M10";
             messi.age = 30;
             messi.math = 10;
             messi.english = 6;
            */


            //Constructor
            var wave = new Motorbike() { Name = "Wavealpha", Brand = "Honda", Hp = 10 };
            var airblade = new Motorbike("Honda", "Airblade", 10);

            

            Console.ReadKey();
        }

        
    }
}