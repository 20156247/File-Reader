using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OME_File_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            Stream file1;


            OpenFileDialog dlg = new OpenFileDialog();

            if(dlg.ShowDialog()==DialogResult.OK)
            {
                if((file1=dlg.OpenFile()) !=null)
                {
                    string filePathName;
                    filePathName = dlg.FileName;


                    string filetext = File.ReadAllText(filePathName);

                    richTextBox1.Text = filetext;
                }

            }
    



       
        }
    }
}
