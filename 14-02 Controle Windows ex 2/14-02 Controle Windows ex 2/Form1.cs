using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_02_Controle_Windows_ex_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
            
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("En construction", "NotifyIcon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.ImageLocation = Application.StartupPath + "\\drapeaux\\belgique.bmp";
                pictureBox6.ImageLocation = Application.StartupPath + "\\drapeaux\\france.bmp";
                pictureBox1.Show();
                pictureBox6.Show();

                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox2.Hide();


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.ImageLocation = Application.StartupPath + "\\drapeaux\\belgique.bmp";
                pictureBox6.ImageLocation = Application.StartupPath + "\\drapeaux\\france.bmp";
                pictureBox2.ImageLocation = Application.StartupPath + "\\drapeaux\\belgique.bmp";
                pictureBox5.ImageLocation = Application.StartupPath + "\\drapeaux\\france.bmp";
                pictureBox1.Show();
                pictureBox6.Show();
                pictureBox2.Show();
                pictureBox5.Show();


                pictureBox4.Hide();
                pictureBox3.Hide();
            }  
            
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\drapeaux\\belgique.bmp";
            pictureBox6.ImageLocation = Application.StartupPath + "\\drapeaux\\france.bmp";
            pictureBox2.ImageLocation = Application.StartupPath + "\\drapeaux\\belgique.bmp";
            pictureBox5.ImageLocation = Application.StartupPath + "\\drapeaux\\france.bmp";
            pictureBox3.ImageLocation = Application.StartupPath + "\\drapeaux\\belgique.bmp";
            pictureBox4.ImageLocation = Application.StartupPath + "\\drapeaux\\france.bmp";
            pictureBox1.Show();
            pictureBox4.Show();
            pictureBox2.Show();
            pictureBox5.Show();
            pictureBox3.Show();
            pictureBox6.Show();
        }
    }
}
