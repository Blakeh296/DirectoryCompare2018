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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get a list of all drivers
            string[] drivers = Environment.GetLogicalDrives();

            foreach (string drive in drivers)
            {
                DriveInfo di = new DriveInfo(drive);

                TreeNode node = new TreeNode(drive.Substring(0, 1));
                node.Tag = drive;

                if (di.IsReady == true)
                {
                    node.Nodes.Add("...");
                }

                tvFilesView.Nodes.Add(node);
            }

            rbPrimaryDir.Checked = true;
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
            //Get the number of files and subdirectories under this path
            int nbrFiles = Directory.GetFiles(DirectoryPath).Count();
            int nbrFolders = Directory.GetDirectories(DirectoryPath).Count();
            //Get the corresponding directory
            string correspondPath = dirCompare + DirectoryPath.Substring(dirPrimary.Length);
            string comparisonFile, fileNameOnly;

            try
            {
                // Add the directories to the TreeView if they're not already there
                AddDirectorytoTreeView(DirectoryPath);
                AddDirectorytoTreeView(correspondPath);
            if (Directory.Exists(correspondPath))
                {
                    if (nbrFiles > 0)
                    {
                        foreach (string fileName in Directory.GetFiles(DirectoryPath))
                        {
                            // Increment the file count
                            fileCount += 1;
                            // Determine the filepath / name of corresponding file ...
                            fileNameOnly = Path.GetFileName(fileName);
                            comparisonFile = dirCompare + fileName.Substring(dirPrimary.Length);
                            if (!System.IO.File.Exists(comparisonFile))
                            {
                                dGVoutPut.Rows.Add(FileNotice(fileNameOnly, DirectoryPath, correspondPath));
                                UpdateTreeViewStatus(correspondPath, Color.Orange, "Missing files");
                                itemsFound = true;
                            }
                        }
                    }

                    if (nbrFolders > 0)
                    {
                        foreach (string folderName in Directory.GetDirectories(DirectoryPath))
                        {
                            toolStripStatusLabel2.Text = "Reading " + folderName;
                            // Use Recursion to check subdirectories if they exist.
                            if (Directory.Exists(correspondPath))
                            {
                                CompareDirectories(folderName);
                            }
                            else
                            {
                                //If the corresponding directory doesnt exist. add all necessary information to the results
                                dGVoutPut.Rows.Add(DirectoryNotice(correspondPath, folderName));
                                UpdateTreeViewStatus(folderName, Color.Red, "Missing Corresponding Folder");
                                itemsFound = true;
                            }
                            Application.DoEvents();
                        }
                    }
                }
            else
                {
                    //If the corresponding path doesn't exist, just record the one entry
                    dGVoutPut.Rows.Add(DirectoryNotice(correspondPath, DirectoryPath));
                    UpdateTreeViewStatus(correspondPath, Color.Red, "Missing Folder");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddDirectorytoTreeView(string DirectoryPath)
        {
            // Add a specific directory pertaining to the two directories picked
            DirectoryInfo currentDirectory = new DirectoryInfo(DirectoryPath);
            string parentPath = "";

            try
            {
                // Get the parent directory if needed
                if (DirectoryPath.Contains("\\"))
                    parentPath = DirectoryPath.Substring(0, DirectoryPath.LastIndexOf("\\"));

                TreeNode[] findNode = tvFilesView.Nodes.Find(DirectoryPath, true);
                TreeNode[] parentNodeFind = tvFilesView.Nodes.Find(parentPath, true);

                //Look for the directory and its parent to place it in the TreeView
                //If its already there do nothing

                if (findNode.Length == 0)
                {
                    if (parentNodeFind.Length > 0)
                    {
                        //If the parent has been found, insert the new Directory
                        parentNodeFind[0].Nodes.Add(DirectoryPath, currentDirectory.Name);
                    }
                    else
                    {
                        //otherwise, add it as a new top level
                        tvFilesView.Nodes.Add(DirectoryPath, currentDirectory.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateTreeViewStatus(string DirectoryPath, Color colorCode, string ToolTipMessage)
        {
            TreeNode[] nodeFind = tvFilesView.Nodes.Find(DirectoryPath, true);
            TreeNode foundNode;

            try
            {
                // Change the appearance of the specified tree node.
                if (nodeFind.Length > 0)
                {
                    foundNode = nodeFind[0];
                    foundNode.BackColor = colorCode;
                    foundNode.ForeColor = Color.White;
                    foundNode.ToolTipText = ToolTipMessage;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Compare the two directories to each other and report on the findings

            itemsFound = false;

            try
            {
                //Reset the display.
                InitializeGridColumns();
                dGVoutPut.Rows.Clear();
                tvFilesView.Nodes.Clear();
                tbOutPut.Text = "";

                if(ValidateInputs())
                {
                    // Validate the  directories before moving forward
                    dirPrimary = textBox1.Text;
                    dirCompare = textBox2.Text;

                    //Reset the file count
                    // Reset rtbOutput Colors
                    dGVoutPut.BackColor = Color.FromName("Control");
                    dGVoutPut.ForeColor = Color.Black;
                    fileCount = 0;
                    statusStrip1.Text = "Comparing secondary directory to primary.";
                    CompareDirectories(dirPrimary);

                    //Switch the directories and compare them in the opposite direction
                    statusStrip1.Text = "Comparing primary directory to secondary.";
                    dirPrimary = textBox2.Text;
                    dirCompare = textBox1.Text;

                    //After comparison is finished, report
                    statusStrip1.Text = fileCount.ToString() + " files tested.";
                    if (!itemsFound && dGVoutPut.Rows.Count == 1)
                    {
                        tbOutPut.Text += "All files match!";
                        tbOutPut.BackColor = Color.Green;
                        tbOutPut.ForeColor = Color.White;
                        toolStripStatusLabel2.Text = "All files and folders match.";
                        errorProvider.Clear();
                    }
                    else
                    {
                        tbOutPut.Text += "Files / Folders missing!";
                        tbOutPut.BackColor = Color.Red;
                        tbOutPut.ForeColor = Color.White;
                        toolStripStatusLabel2.Text = "File / Folder mismatch.";
                        errorProvider.Clear();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveOutput(object sender, EventArgs e)
        {
            StreamWriter outPut;
            try
            {
               // Prompt user for file location to save the text file of results
               if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Verify Path Exists
                    if (saveFileDialog.CheckPathExists)
                    {
                        outPut = new StreamWriter(saveFileDialog.FileName);

                        //Output all rows from the results grid to the text file
                        foreach (DataGridViewRow dgvRow in dGVoutPut.Rows)
                        {
                            foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                            {
                                outPut.WriteLine(dgvCell.Value);
                            }

                            outPut.WriteLine("");
                        }

                        //Make sure everything is written and save
                        outPut.Flush();
                        outPut.Close();

                        toolStripStatusLabel1.Text = "File saved to " + saveFileDialog.FileName + ".";
                    }
                    else
                        MessageBox.Show("That location doesn't exist. Please select a valid directory in which to save the file.", "Error saving the file ...");
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
            dGVoutPut.Rows.Clear();
            tvFilesView.Nodes.Clear();
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            tbOutPut.Text = "";
            tbOutPut.BackColor = Color.FromName("Menu");
            errorProvider.Clear();
        }

        private void InitializeGridColumns()
        {
            try
            {
                if (dGVoutPut.Columns.Count == 0)
                {
                    dGVoutPut.Columns.Add("Type", "Type");
                    dGVoutPut.Columns.Add("Name", "Item Name");
                    dGVoutPut.Columns.Add("Description", "Description");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of subdirectories
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has subdirectories add the place holder
                            if (di.GetDirectories().Count() > 0)
                            {
                                node.Nodes.Add(null, "...", 0, 0);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void rbPrimaryDir_CheckedChanged(object sender, EventArgs e)
        {
            btnAddFilePath.Text = "Pick Primary Path";
        }

        private void rbSecondaryDir_CheckedChanged(object sender, EventArgs e)
        {
            btnAddFilePath.Text = "Pick Secondary Path";
        }

        private void btnAddFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPrimaryDir.Checked)
                {
                    tvFilesView.SelectedNode.BackColor = Color.Blue;
                    tvFilesView.SelectedNode.ForeColor = Color.White;

                    if (tvFilesView.SelectedNode.PrevNode != null || tvFilesView.SelectedNode.PrevNode.BackColor == Color.Green
                        || tvFilesView.SelectedNode.PrevNode.BackColor == Color.Blue)
                    {
                        tvFilesView.SelectedNode.PrevNode.BackColor = Color.White;
                        tvFilesView.SelectedNode.PrevNode.ForeColor = Color.Black;
                    }

                    string Path1 = tvFilesView.SelectedNode.FullPath.ToString();
                    Path1 = Path1.Insert(1, ":");
                    textBox1.Text = Path1;
                }
                else if (rbSecondaryDir.Checked)
                {
                    tvFilesView.SelectedNode.BackColor = Color.Green;
                    tvFilesView.SelectedNode.ForeColor = Color.White;

                    if (tvFilesView.SelectedNode.PrevNode != null || tvFilesView.SelectedNode.PrevNode.BackColor == Color.Blue
                        || tvFilesView.SelectedNode.PrevNode.BackColor == Color.Green)
                    {
                        tvFilesView.SelectedNode.PrevNode.BackColor = Color.White;
                        tvFilesView.SelectedNode.PrevNode.ForeColor = Color.Black;
                    }

                    string Path2 = tvFilesView.SelectedNode.FullPath.ToString();
                    Path2 = Path2.Insert(1, ":");
                    textBox2.Text = Path2;
                }
                else
                {
                    tbOutPut.Text = "Pick two Directories to begin!";
                    errorProvider.SetError(rbPrimaryDir, "Select One");
                    errorProvider.SetError(rbSecondaryDir, "Select One");
                    errorProvider.SetError(btnPrimaryDir, "Select a Directory");
                    errorProvider.SetError(btnSecondDir, "Select a Directory");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expandAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                tvFilesView.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reloadDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get a list of all drivers
            string[] drivers = Environment.GetLogicalDrives();

            foreach (string drive in drivers)
            {
                DriveInfo di = new DriveInfo(drive);

                TreeNode node = new TreeNode(drive.Substring(0, 1));
                node.Tag = drive;

                if (di.IsReady == true)
                {
                    node.Nodes.Add("...");
                }

                tvFilesView.Nodes.Add(node);
            }
        }
    }
}
