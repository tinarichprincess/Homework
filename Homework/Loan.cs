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
            //txtMoney.Text = "0";
            //txtMonth.Text = "0";
            //txtPercent.Text = "0";
        }

        

        decimal Mony, Month, Percent = 0;
        string result;
        
        int PerMoney = 0;
        decimal Balance, intrest,Tol,Payment;

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

 

        private void button1_Click(object sender, EventArgs e)
        {
           Mony = decimal.Parse(txtMoney.Text);
            Month = decimal.Parse(txtMonth.Text);
            Percent = decimal.Parse(txtPercent.Text);

           

            if (Mony != 0 && Month != 0)
            {
                //每月償還本金
                PerMoney = (int)Math.Round(Mony / Month, 0);
            }
            else
            {
                MessageBox.Show("你他媽給我輸入數字哦!!");
            }
            
            for (int i = 0; i < Month; i++) 
            {
               
                //本金餘額
                Balance = (Mony - (PerMoney * i));
                //償還利息
                intrest = Math.Round(Balance * (Percent/100 / 12), 0);

                //本期應繳金額
                Payment = PerMoney + intrest;

                //全部利息
                Tol += intrest;


                result += $"期數：{i+1}   償還本金：{PerMoney}  償還利息：{intrest}  本期應繳金額{Payment}" + "\n";
            }

            label7.Text = result;
            txttol.Text = Tol.ToString();
        }

    }
}
