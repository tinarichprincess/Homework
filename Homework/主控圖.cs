﻿using System;
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
    public partial class 主控圖 : Form
    {
        public 主控圖()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pos newform = new Pos();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentGrade newform = new StudentGrade();
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mycla newform = new Mycla();
            newform.Show();
        }
    }
}
