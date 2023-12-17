using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    public abstract class BaseStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Math { get; set; }
        public double Lit { get; set; }

        public BaseStudent(string name, int age, double math, double lit)
        {
            Name = name;
            Age = age;
            Math = math;
            Lit = lit;
        }

        public double CaculateAvg()
        {
            return (Math + Lit) / 2;
        }




    }


     
}
