using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_02_Controle_Windows_ex_1
{
    public partial class Form1 : Form
    {
        List<string> data = new List<string>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void bConvInverse_Click(object sender, EventArgs e)
        {
            mtbLitre.Text = (float.Parse(mtbm3.Text) * 1000).ToString();
        }

        private void bConv_Click(object sender, EventArgs e)
        {
            if (mtbLitre.TextLength >= 4 && mtbLitre.TextLength <= 7)
            {
                mtbm3.Text = (float.Parse(mtbLitre.Text) / 1000).ToString();
            }
            toolTip1.ShowAlways = true;
            toolTip1.Active = true;
            toolTip1.SetToolTip(mtbLitre, "Doit etre compris entre 4 et 7 carateres maximum.");//= "Doit etre compris entre 4 et 7 carateres maximum.";

        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            data.Add("Litre: " + mtbLitre.Text.ToString() + "\n");
            data.Add("m³: " + mtbm3.Text.ToString() + "\n");
            bSave.Enabled = true;
            rtb.AppendText("Litre: " + mtbLitre.Text.ToString() + "\n" + "m³: " + mtbm3.Text.ToString() + "\n");
            
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            rtb.LoadFile(, RichTextBoxStreamType.RichText);
        }
    }
}
