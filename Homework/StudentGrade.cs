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

        public int SumChi, SumEng, SumMath;



        private void button1_Click(object sender, EventArgs e)
        {
            //bool a = false;
            //if(!a == true)
         

            int Tol, Aver, Max, Min;
            Student Stu = new Student();
            Stu.Name = txtName.Text;
            Stu.ChineseGrade = int.Parse(txtChi.Text);
            Stu.EngGrade =int.Parse( txtEng.Text);
            Stu.MathGrade = int.Parse(txtMath.Text);

            Tol = (Stu.MathGrade + Stu.ChineseGrade + Stu.EngGrade);
            Aver = Tol / 3;
           
            if(Stu.ChineseGrade > Stu.EngGrade)
            {
                Max = Stu.ChineseGrade;
            }
            else
            {
                Max = Stu.EngGrade;
            }
            if (Max < Stu.MathGrade)
            {
                Max = Stu.MathGrade;
            }
            //////////////////////////////////////////////////////////////////////////
            if (Stu.ChineseGrade < Stu.EngGrade)
            {
                Min = Stu.ChineseGrade;
            }
            else
            {
                Min = Stu.EngGrade;
            }
            if (Min > Stu.MathGrade)
            {
                Min = Stu.MathGrade;
            }


            label5.Text +=Environment.NewLine+$" {Stu.Name}       {Stu.ChineseGrade}      {Stu.EngGrade}       {Stu.MathGrade}      {Tol}      {Aver}       {Min}       {Max}";



            SumChi += Stu.ChineseGrade;
            SumEng += Stu.EngGrade;
            SumMath += Stu.MathGrade;



     //List<Student> listu = new List<Student>();

            //       listu.Add(Stu);




        }

        void ShowStudent()
        {
            //label1.Text =Student
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Tol, Aver, Max, Min;

            Random Rn = new Random();
            Student Stu = new Student();
            Stu.Name = " Tina";
            Stu.ChineseGrade = Rn.Next(0, 100);
            Stu.EngGrade = Rn.Next(0, 100);
            Stu.MathGrade = Rn.Next(0, 100);

            Tol = (Stu.MathGrade + Stu.ChineseGrade + Stu.EngGrade);
            Aver = Tol / 3;

            if (Stu.ChineseGrade > Stu.EngGrade)
            {
                Max = Stu.ChineseGrade;
            }
            else
            {
                Max = Stu.EngGrade;
            }
            if (Max < Stu.MathGrade)
            {
                Max = Stu.MathGrade;
            }
            //////////////////////////////////////////////////////////////////////////
            if (Stu.ChineseGrade < Stu.EngGrade)
            {
                Min = Stu.ChineseGrade;
            }
            else
            {
                Min = Stu.EngGrade;
            }
            if (Min > Stu.MathGrade)
            {
                Min = Stu.MathGrade;
            }

            SumChi += Stu.ChineseGrade;
            SumEng += Stu.EngGrade;
            SumMath += Stu.MathGrade;




            label5.Text += Environment.NewLine + $" {Stu.Name}       {Stu.ChineseGrade}      {Stu.EngGrade}       {Stu.MathGrade}      {Tol}      {Aver}       {Min}       {Max}";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Tol, Aver, Max, Min;

            Random Rn = new Random();
            Student Stu = new Student();
            Stu.Name = " Tina";

            for (int i = 0; i <20; i++)
            {
            Stu.ChineseGrade = Rn.Next(0, 100);
            Stu.EngGrade = Rn.Next(0, 100);
            Stu.MathGrade = Rn.Next(0, 100);





                Tol = (Stu.MathGrade + Stu.ChineseGrade + Stu.EngGrade);
                Aver = Tol / 3;

                if (Stu.ChineseGrade > Stu.EngGrade)
                {
                    Max = Stu.ChineseGrade;
                }
                else
                {
                    Max = Stu.EngGrade;
                }
                if (Max < Stu.MathGrade)
                {
                    Max = Stu.MathGrade;
                }
                //////////////////////////////////////////////////////////////////////////
                if (Stu.ChineseGrade < Stu.EngGrade)
                {
                    Min = Stu.ChineseGrade;
                }
                else
                {
                    Min = Stu.EngGrade;
                }
                if (Min > Stu.MathGrade)
                {
                    Min = Stu.MathGrade;
                }

                SumChi += Stu.ChineseGrade;
                SumEng += Stu.EngGrade;
                SumMath += Stu.MathGrade;



                label5.Text += Environment.NewLine + $" {Stu.Name}       {Stu.ChineseGrade}      {Stu.EngGrade}       {Stu.MathGrade}      {Tol}      {Aver}       {Min}       {Max}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "姓名     國文     英文     數學     總分     平均     最低     最高 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student Stu = new Student();
            
            call_ave();
           
       
        }

        void call_ave()
        {
            label6.Text = Environment.NewLine + $" 總分：                           {SumChi}         {SumEng}         {SumMath}";
        }

    }
}
