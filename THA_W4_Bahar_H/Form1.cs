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
    
    public partial class MainWindowForm : Form
    {
        public static string setValueForName = "";
        public static string setValueForArtist = "";
        public static string namaButtonSubmit = "";
        public static string labelNama = "";
        public static string labelArtis = "";
        public static string labelCekBox = "";
        public static string namaButtonOpen = "";



        public MainWindowForm()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            setValueForName = txtboxName.Text;
            setValueForArtist = txtboxFavorite.Text;
            namaButtonSubmit = btnSubmit.Text;
            labelNama = lblName.Text;
            labelArtis = lblMyFavorite.Text;
            labelCekBox = cbKonfirmasi.Text;
              
        //     Second_Window_Form formbaruu = new Second_Window_Form();
    }

        private void cbKonfirmasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKonfirmasi.Checked == true)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void btnOpenNextForm_Click(object sender, EventArgs e)
        {
            Second_Window_Form formbaru = new Second_Window_Form();
            formbaru.ShowDialog(this);
           // formbaru.Show();
        }
    }
}
