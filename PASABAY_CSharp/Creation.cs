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
    public partial class frmCreation : Form
    {
        public frmCreation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToShortTimeString();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LoginScreen ss = new Form_LoginScreen();
            ss.Show();
        }
    }
}
