﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class calcer : Form
    {
        public calcer()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            view.Text =view.Text + but1.Text;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but2.Text;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but3.Text;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but4.Text;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but5.Text;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but6.Text;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but7.Text;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but8.Text;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but9.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + but0.Text;
        }

       // double ch=0;
        double a, b;
        double c = 0;
        int cout = 0;
    private void plus_Click(object sender, EventArgs e)
        {
            a = double.Parse(view.Text);
            view.Text = view.Text + plus.Text;
          cout = 1;
          view.Clear();
          //answ.Text = view.Text = view.Text + plus.Text; ;
        }

        private void min_Click(object sender, EventArgs e)
        {
            a = double.Parse(view.Text);
            view.Text = view.Text + min.Text;
            cout = 2;
            view.Clear();
        }

        private void star_Click(object sender, EventArgs e)
        {
            a = double.Parse(view.Text);
            view.Text = view.Text + star.Text;
            cout = 3;
            view.Clear();
        }

        private void slash_Click(object sender, EventArgs e)
        {
            a = double.Parse(view.Text);
            view.Text = view.Text + slash.Text;
            cout = 4;
            view.Clear();
        }

        private void perc_Click(object sender, EventArgs e)
        {
            a = double.Parse(view.Text);
            view.Text = view.Text + perc.Text;
            cout = 5;
            view.Clear();
        }

       

        private void view_TextChanged(object sender, EventArgs e)
        {

        }

        private void rese_Click(object sender, EventArgs e)
        {
            view.Clear();
            view.Focus();
        }
    }
}
