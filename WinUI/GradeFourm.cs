using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**
* 2/2/2022
* CSC 153
* Ramsey Mccue
* A hardcoded grading program in which a students multiple choice exam is graded with UI feedback. 
*/


namespace WinUI
{
    public partial class GradeFourm : Form
    {
        public GradeFourm()
        {
            InitializeComponent();
        }

        private void GradeFourmLoaded(object sender, EventArgs e)
        {
            //Input
            char[] examAnswers = { 'B', 'B', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
            char[] studentAnswers = { 'D', 'B', 'A', 'D', 'B', 'C', 'C', 'A', 'A', 'C', 'D', 'C', 'B', 'C', 'B', 'B', 'D', 'D', 'B', 'A' };

            //Process 
            List<int> missedQuestions = new List<int>();
            int correctAnswers = 0;
            int incorrectAnswers = 0;
            decimal grade;

            for (int index = 0; index < studentAnswers.Length; index++)
            {
                if (studentAnswers[index] != examAnswers[index])
                {
                    incorrectAnswers++;
                    missedQuestions.Add(index + 1);
                }
                else
                {
                    correctAnswers++;
                }
            }

            grade = (decimal)correctAnswers / 20;

            //Output 
            if (correctAnswers >= 15)
            {
                passingStatusTextBox.Text = "You Passed! :D";
            }
            else
            {
                passingStatusTextBox.Text = "You Failed! D:";
            }

            gradeTextBox.Text = grade.ToString() + "%";
            correctlyAnsweredTextBox.Text = correctAnswers.ToString();
            incorrectlyAnsweredTextBox.Text = incorrectAnswers.ToString();

            foreach(int missedQuestion in missedQuestions)
            {
                missedQuestionsListBox.Items.Add("Question " + missedQuestion);
            }
        }


    }
}
