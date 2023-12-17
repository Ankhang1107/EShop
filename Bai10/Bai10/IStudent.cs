using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    public interface IStudent
    {
        double CaculateAvg();
    }


    public interface IHasId
    {
        public Guid Id { get; set; }


    }


    public interface IHasDateTime
    {
        public DateTime CreatedDate { get; set; }
    }
}
