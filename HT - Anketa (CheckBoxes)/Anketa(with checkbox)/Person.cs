using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa_with_checkbox_
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public string EnglishKnowledge { get; set; }
        public Image img { get; set; }
        public List<string> hobbies { get; set; } = new List<string>();

        public Person()
        {
            
        }
    }
}
