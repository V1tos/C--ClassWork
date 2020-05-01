using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Lesson_7___Event_planner
{
    [Serializable]

    public class Event
    {
        public string Name { get; set; } = String.Empty;
        public string Place { get; set; } = String.Empty;
        public string Priority { get; set; } = String.Empty;
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name} {Place} {Priority} {Date.Month.ToString()}/{Date.Day.ToString()}/{Date.Year.ToString()}";
        }
    }
}
