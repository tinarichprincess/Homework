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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string eng = txteng.Text;
            string sex = txtsex.Text;
            string con = txtcon.Text;

       
            

            MessageBox.Show("Hello,"+"我是"+name+"\n"+"英文名子是"+eng+ "\n" + "性別是" + sex + "\n" + "星座是" + con + "\n" + "很高興認識你。");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string eng = txteng.Text;
            string sex = txtsex.Text;
            string con = txtcon.Text;




            MessageBox.Show("Hi," + "我是" + name + Environment.NewLine + "英文名子是" + eng + Environment.NewLine + "性別是" + sex + Environment.NewLine + "星座是" + con + Environment.NewLine + "很高興認識你。");
        }
    }
    }

