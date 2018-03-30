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


        //To open and display text file in rich textbox
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            //declaring an object to open file dialog
            OpenFileDialog ofdlg = new OpenFileDialog();

            //condition that chaecks if the dialog has been opened
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                //to enable program to read the text from file
                //gave any name to stream reader object as long as its not reserved
                StreamReader readFile = new StreamReader(FileDialog.OpenRead(ofdlg.FileName));

                //enable the rich text box to display content in selected opened text file
                richTextBox.Text = readFile.ReadToEnd();
                //closes the StreamReader method to prevent error
                //when user attempts to click the open button more than once
                readFile.Dispose();
            }

        }

        //To read text file content in rich textbox via message box 
        private void readBtn_Click(object sender, EventArgs e)
        {
            string readText;
            readText = richTextBox.Text;
            MessageBox.Show(readText, "Loaded Text Being Read", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
