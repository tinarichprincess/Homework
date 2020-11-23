using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }

        string result;

        int a, b, c;
        int aa, bb, cc;
        int max,min = 0;

      

        struct Grade
        {
            public string Name;
            public int GradeChinese;
            public int GradeEng;
            public int GradeMath;
            
            
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            //butSave.Click += ButSave_Click_Method;
            //butShow.Click += ButShow_Click_method;

            Grade grade;

            grade.Name = txtName.Text;
            grade.GradeChinese = int.Parse(txtChi.Text);
            grade.GradeEng = int.Parse(txtEng.Text);
            grade.GradeMath = int.Parse(txtMat.Text);

           result = "姓名是：" + grade.Name + Environment.NewLine + "國文成績是：" + grade.GradeChinese + Environment.NewLine + "英文成績是：" + grade.GradeEng + Environment.NewLine + "數學成績是：" + grade.GradeMath;

        }

        private void ButShow_Click_method(object sender, EventArgs e)
        {
            //txtgrade.Text = "姓名是：" + txtName.Text + Environment.NewLine + "國文成績是：" + txtChi.Text + Environment.NewLine + "英文成績是：" + txtEng.Text + Environment.NewLine + "數學成績是：" + txtMat.Text;

           


        }

        private void ButSave_Click_Method(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtChi.Text);
            b = int.Parse(txtEng.Text);
            c = int.Parse(txtMat.Text);

            aa = int.Parse(txtChi.Text);
            bb = int.Parse(txtEng.Text);
            cc = int.Parse(txtMat.Text);


            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }






           ///////////////////////////////////////////////
            if (aa > bb)
            {
                min = bb;
            }
            else
            {
                min = aa;
            }

            if (cc < min)
            {
                min = cc;
            }
     
            txtCompare.Text = "分數最低為：" + min.ToString()+Environment.NewLine+ "分數最高為：" + max.ToString();


        }

        private void butShow_Click(object sender, EventArgs e)
        {
            txtgrade.Text = result;
        }
    }
}
