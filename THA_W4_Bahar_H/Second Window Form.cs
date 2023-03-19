using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_Bahar_H
{
    public partial class Second_Window_Form : Form
    {
        public Second_Window_Form()
        {
            InitializeComponent();
            
            if (cbAgree.Checked == true && cbAllChoice.Checked == true)
            {
                btnMagic.Enabled = true;
            }
            else
            {
                btnMagic.Enabled = false;
            }
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            MainWindowForm frm = (MainWindowForm)this.Owner;
          //  frm.BackColor = Color.Red;
            if (rbRed.Checked)
            {
                frm.BackColor = Color.Red;
            }
            else if (rbGreen.Checked)
            {
                frm.BackColor = Color.Green;
            }
            else if (rbBlue.Checked)
            {
                frm.BackColor= Color.Blue;
            }
            else if (rbYellow.Checked)
            {
                frm.BackColor = Color.Yellow;
            }
            else if (rbPurple.Checked)
            {
                frm.BackColor = Color.Purple;
            }
            else
            {
                MessageBox.Show("Pilih Radio Button color lebih Dahulu");
            }

            if (rbBrown.Checked)
            {
                frm.ForeColor = Color.Brown;
            }
            else if(rbGray.Checked)
            {
                frm.ForeColor= Color.Gray;
            }
            else if (rbOrange.Checked)
            {
                frm.ForeColor = Color.Orange;
            }
            else
            {
                MessageBox.Show("Pilih Radio Button Text lebih Dahulu");
            }
        }

        private void Second_Window_Form_Load(object sender, EventArgs e)
        {
            string nama;
            string artist;
            nama = MainWindowForm.setValueForName;
            artist = MainWindowForm.setValueForArtist;

            lblMyName.Text = "Hi, my name is " + nama + " and my favorite artist is " + artist;

           
        }

        private void lblMyName_Click(object sender, EventArgs e)
        {
         
        }

        private void cbAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgree.Checked && cbAllChoice.Checked)
            {
                btnMagic.Enabled = true;
            }
            else
            {
                btnMagic.Enabled = false;
            }
        }

        private void cbAllChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgree.Checked && cbAllChoice.Checked)
            {
                btnMagic.Enabled = true;
            }
            else
            {
                btnMagic.Enabled = false;
            }
        }
    }
}
