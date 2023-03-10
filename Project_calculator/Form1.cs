using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.linkLabel1.Links.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.label1.Text = "";
            this.main_label.ResetText();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text +"2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text +"3";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + ".";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {

            double firstnum, secondnum,res=0;

            double.TryParse(this.First_num_label.Text, out firstnum);
            double.TryParse(this.main_label.Text, out secondnum);
         
            if (this.op_name_label.Text == "+")
            {
              
                res= firstnum + secondnum;
          

            }

            if (this.op_name_label.Text == "-")
            {

                res = firstnum - secondnum;


            }
            if (this.op_name_label.Text == "x")
            {

                res = firstnum * secondnum;


            }
            if (this.op_name_label.Text == "%")
            {

                res = firstnum / secondnum;


            }

            this.main_label.Text = res.ToString();
            this.First_num_label.Text = "";
            this.op_name_label.Text = "";



        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.op_name_label.Text ="+";
            if(this.main_label.Text!= "")
            {
                this.First_num_label.Text = this.main_label.Text;
            }
            
            this.main_label.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.op_name_label.Text = "-";
            if (this.main_label.Text != "")
            {
                this.First_num_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.main_label.Text =this.main_label.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.op_name_label.Text = "x";
            if (this.main_label.Text != "")
            {
                this.First_num_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.op_name_label.Text = "%";
            if (this.main_label.Text != "")
            {
                this.First_num_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }

        private void First_num_label_Click(object sender, EventArgs e)
        {
         
        }
    }
}
