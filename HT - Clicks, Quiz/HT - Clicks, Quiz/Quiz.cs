using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_intro_homework
{
    class Quiz
    {
        public List<Question> questions = new List<Question>();

        public void AddQuestion(Question q) {
            questions.Add(q);
        }
        
        public void Run()
        {
            int trueAns = 0, falseAns = 0;

            foreach (var item in questions)
            {
                
                DialogResult dialog = MessageBox.Show(item.question, $"Quiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                switch (dialog)
                {
                    case DialogResult.Yes:
                        if (item.answer) trueAns++;
                        else falseAns++;
                        break;
                    case DialogResult.No:
                        if (!item.answer) trueAns++;
                        else falseAns++;
                        break;
                }

               
            }

            Console.WriteLine($"Correct answer: {trueAns}\nIncorrect answer: {falseAns}\nTotal questions: {questions.Count}");
        }
    }
}
