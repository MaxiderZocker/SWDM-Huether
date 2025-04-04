﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT11Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, null));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + " + ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + " - ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + " * ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = textBoxAnzeige.Text + " / ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String del = textBoxAnzeige.Text;
            if (del.Length > 0)
            {
                char last = del.Last();
                if (last == ' ')
                {
                    textBoxAnzeige.Text = del.Remove(del.Length - 3);
                }
                else
                {
                    textBoxAnzeige.Text = del.Remove(del.Length - 1);
                }
                
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string expression = textBoxAnzeige.Text;
            double result = Evaluate(expression);
            textBoxAnzeige.Text = result.ToString();
            string expression2 = textBoxAnzeige.Text;
            textBoxAnzeige.Text = expression2.Replace(",", ".");
        }
    }
}
