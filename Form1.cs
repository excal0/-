﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            else if (radioButton2.Checked)
            {
               Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (radioButton3.Checked)
            {
               Form4 form4 =new Form4();
                form4.Show();
                this.Hide();
            }
            else if(radioButton4.Checked)
                    {
                Form5 form5 =new Form5();
                form5.Show();
                this.Hide();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
