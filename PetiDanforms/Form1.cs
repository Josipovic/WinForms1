using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetiDanforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string text)
        {
            Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "ovo je novi tekst";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Visible == true)
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Text = "mis je iznad tipke";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Text = "mis je iznad tipke 2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            t.Text = "neki textbox";
            t.Width = 200;
            Controls.Add(t);

            Button b = new Button();
            b.Text = "obicni button";
            b.Left = 100;
            b.Top = 0;
            Controls.Add(b);

            NapredniButton a = new NapredniButton();
            a.Text = "napredni button";
            Controls.Add(a);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1("ovo je text");
            forma.Show();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

        }
    }
}
  