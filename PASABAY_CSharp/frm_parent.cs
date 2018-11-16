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
    public partial class frm_parent : Form
    {
        public frm_parent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LoginScreen ss = new Form_LoginScreen();
            ss.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToShortTimeString();
        }

        private void frm_parent_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
