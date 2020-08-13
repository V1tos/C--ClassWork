using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT___Exam
{
    public partial class TestForm : Form
    {
        List<Question> questions;
        int questionIndex = 0;
        int trueAnswersCount = 0;
        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
            pb1.Maximum = questions.Count();
            GetQuestion(questionIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CheckTrueAnswers(questionIndex);
            questionIndex++;
            if (questionIndex == questions.Count - 1)
            {
                btnFinish.Enabled = true;
                btnNext.Enabled = false;
            }
            GetQuestion(questionIndex);          
        }

        private void CheckTrueAnswers(int questionIndex)
        {
            foreach (var item in clbAnswers.CheckedItems)
            {
                if (((Answer)item).IsTrue)
                {
                    questions[questionIndex].IsSelectedTrueAnswer = true;
                    trueAnswersCount++;
                }
                else
                {
                    questions[questionIndex].IsSelectedTrueAnswer = false;
                }
            }
        }

        private void GetQuestion(int questionIndex)
        {
            clbAnswers.Items.Clear();
            lblCount.Text = $"{questionIndex + 1}/{questions.Count}";
            lblQuestion.Text = questions[questionIndex].Text;
            ++pb1.Value;
            FillAnswers(questionIndex);
        }

        private void FillAnswers(int questionIndex)
        {
            int answersCount = questions[questionIndex].answers.Count;
            for (int i = 0; i < answersCount; i++)
                clbAnswers.Items.Add(questions[questionIndex].answers[i]);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            CheckTrueAnswers(questionIndex);

            DialogResult dr = MessageBox.Show($"You answered {trueAnswersCount} questions correctly", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                this.Close();
        }
    }
}
