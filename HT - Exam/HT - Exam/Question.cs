using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT___Exam
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> answers = new List<Answer>();
        public bool IsSelectedTrueAnswer { get; set; } = false;
        public Question()
        {

        }
    }
}
