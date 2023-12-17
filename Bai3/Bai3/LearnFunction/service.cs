using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFunction
{
    public class service
    {
        public double sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double Shcn(double a, double b)
        {
            double s = a * b;
            return s;
        }

        public double Sht(double r)
        {
            double s = 2*3.14*r;
            return s;
        }


        public void CheckLevel()
        {
            double score = double.Parse(Console.ReadLine());

            if(score < 5)
            {
                Console.WriteLine("Hoc luc Yeu");
            }
            else if(score == 5)
            {
                Console.WriteLine("Hoc luc TB");
            }

            else if(score > 5)
            {
                Console.WriteLine("Hoc luc Kha");
            }
        }


        public string EvaluateStudent(double score)
        {
            string state = "";
            if(score == 5)
            {
                state = "avg";
            }

            if(score > 5)
            {
                state = "good";
            }
            else
            {
                state = "bad";
            }

            Console.WriteLine("Evaluate is: " + state);
            return state;

        }
    }
}
