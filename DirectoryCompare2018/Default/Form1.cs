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

namespace Default
{
    public partial class Form1 : Form
    {
        String dirPrimary;
        String dirCompare;
        int fileCount = 0;
        Boolean itemsFound;
        String vbCrFL = "\r\n";
        
        public Form1()
        {
            InitializeComponent();
        }

    

        private string  DirectoryNotice(string altDirectory, string folderName)
         {
         string returnString;

            // Assemble text for addition to output box.
            returnString = "Directory missing: " + vbCrFL;
            returnString += altDirectory + " does not exist." + vbCrFL;
            returnString += "This folder would correspond to the existing folder" + vbCrFL;
            returnString += folderName + vbCrFL + "found within the primary directory." + vbCrFL + vbCrFL;

            return returnString;
         }

        private string FileNotice(string fileNameOnly, string directoryPath, string altDirectory)
        {
            string returnString;

            //Assemble text for addition to output box
            returnString = "File Missing: " + vbCrFL;
            returnString += fileNameOnly + vbCrFL;
            returnString += "Exists in " + directoryPath + vbCrFL;
            returnString += "Does not exist in " + altDirectory + vbCrFL + vbCrFL;

            return returnString;
        }

        private void FolderSearch(object sender, EventArgs e)
        {
            // Show folder dialog so the user can select a directory

             Button btnPress = (sender as Button);
             FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

             try
             {
                  // Set description on folder dialog based on which field is being completed
                  if (btnPress.Name == "btnPrimaryDir")
                     {
                        folderBrowser.Description = "Select a folder and click OK to use it as the primary directory";
                     }
                 else
                     {
                      folderBrowser.Description = "Select a folder and click OK to use it as the Comparison Directory";
                        }
            if(folderBrowser.ShowDialog()== DialogResult.OK)
                {
                   if(btnPress.Name == "btnPrimaryDir")
                    {
                       textBox1.Text = folderBrowser.SelectedPath;
                    }
                    else
                     {
                     textBox2.Text = folderBrowser.SelectedPath;
                      }
                  }
           }    
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
      }

        private bool ValidateInputs()
        {
            // Validate Directory Inputs
            try
            {
                bool directory1Pass = false;
                bool directory2Pass = false;
                bool returnValue = false;

                //Check for missing directory entries and directories that dont exist

                //Primary Directory
                // If no directory was picked
                if (textBox1.Text.Length == 0)
                {
                    // Display error inside textbox1
                    errorProvider.SetError(textBox1, "Please enter a directory.");
                }
                // If the directory doesnt exist
                else if (!Directory.Exists(textBox1.Text))
                {
                    // If the directory doesnt exist
                    errorProvider.SetError(textBox1, "This directory does not exist. Please try again.");
                }
                else
                {
                    // Clears the textbox and gives directory 1 the pass
                    errorProvider.SetError(textBox1, "");
                    directory1Pass = true;
                }

                // Second Directory
                // if there is nothing in the text box
                if(textBox2.Text.Length == 0)
                {
                    errorProvider.SetError(textBox2, "Please enter a directory.");
                }
                // If the directory doesnt exist
                else if (!Directory.Exists(textBox2.Text))
                {
                    errorProvider.SetError(textBox2, "This directory does not exist. Please try again.");
                }
                else
                {
                    //clears the text box, and gives the directory the pass
                    errorProvider.SetError(textBox2, "");
                    directory2Pass = true;
                }

                // If both fields are not blank and exist, then return true
                if (directory1Pass && directory2Pass)
                {
                    returnValue = true;
                }

                // Return True
                return returnValue;

            }
            catch(Exception ex) // IF either directories do not pass
            {
                throw new ApplicationException("Error while verifying the directories.", ex);
            }
        }

        private void CompareDirectories(string DirectoryPath)
        {
            int nbrFiles = Directory.GetFiles(DirectoryPath).Count();
            int nbrFolders = Directory.GetDirectories(DirectoryPath).Count();
            string comparisonFile;
            string fileNameOnly, altDirectory;

            try
            {
                if (nbrFiles > 0)
                {
                    foreach (string fileName in Directory.GetFiles(DirectoryPath))
                    {
                        // Increment the file count
                        fileCount += 1;
                        // Determine the filepath / name of corresponding file ...
                        comparisonFile = dirCompare + fileName.Substring(dirPrimary.Length);
                        if(!System.IO.File.Exists(comparisonFile))
                        {
                            fileNameOnly = Path.GetFileName(fileName);
                            altDirectory = comparisonFile.Substring(0, comparisonFile.Length - fileNameOnly.Length);
                            rtbOutPut.Text += FileNotice(fileNameOnly, DirectoryPath, altDirectory);
                            itemsFound = true;
                        }
                    }
                }

                if (nbrFolders > 0)
                {
                    foreach (string folderName in Directory.GetDirectories(DirectoryPath))
                    {
                        toolStripStatusLabel2.Text = "Reading " + folderName;
                        altDirectory = dirCompare + folderName.Substring(dirPrimary.Length);
                        // Use Recursion to check subdirectories if they exist.
                        if (Directory.Exists(altDirectory))
                        {
                            CompareDirectories(folderName);
                        }
                        else
                        {
                            //If the corresponding directory doesnt exist. add all necessary information to the results
                            rtbOutPut.Text += DirectoryNotice(altDirectory, folderName);
                            itemsFound = true;
                        }
                        Application.DoEvents();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbOutPut.Text = "";
            itemsFound = false;

            try
            {
                if(ValidateInputs())
                {
                    // Validate the  directories before moving forward
                    dirPrimary = textBox1.Text;
                    dirCompare = textBox2.Text;

                    //Reset the file count
                    // Reset rtbOutput Colors
                    rtbOutPut.BackColor = Color.FromName("Control");
                    rtbOutPut.ForeColor = Color.Black;
                    fileCount = 0;
                    statusStrip1.Text = "Comparing primary directory to secondary.";
                    dirPrimary = textBox2.Text;
                    dirCompare = textBox1.Text;
                    CompareDirectories(dirPrimary);
                    // After comparison is finished, report
                    toolStripStatusLabel1.Text = fileCount.ToString() + " files tested.";
                    if (!itemsFound && rtbOutPut.Text.Length == 0)
                    {
                        rtbOutPut.Text += "All files match!";
                        rtbOutPut.BackColor = Color.Green;
                        rtbOutPut.ForeColor = Color.White;
                        toolStripStatusLabel2.Text = "All files and folders match.";
                    }
                    else
                    {
                        rtbOutPut.Text += "Files / Folders missing!";
                        rtbOutPut.BackColor = Color.Red;
                        rtbOutPut.ForeColor = Color.White;
                        toolStripStatusLabel2.Text = "File / Folder mismatch.";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the output field and status bar
            rtbOutPut.Text = "";
            rtbOutPut.BackColor = Color.FromName("Control");
            rtbOutPut.ForeColor = Color.Black;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
        }
    }
}
