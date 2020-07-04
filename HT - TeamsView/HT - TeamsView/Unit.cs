using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT___TeamsView
{
    [Serializable]
    public class Unit
    {
        public string Name { get; set; }       
        public int HealthPoint { get; set; }

        public override string ToString()
        {
            return $"{Name} - {HealthPoint} hp";
        }

    }
}
