using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3___Anketa
{
    [Serializable]
    class Human
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Gender { get; set; }
        List<string> itLanguages = new List<string>();
        List<string> speakLanguages = new List<string>();

        public void AddItLanguage(string itLanguage)
        {
            itLanguages.Add(itLanguage);
        }

        public void AddSpeakLanguage(string speakLanguage)
        {
            speakLanguages.Add(speakLanguage);
        }

    }
}
