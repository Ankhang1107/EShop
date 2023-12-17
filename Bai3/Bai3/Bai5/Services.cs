using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Services
    {
        /*
        public string GetMessage1(int code)
        {
            switch (code)
            {
                case 200:
                    return "OK";
                case 404:
                    return "Not found";
                case 400:
                    return "Bad request";
                case 401:
                    return "unauthorized";
                case 500:
                    return "internal error";
                default:
                    return "code is not defined";
            }
        }

            public string GetMessage2(int code)
            {
                string result = "";
                switch (code)
                {
                    case 200:
                        result = "OK";
                        break;
                    case 404:
                        result = "Not found";
                        break;
                    case 400:
                        result = "Bad request";
                        break;
                    case 401:
                        result = "unauthorized";
                        break;
                    case 500:
                        result = "internal error";
                        break;
                    default:
                        result = "code is not defined";
                        break;
                }
                return result;
            }

        public string DayCheck(int num)
        {
            switch(num)
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wedsday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                default:
                    return "Error";
            }
        }


        public void PrintNumber(int inpNum)
        {
            for (int i = 0; i < inpNum; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintNumberWithWhile()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void EnterInfor()
        {
            string name = "";
            bool isContinuos = true;
            int age = 0;
            while (isContinuos)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.Write("Enter age: ");
                bool check = int.TryParse(Console.ReadLine(), out age) && age >= 12 && age <= 15;

                while (!check)
                {
                    Console.WriteLine("Please input the correct age");
                    check = int.TryParse(Console.ReadLine(), out age) && age >= 12 && age <= 15;
                }
                Console.WriteLine($"name: {name}, age: {age}");
                Console.WriteLine("Do you want to continous?, y/n");

                isContinuos = Console.ReadLine() == "y"; 
            }
        }


        public void SumByFor()
        {
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum += i;       
                
            }
            Console.WriteLine("sum = " + sum);
        }
        */

        int age;
        String name = "";
        bool checkContinuos = true;
        public void check()
        {

            while(checkContinuos)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Age: ");
                bool checkAge = int.TryParse(Console.ReadLine(), out age) && age >= 12 && age <= 15;

                while (!checkAge)
                {
                    Console.WriteLine("Re-Enter Age! ");
                    checkAge = int.TryParse(Console.ReadLine(), out age) && age >= 12 && age <= 15;
                }

                Console.WriteLine("-----------------");
                Console.WriteLine($"name: {name} --- age: {age}");
                Console.WriteLine("Do you want to continous?, y/n");
                

                checkContinuos = Console.ReadLine() == "y";
            }
            

        }
    }

  

}
