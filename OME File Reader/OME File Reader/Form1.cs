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
        //string for current open file name
        string cof = "Current Open File: ";
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        //menu strips
        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set string as a filed to hold our current path
            string path;
            path = string.Empty;
            richTextBox.Clear();
            ////fileNameLabel displays the name of current opened file
            fileNameLabel.Text = cof + "Untitled";
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //declaring an object to open file dialog
            OpenFileDialog ofdlg = new OpenFileDialog();

            //The file filter allows us to only open specific file types, in this case text files only
            ofdlg.Filter = "Text files (*.txt)|*.txt";

            //condition that chaecks if the dialog has been opened
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                //Making use of exceptions to protect the disk should the codes have errors
                try
                {
                    //to enable program to read the text from file
                    //gave any name to stream reader object as long as its not reserved
                    StreamReader readFile = new StreamReader(File.OpenRead(ofdlg.FileName));

                    //fileNameLabel displays the name of current opened file
                    fileNameLabel.Text = cof + Path.GetFileName(ofdlg.FileName);

                    //enable the rich text box to display content in selected opened text file
                    richTextBox.Text = readFile.ReadToEnd();
                    //closes the StreamReader method to prevent error
                    //when user attempts to click the open button more than once
                    readFile.Dispose();
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error in Reading from disk, please check code: " + error.Message);

                }
            }
        }



        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            //The first code could not work without focusing on the text by clicking inside the text box
            richTextBox.Focus();

        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fonts = new FontDialog();
            //fonts.ShowDialog();

            if (fonts.ShowDialog() == DialogResult.OK)
            {
                string fontName;
                double fontSize;
                fontName = fonts.Font.Name;
                fontSize = fonts.Font.Size;
                richTextBox.Font = fonts.Font;
                MessageBox.Show(fontName + " with size " + fontSize + " has been selected", "Font Selection Succes");

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAbout frmAbt = new FormAbout())
            {
                frmAbt.ShowDialog();
            }
        }

        //Number of words Label
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            //string message that goes with the total
            string msg = "Number of words: ";
            //setting the variable for words and trimming off the spaces
            string text = richTextBox.Text.Trim();
            //display the total of words to label
            numOfWordsLabel.Text = msg + counter(text);

        }

        //The method that will count the words using an array
        private int counter(string text)
        {
            //create an array and split the characters to not count any spaces
            string[] totalText = text.Split(' ');
            return totalText.Length;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a file object for the savefile dialog
            SaveFileDialog saveFile = new SaveFileDialog();

            //The file filter allows us to only open specific file types, in this case text files only
            saveFile.Filter = "Text files (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //set path to a new variable of whatever file the user chooses
                path = saveFile.FileName;

                //Making use of exceptions to protect the disk should the codes have errors
                try
                {
                    //enables the user to write the desired file name to be saved
                    StreamWriter createFile = new StreamWriter(path);
                    //to save whatever is written in the rich text box
                    createFile.Write(richTextBox.Text);

                    //fileNameLabel
                    fileNameLabel.Text = cof + Path.GetFileName(path);

                    //closes the stream writer to get rid of an error when user attempts to click
                    //the create button more than once
                    createFile.Dispose();
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error in saving to disk, please check code: " + error.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        
        //Buttons
        //create new blank page
        private void createNewBtn_Click(object sender, EventArgs e)
        {
            //set string as a filed to hold our current path
            string path;
            path = string.Empty;
            richTextBox.Clear();
            ////fileNameLabel displays the name of current opened file
            fileNameLabel.Text = cof + "Untitled";

        }

        //To open and display text file in rich textbox
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            //declaring an object to open file dialog
            OpenFileDialog ofdlg = new OpenFileDialog();

            //The file filter allows us to only open specific file types, in this case text files only
            ofdlg.Filter = "Text files (*.txt)|*.txt";

            //condition that chaecks if the dialog has been opened
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                //Making use of exceptions to protect the disk should the codes have errors
                try
                {
                    //to enable program to read the text from file
                    //gave any name to stream reader object as long as its not reserved
                    StreamReader readFile = new StreamReader(File.OpenRead(ofdlg.FileName));

                    //fileNameLabel displays the name of current opened file
                    fileNameLabel.Text = cof + Path.GetFileName(ofdlg.FileName);

                    //enable the rich text box to display content in selected opened text file
                    richTextBox.Text = readFile.ReadToEnd();
                    //closes the StreamReader method to prevent error
                    //when user attempts to click the open button more than once
                    readFile.Dispose();
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error in Reading from disk, please check code: " + error.Message);

                }
            }

        }

        //save button
        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        //save as button
        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            //creates a file object for the savefile dialog
            SaveFileDialog saveFile = new SaveFileDialog();

            //The file filter allows us to only open specific file types, in this case text files only
            saveFile.Filter = "Text files (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //set path to a new variable of whatever file the user chooses
                path = saveFile.FileName;

                //Making use of exceptions to protect the disk should the codes have errors
                try
                {
                    //enables the user to write the desired file name to be saved
                    StreamWriter createFile = new StreamWriter(path);
                    //to save whatever is written in the rich text box
                    createFile.Write(richTextBox.Text);

                    //fileNameLabel
                    fileNameLabel.Text = cof + Path.GetFileName(path);

                    //closes the stream writer to get rid of an error when user attempts to click
                    //the create button more than once
                    createFile.Dispose();
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error in saving to disk, please check code: " + error.Message);
                }
            }
        }

        //print Button
        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        //clear all text
        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }


        //right click button tool strip
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            //The first code could not work without focusing on the text by clicking inside the text box
            richTextBox.Focus();

        }

        private void clearAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = string.Empty;
        }


    }
}
