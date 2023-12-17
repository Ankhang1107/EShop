using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    public class EngStudent : BaseStudent, IStudent, IHasId, IHasDateTime
    {
       
        public EngStudent(string name, int age, double math, double literature, double english)
            :base(name, age, math, literature)
        {
            English = english;
            ID = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
        public double English { get; set; }
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }

        public double CalculateAvg()
        {
            return (English + Math + Lit) / 3;
        }
        
    }

    public class HistoryStudent : BaseStudent, IStudent, IHasId, IHasDateTime
    {
        public double History { get; set; }
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }

        public double CalculateAvg()
        {
            return (History + Math + Lit) / 3;
        }
        public HistoryStudent(string name, int age, double math, double literature, double history) : base(name, age, math, literature)
        {
            History = history;
            ID = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
    }


}
