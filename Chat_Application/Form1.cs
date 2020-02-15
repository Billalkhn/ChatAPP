using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "rbchat" & textBox2.Text == "12345")
            {
                chat_panel cp = new chat_panel();
                cp.Show();
                this.Hide();

            }
            else if (textBox1.Text == null && textBox2.Text == null)
            {
                MessageBox.Show("enter username and password");
            }
            else
            {
                MessageBox.Show("Wrong username  or Password");
                textBox1.Text = null;
                textBox2.Text = null;


            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
