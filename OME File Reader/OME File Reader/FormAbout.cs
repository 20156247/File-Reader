using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OME_File_Reader
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void abtOkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            abtLabel1.Text = string.Format("Company: {0}", Application.CompanyName);
            abtLabel2.Text = string.Format("Product: {0}", Application.ProductName);
            abtLabel3.Text = "By OME Programers";
            abtLabel4.Text = string.Format("Version: {0}", Application.ProductVersion);
            abtLabel5.Text = "Copyright ©  2018";
        }
    }
}
