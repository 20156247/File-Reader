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
        public string cof = "Current Open File: ";
        public string path;

        public Form1()
        {
            InitializeComponent();

            //Upon start up, the current oponed file will read as untitled.
            fileNameLabel.Text = cof + "Untitled";
        }

        //////////// Menu strips //////////////

        //1.File
        
        //Create New
        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a whole new page
            richTextBox.Clear();

            //Set path to empty to enable me to save it as a brand new file
            path = string.Empty;

            //fileNameLabel displays the name of current opened file
            fileNameLabel.Text = cof + "Untitled";
        }

        //Open File
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //declaring an object to open file dialog
            OpenFileDialog ofdlg = new OpenFileDialog();

            //The file filter allows us to only open specific file types, in this case text files only
            ofdlg.Filter = "Text files (*.txt)|*.txt";

            //condition that chaecks if the dialog has been opened
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                path = ofdlg.FileName;

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

        //Save
        //Saves the modification of current open file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string editFile = richTextBox.Text;
                File.Delete(path);
                File.AppendAllText(path, editFile);
                
            }
            if (!File.Exists(path))
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
        }

        //Save as 
        //Saves the file as a new file if it does not exist
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

        //Print
        //To print the file
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        //Exit
        //To exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ask user if they're sure that they want to close application
            DialogResult close = MessageBox.Show("Are you sure you really want to Exit the application?","Close Application?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
 
        }

        ///----------------------------------------------------------------------------------///

        //2.Edit

        //Cut
        //Cuts the text from current location
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        //Copy
        //Copies the text from current location
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        //Paste
        //Past the text to current location
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        //Undo
        //Undo the modification just made
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        //Redo
        //Redo the modification just made
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        //Select All
        //Selects all the text in the rich text box
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            //The first code could not work without focusing on the text by clicking inside the text box
            richTextBox.Focus();
        }

        //Clear All
        //Clears all text from the rich text box
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        ///--------------------------------------------------------------------------------------///

        //3.Format

        //Font style
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

        //Font color
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colour = new ColorDialog();
            colour.ShowDialog();
            richTextBox.SelectionColor = colour.Color;
        }

        ///------------------------------------------------------------------------------------///

        //4.About

        //Information about the application such as the version and copy right
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAbout frmAbt = new FormAbout())
            {
                frmAbt.ShowDialog();
            }
        }

        ////--------------------------------------------------------------------------------------///

        //5. Search Button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = richTextBox.Text;
            richTextBox.Text = "";
            richTextBox.Text = temp;

            while (index < richTextBox.Text.LastIndexOf(searchTxtBox.Text))
            {
                //Searches the text in a RichTextBox control for a string within a range of texts.
                richTextBox.Find(searchTxtBox.Text, index, richTextBox.TextLength, RichTextBoxFinds.None);
                //Colour Selection.This is added automatically when a match is found.
                richTextBox.SelectionBackColor = Color.Yellow;
                //After a match is found the index is increased so the search won't stop at the same match again.i.e it will search for similiar match.
                index = richTextBox.Text.IndexOf(searchTxtBox.Text, index) + 1;
               
            }
        }

        ////--------------------------------------------------------------------------------------///

        //6.Number of words label

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

        //---------------------------------------------------------------------------------------------//

        ////////// Buttons /////////

        //1.Create New button
        //create new blank page
        private void createNewBtn_Click(object sender, EventArgs e)
        {
            //creates a whole new page
            richTextBox.Clear();

            //fileNameLabel displays the name of current opened file
            fileNameLabel.Text = cof + "Untitled";
        }

        //2.Open File button
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
                path = ofdlg.FileName;

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

        //3.Save button
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string editFile = richTextBox.Text;
                File.Delete(path);
                File.AppendAllText(path, editFile);

            }

            if (!File.Exists(path))
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
        }

        //4.Save as button
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

        //5.Print Button
        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        //6.Clear All Text button
        private void clearAllBtn_Click(object sender, EventArgs e)
        {
           richTextBox.Clear();
        }

        //-----------------------------------------------------------------------------------------//

        /////////////////Right click button tool strip///////////////

        //Cut
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        
        //Copy
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        //Paste
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        //Undo
        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        //Redo
        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Redo(); 
        }

        //Select All
        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            //The first code could not work without focusing on the text by clicking inside the text box
            richTextBox.Focus();
        }

        //Clear All
        private void clearAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        //Delete
        //Delete selected text
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = string.Empty;
        }

       private void searchTxtBox_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = richTextBox.Text;
            richTextBox.Text = "";
            richTextBox.Text = temp;

            while (index < richTextBox.Text.LastIndexOf(searchTxtBox.Text))
            {
                //Searches the text in a RichTextBox control for a string within a range of texts.
                richTextBox.Find(searchTxtBox.Text, index, richTextBox.TextLength, RichTextBoxFinds.None);
                //Colour Selection.This is added automatically when a match is found.
                richTextBox.SelectionBackColor = Color.Yellow;
                //After a match is found the index is increased so the search won't stop at the same match again.i.e it will search for similiar match.
                index = richTextBox.Text.IndexOf(searchTxtBox.Text, index) + 1;
               
            }
        }

    }
}
