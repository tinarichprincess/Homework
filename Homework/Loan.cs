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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        // txtMoney.Text = "";
        //    txtMonth.Text = "";
        //    txtPercent.Text = "";

        double Mony, Month, Percent = 0;
        string result;
        double PerMony;
      
           


        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            Mony =double.Parse(txtMoney.Text);
            Month = double.Parse(txtMonth.Text);
            Percent = double.Parse(txtPercent.Text);

            PerMony = Mony / Month;
           
            for (int i = 1; i <= Month; i++) 
            {
                result += i + "\n";
            }

            label7.Text = result;

        }

    }
}
