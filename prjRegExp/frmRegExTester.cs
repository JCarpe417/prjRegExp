using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace prjRegExp
{
    /*=====================================================================
     | Creator: James Carpenter (jcarpe417@gmail.com)                      |
     | Project: Regular Expression Tester across a few different mediums   |
      =====================================================================*/

    public partial class frmRegExTester : Form
    {
        public frmRegExTester()
        {
            InitializeComponent();
        }

        //little function to check txtRegEx.Text's value; 
        //note: will only fire off messagebox if first check is true
        private bool checkExp() 
        {
            if (this.txtRegEx.Text == "")
            {
                MessageBox.Show("Please enter a valid value in the textbox labeled 'RegEx to Test'", "Error");
                return false;
            }
            else return true; 
        }

        private void btnTest_MouseDown(object sender, MouseEventArgs e)
        {
            //show test menu at mouses point(e.X,e.Y) relative to the test button
            this.mnuTest.Show(this.btnTest, e.X, e.Y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear everything user has entered and results from regexes
            this.txtText.Clear();
            this.txtBlock.Clear();
            this.txtRegEx.Clear();
            this.lstResults.Items.Clear();
            this.lblMatches.Text = "(0)";
            this.txtText.Focus();
        }

        private void mnuSingle_Click(object sender, EventArgs e)
        {
            //if txtText.Text is empty or txtRegEx.Text is empty, do this...
            if (this.txtText.Text == "" || this.checkExp()) 
            {
                MessageBox.Show("Please enter a valid value in the textbox labeled 'Text to Test'", "Error");
                return;
            }

            //str: string used to test with the regex
            //regEx: string representation of a regex pattern
            string str = this.txtText.Text;
            string regEx = this.txtRegEx.Text;

            //matches: collection of matches generated from the regex test
            MatchCollection matches = new Regex(regEx).Matches(str);

            //no matches turned up, do this...
            if (matches.Count < 1)
            {
                //inform the user, then exit procedure
                MessageBox.Show("No matches came from the expression: " + regEx, "Error");
                return;
            }

            //for every match in the collection, do this...
            foreach (Match m in matches)
            {
                //add the value to the results listbox
                this.lstResults.Items.Add(m.Value);
            }

            //update result count
            this.lblMatches.Text = "(" + this.lstResults.Items.Count.ToString() + ")";
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {
            //if txtRegEx.Text is empty, do this...
            if (this.checkExp()) 
            {
                return; 
            }

            //create new file select dialog object to select a file
            OpenFileDialog ofd = new OpenFileDialog();

            //user chose a file and selected Open (OK)
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //regex: regex pattern to use for testing
                //sr: streamreader object set to file chosen by user
                Regex regex = new Regex(this.txtRegEx.Text);
                StreamReader sr = new StreamReader(ofd.FileName);

                //until EOF is reached, do this...
                while (sr.Peek() != -1)
                {
                    //matches: collection of matches generated from the regex test
                    MatchCollection matches = regex.Matches(sr.ReadLine());

                    //for each match in the collection, do this...
                    foreach (Match m in matches)
                    {
                        //add the value to the results listbox
                        this.lstResults.Items.Add(m.Value);
                    }
                }

                //update result count
                this.lblMatches.Text = "(" + this.lstResults.Items.Count.ToString() + ")";
                //properly release streamreader object
                sr.Close();
            }
        }

        private void mnuBlock_Click(object sender, EventArgs e)
        {
            //if txtBlock.Text is empty or txtRegEx.Text is empty, do this...
            if (this.txtBlock.Text == "" || this.checkExp())
            {
                MessageBox.Show("Please enter a valid value in the textbox labeled 'Block to Test'", "Error");
                return;
            }

            //regex: regex pattern to use for testing
            Regex regex = new Regex(this.txtRegEx.Text);

            //for each line in txtBlock.Lines collection, do this...
            foreach (string line in this.txtBlock.Lines)
            {
                //matches: collection of matches generated from the regex test
                MatchCollection matches = regex.Matches(line);

                //for each match in the collection, do this...
                foreach (Match m in matches)
                {
                    //add the value to the results listbox
                    this.lstResults.Items.Add(m.Value);
                }
            }

            //update result count
            this.lblMatches.Text = this.lstResults.Items.Count.ToString();
        }

        //TODO: This may need adjusting in the future
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //create new file select dialog and set filter property for .txt and .csv files
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|Comma Seperated Value (CSV) Files|*.csv";

            //user chose a file and clicked open
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //sr: streamreader object set to file chosen by the user
                StreamReader sr = new StreamReader(ofd.FileName);

                //which file type was selected?
                switch (ofd.FilterIndex)
                { 
                    //text file selected
                    case 1:
                        //until EOF is reached, do this...
                        while (sr.Peek() != -1)
                        {
                            //read sr line by line and update txtBlock.Text accordingly (subsequently appending values to txtBlock.Lines array)
                            this.txtBlock.Text += sr.ReadLine() + Environment.NewLine;
                        }

                        //properly release streamreader object
                        sr.Close();
                        break;
                    
                    //csv file selected
                    case 2:
                        //until EOF is reached, do this...
                        while (sr.Peek() != -1)
                        {
                            //split lines into strings seperated by commas
                            string[] strs = sr.ReadLine().Split(',');

                            //for each string in the array, do this...
                            foreach (string s in strs)
                            {
                                //update txtBlock.Text accordingly (subsequently appending values to txtBlock.Lines array)
                                this.txtBlock.Text += s + Environment.NewLine;
                            }
                        }

                        //properly release streamreader object
                        sr.Close();
                        break;
                }
            }
        }
    }
}
