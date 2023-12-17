using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Motorbike
    {
        private const string Intro = "Bike's information";
        private readonly string _intro;

        public Motorbike()
        {
            _intro = "Bike's information: ";
        }

        public Motorbike(string brandBike, string nameBike, int hpBike)
        {
            string brand = brandBike;
            string name = nameBike;
            int hp = hpBike;
        }

        public string Brand { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }

        public string Infor => $"{_intro} {Brand = "Honda"} {Name = "AIR"} {Hp = 20}";

        public string Info1
        {
            get
            {

                return $"{_intro}{Brand} - {Name} - {Hp}";
            }
        }
    }
}
