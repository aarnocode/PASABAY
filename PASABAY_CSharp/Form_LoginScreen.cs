using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASABAY_CSharp
{
    public partial class Form_LoginScreen : Form
    {
        public Form_LoginScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_LoginScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text == "JuanDelacruz" && textBox_Password.Text == "1234")
            {
                this.Hide();
                frmDriver ss = new frmDriver();
                ss.Show();
            }
           else if (textBox_Username.Text == "Custer" && textBox_Password.Text == "1234")
            {
                this.Hide();
                frm_parent ss = new frm_parent();
                ss.Show();
            }
            else if (textBox_Username.Text == "Ryan" && textBox_Password.Text == "1234")
            {
                this.Hide();
                frm_student ss = new frm_student();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

        }

        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked == true)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            if (checkBox_Password.Checked == false)
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Username_Click(object sender, EventArgs e)
        {
            textBox_Username.Text = "";
            if (textBox_Password.Text=="")
            {
                textBox_Password.Text = "Password";
            }
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            textBox_Password.Text = "";
            if (textBox_Username.Text == "")
            {
                textBox_Username.Text = "Username";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreation ss = new frmCreation();
            ss.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
