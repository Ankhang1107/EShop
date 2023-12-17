using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Students
    {
        private string name;
        private int age;
        private double math;
        private double english;
        //private string infor; //đối với property chỉ có get thì không cần khai báo data member


        private const string intro = "The student's information:";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

 
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
       

        public double Math
        {
            get { return math; }
            set { math = value; }
        }
       

        public double English
        {
            get { return english; }
            set { english = value; }
        }

      /*  public string Infor
        {
            get
            {
                return $"{intro} Name: {name}, Age: {age}, Avg score: {(math + english)/2}  "; 
            }
        }
      */
               
        public string Infor =>  $"{intro} Name: {name}, Age: {age}, Avg score: {(math + english)/2}  ";

    }




    public class Teacher
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set 
            { 
                if(value >= 30)
                {
                    age = value;
                }
                else
                {
                    age = 30;
                }
            }
        }


    }
}
