using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIsPalindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Using Recursion
            IsPalindrome p = new IsPalindrome();
            label1.Text = p.isPalindrome(textBox1.Text).ToString();


        }
    }
}
