using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public abstract class Student
    {

        
        public Student(string name, int age, double lit, double math)
        {
            Name = name;
            Age = age;
            Lit = lit;
            Math = math;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public double Lit { get; set; }
        public double Math { get; set; }


        public abstract double CaculateAvg();

        public String infor;
      

    }


    public sealed class EngStudent : Student
    {
        public double Eng { get; set; }
        
        public EngStudent(string name, int age, double lit, double math, double eng)
            : base(name, age, lit, math)
        {
            Eng = eng;           
        }

        public override  double CaculateAvg()
        {
            return (Lit + Math + Eng*3)/5;           
        }
        public string GetInfor()
        {
            return infor;
        }
    }

    public class HisStudent : Student
    {
        public double History { get; set; }
        public HisStudent(string name, int age, double lit, double math, double history)
            :base(name, age, lit, math)
        {
            History = history;
        }

        public override double CaculateAvg()
        {
            return (Lit + Math + History * 2) / 4;
        }
    }
}
