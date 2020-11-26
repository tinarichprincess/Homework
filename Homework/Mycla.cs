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
    public partial class Mycla : Form
    {
        public Mycla()
        {
            InitializeComponent();
        }

        

        private void Mycla_Load(object sender, EventArgs e)
        {

            

        }
        /// <summary>
        /// 我是加法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Mycla Num = new Mycla();
            

            labAns.Text = (int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text)).ToString();

            //int unm1 = txtnum1.Text.ToString();
            //int unm2 = txtnum2.Text.ToString();
            //MessageBox.Show(txtans.ToString());
            //txtans.Text = txtnum1 + txtnum2;
        }
        
        /// <summary>
        /// 我是乘法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butmul_Click_1(object sender, EventArgs e)
        {
            int unm1 = int.Parse(txtnum1.Text);
            int unm2 = int.Parse(txtnum2.Text);
            //摳連
            labAns.Text = (unm1 * unm2).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void butSub_Click(object sender, EventArgs e)
        {
          labAns.Text = (int.Parse(txtnum1.Text) - int.Parse(txtnum2.Text)).ToString();
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            labAns.Text = (double.Parse(txtnum1.Text) / double.Parse(txtnum2.Text)).ToString();
        }

        private void labAns_Click(object sender, EventArgs e)
        {

        }
    }
}
