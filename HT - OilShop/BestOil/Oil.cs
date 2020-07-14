using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    public class Oil
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public double Litr { get; set; }

        double sum { get; set; }
        public double Sum()
        {
            return this.sum = this.Price * this.Litr;
        }

        public Oil()
        {

        }
    }
}
