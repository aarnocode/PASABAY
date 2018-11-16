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
    public partial class frm_student : Form
    {
        public frm_student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_DriverPop.Hide();
            pictureBox_Searching.Hide();
            label_Searching.Hide();
            panel_DriverInfo.Visible = false;
            label_DriverInfo.Visible = false;
            panel_DropOff.Visible = false;
            pictureBox_QRScan.Visible = false;
            label_Payment.Visible = false;
            panel_DropOff2.Visible = false;
            panel_CarDetails.Visible = false;
            panel_SearchingForDriver.Visible = false;
            panel_paymentlabel.Visible = false;
            panel_DriverPop.Visible = false;
            panel1.Visible = true;
            this.Refresh();
        }
        int tick;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToShortTimeString();
           
        }

        private void frm_student_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel_DriverPop.Hide();
            pictureBox_Searching.Hide();
            label_Searching.Hide();
            panel_DriverInfo.Visible = false;
            label_DriverInfo.Visible = false;
            panel_DropOff.Visible = false;
            pictureBox_QRScan.Visible = false;
            label_Payment.Visible = false;
            panel_DropOff2.Visible = false;
            panel_CarDetails.Visible = false;
            panel_SearchingForDriver.Visible = false;
            panel_paymentlabel.Visible = false;
            
        }

        private void btn_WaitPickUp_Click(object sender, EventArgs e)
        {
            pictureBox_Searching.Show();
            panel_SearchingForDriver.Visible = true;
            label_Searching.Show();
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            tick++;
            
            if (tick >= 10)
            {
                panel_DriverPop.Visible = true;
                pictureBox_Searching.Visible = false;
                label_Searching.Visible = false;
                tick = 0;
                timer2.Stop();
            }
            
        }
        
        private void btn_Babay_Click(object sender, EventArgs e)
        {
            
            panel_DriverPop.Hide();
            pictureBox_Searching.Visible = true;
            label_Searching.Visible = true;
            panel_CarDetails.Visible = false;
            timer2.Start();
            tick = 0;
            tick++;
            if (tick == 10)
            {
                panel_DriverPop.Visible = true;
                pictureBox_Searching.Visible = false;
                label_Searching.Visible = false;
                timer2.Stop();
                tick = 0;

                
            }
        }

        private void btn_Pasabay_Click(object sender, EventArgs e)
        {
            
            panel_DriverPop.Visible = false;
            panel_DriverInfo.Visible = true;
            label_DriverInfo.Visible = true;
            panel_DropOff.Visible = true;
            panel_CarDetails.Visible = false;
            panel_SearchingForDriver.Visible = false;

        }

        private void panel_DriverInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_DropOff_Click(object sender, EventArgs e)
        {
            pictureBox_QRScan.Visible = true;
            label_Payment.Visible = true;
            label_DriverInfo.Visible = false;
            panel_DriverInfo.Visible = false;
            panel_DropOff2.Visible = true;
            panel1.Visible = false;
            panel_paymentlabel.Visible = true;
            label_Payment.BringToFront();
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel_CarDetails.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
