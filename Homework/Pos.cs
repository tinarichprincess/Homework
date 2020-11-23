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
    public partial class Pos : Form
    {
        public Pos()
        {
            InitializeComponent();
        }

        int sum = 0;
        int MiKasa = 400;
        int Molten = 350;
        int Conti = 280;
        int Star = 100;

        int a, b, c, d = 0;
        string show;

        bool def  =  false,  mika  =  false, Mol  =  false, Sta  =  false, Con  =  false;

        private void Pos_Load(object sender, EventArgs e)
        {

        }

        private void butMika_Click(object sender, EventArgs e)
        {
            def = true; 
            
            sum += MiKasa;
            labPrice.Text = sum.ToString();
            Console.WriteLine("NT" + sum.ToString());
            a += 1;
            if (!mika)
            {
                txtlist.Text += $"排球:MiKasa x {a.ToString()} 個,共{a * 400}元";
                mika = true;
            }else
            {

            }

        }

        private void butMol_Click(object sender, EventArgs e)
        {
            def = true;
            Mol = true;
            sum += Molten;
            labPrice.Text = sum.ToString();
            b += 1;
            txtlist.Text += Environment.NewLine + $"排球:Molten x {b.ToString()} 個,共{b * 350}元";
    
        }

        private void butCon_Click(object sender, EventArgs e)
        {
            def = true;
            sum += Conti;
            labPrice.Text = sum.ToString();
            c += 1;
            txtlist.Text = Environment.NewLine+Environment.NewLine + $"排球:Conti x {c.ToString()} 個,共{c * 280}元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            def = false;
            mika = false;
            Mol = false; 
            Sta = false;
            Con = false;

            labPrice.Text = "";
            txtlist.Text = "";
            txtlist.Text = "尚未購買";

        }

        private void butSta_Click(object sender, EventArgs e)
        {
            def = true;
            sum += Star;
            labPrice.Text = sum.ToString();
            d += 1;
            txtlist.Text = Environment.NewLine+ Environment.NewLine+Environment.NewLine+ $"排球:Star x {d.ToString()} 個,共{d * 100}元";

        }

        private void butcash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額：NT$" +sum.ToString()+"元");

        }

        private void butcard_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            a = sum;
            b = a * 0.9;
            //a是總金額,b是折扣後
            MessageBox.Show("總金額：NT$"+a+"元"+"\n"+"折扣後金額：NT$"+b+"元" );

        }
    }
}
