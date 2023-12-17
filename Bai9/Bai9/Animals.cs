using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public abstract class Animals
    {

        public Animals(string name, double weight) 
        { 
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public double Weight { get; set; }

        public abstract void Sound();
    }

    public class Cat : Animals
    {
        public Cat(string name, double weight) : base(name, weight)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
    
    public class Dog : Animals
    {
        public Dog(string name, double weight) : base(name, weight)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Gau");
        }
    }
 

}
