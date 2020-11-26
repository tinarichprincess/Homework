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
    public partial class Guess_Number : Form
    {
        public Guess_Number()
        {
            InitializeComponent();
        }

        int Ran;
        int i = 0;
        int Number =0;
        Random an = new Random();
       // int Ran = new Random().Next(1, 100);
        int left = 1 , right = 100;
        private void button3_Click(object sender, EventArgs e)
        {
            Ran = an.Next(1, 100);
            butGuess.Enabled = true;
            butShow.Enabled = true;
            txtEnterNumber.Enabled = true;
        }

        private void butGuess_Click(object sender, EventArgs e)
        {
            //Ran = an.Next(1, 100);
            Number = int.Parse(txtEnterNumber.Text.Trim());
           
                                                                 

           // if ((left < Number || right > Number) && first)
           // {
           // }
           //
           //else
           //{
                //ans:50
                //guess :60
                //1-60
                //65
                if (Number > Ran)
                {
                    if (Number<right) {
                    right = int.Parse(txtEnterNumber.Text);

                    label1.Text = left + " between " + right + Environment.NewLine + "小一點";
                    txtEnterNumber.Text = "";
                    txtEnterNumber.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"請猜：{left}    between  { right}", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (Number < Ran)
                { 
                    if (Number > left)
                    {
                        left = int.Parse(txtEnterNumber.Text);
                        label1.Text = left + " between " + right + Environment.NewLine + "再大一點";
                        txtEnterNumber.Text = "";
                        txtEnterNumber.Focus();
                }
                else
                {
                    MessageBox.Show($"請猜：{left}    between  { right}", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                else if (Number == Ran)
                {
                    label1.Text = "BINGOOOOO!";
                    txtEnterNumber.Text = "";
                    txtEnterNumber.Focus();
                }
           // }

        }

        private void butShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"正確答案是：{Ran}");
          
        }
    }
}
