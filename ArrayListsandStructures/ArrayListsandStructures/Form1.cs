using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListsandStructures
{
    public partial class Form1 : Form
    {
        private struct Grade
        {
            public int MaxScore;
            public string LetterGrade;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList GradesList = new ArrayList();

        private Grade grade;
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGradesList(299, "F");
            FillGradesList(349, "D");
            FillGradesList(399, "C");
            FillGradesList(449, "B");
            FillGradesList(499, "A");
        }
        private void FillGradesList(int maxScore, string letterGrade)
        {
            grade.MaxScore = maxScore;
            grade.LetterGrade = letterGrade;
            GradesList.Add(grade);
        }
        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            string letterGrade = string.Empty;
            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Enter a number dumbass!");
                return;
            }
            else
            {
               int entry = Convert.ToInt16(txtScore.Text);
               foreach (Grade grade in GradesList)
                {
                    if (entry <= grade.MaxScore)
                    {
                        letterGrade = grade.LetterGrade;
                        MessageBox.Show("Grade is: " + letterGrade);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("that entry is not valid.");
                    }
                }

            }

        }

    }
}




