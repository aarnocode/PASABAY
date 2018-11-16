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
    public partial class Form_StudentDriverPop : Form
    {
        public Form_StudentDriverPop()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CarDetails ss = new CarDetails();
            ss.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            CarDetails ss = new CarDetails();
            ss.Show();
            ss.BringToFront();

            
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            CarDetails ss = new CarDetails();
            ss.Hide();
        }
    }
}
