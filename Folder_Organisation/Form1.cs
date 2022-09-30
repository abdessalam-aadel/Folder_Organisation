using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Folder_Organisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void txtGit_Click(object sender, EventArgs e)
        {
            // Go to Github repositorie
            Process.Start("https://github.com/abdessalam-aadel");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Load Folder to reorganize
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                txtBoxLoad.Text = FD.SelectedPath;
            }
        }

        // Enable Drag-and-Drop folder to the Form Main
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            txtBoxLoad.Text = path;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the text Done!
                txtDone.Text = "";

                // check if the user has been selected a folder
                // if not return ..
                if (txtBoxLoad.Text == "")
                {
                    return;
                }
                
                // get the path of Desktop
                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Creat Folder Result, 68 and 85
                string Result = pathDesktop + @"\Result";
                if (!Directory.Exists(Result))
                    Directory.CreateDirectory(Result);

                string R68 = pathDesktop + @"\Result\R68";
                if (!Directory.Exists(R68))
                    Directory.CreateDirectory(R68);

                string R85 = pathDesktop + @"\Result\R85";
                if (!Directory.Exists(R85))
                    Directory.CreateDirectory(R85);

                // Creat Folder Probleme
                string prb = pathDesktop + @"\Result\PRB";
                if (!Directory.Exists(prb))
                    Directory.CreateDirectory(prb);

                // Get all folder
                string[] allFolder = Directory.GetDirectories(txtBoxLoad.Text);

                // creating two variable to check if the 
                // folder IF68 and IF85E is empty or not
                string creatCopy68 = "";
                string creatCopy85 = "";

                // Starting the boucle for-each in All Folder
                foreach (string folderpath in allFolder)
                {
                    // Creating Directory Info to get the name of the folder path
                    DirectoryInfo difolder = new DirectoryInfo(folderpath);

                    // Get all sub-folder
                    string[] subFolder = Directory.GetDirectories(folderpath);

                    // Starting the boucle for-each in All Sub-Folder
                    foreach (string subfolderpath in subFolder)
                    {
                        // Creating Directory Info to get the name of the sub-folder path
                        DirectoryInfo disub = new DirectoryInfo(subfolderpath);

                        // Get all Files in sub-folder
                        string[] files = Directory.GetFiles(subfolderpath);

                        // Check if the folder name equal to ==> IF68
                        if (disub.Name == txtBoxFolder1.Text)
                        {
                            // Check if the folder (IF68) is Empty or not
                            if (files.Length == 0)
                                creatCopy68 = "0";
                            else
                                creatCopy68 = "1";
                        }

                        // Check if the folder name equal to ==> IF85E
                        if (disub.Name == txtBoxFolder2.Text)
                        {
                            // Check if the folder (IF85E) is Empty or not
                            if (files.Length == 0)
                                creatCopy85 = "0";
                            else
                                creatCopy85 = "1";
                        }

                        // Start Copying Folder to Result Folder
                        // ...
                        // Check if the folder : IF68 && IF85E is not empty
                        if (creatCopy68 == "1" && creatCopy85 == "1")
                        {
                            // D'ont Copy Folder
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }

                        // Check if the folder : IF68 is not empty && IF85E is empty
                        else if (creatCopy68 == "1" && creatCopy85 == "0")
                        {
                            // Copying the folder into R68 folder
                            CopyDirectory(folderpath, R68 + @"\" + difolder.Name, true);
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }

                        // Check if the folder : IF68 is empty && IF85E is not empty
                        else if (creatCopy68 == "0" && creatCopy85 == "1")
                        {
                            // Copying the folder into R85 folder
                            CopyDirectory(folderpath, R85 + @"\" + difolder.Name, true);
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }

                        // Check if the folder : IF68 && IF85E is empty
                        else if (creatCopy68 == "0" && creatCopy85 == "0")
                        {
                            // Copying the folder into Result folder
                            CopyDirectory(folderpath, Result + @"\" + difolder.Name, true);
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }

                        // Check if the folder : IF68 && IF85E those not existe
                        else if ( !Directory.Exists(folderpath + @"\IF68") && !Directory.Exists(folderpath + @"\IF85E") )
                        {
                            // Copying the folder into Result folder
                            CopyDirectory(folderpath, prb + @"\" + difolder.Name, true);
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }

                        // Check if the folder : IF68 && IF85E those not existe
                        else if (!Directory.Exists(folderpath + @"\IF68"))
                        {
                            // Copying the folder into Result folder
                            CopyDirectory(folderpath, prb + @"\" + difolder.Name, true);
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }

                        // Check if the folder : IF68 && IF85E those not existe
                        else if (!Directory.Exists(folderpath + @"\IF85E"))
                        {
                            // Copying the folder into Result folder
                            CopyDirectory(folderpath, prb + @"\" + difolder.Name, true);
                            creatCopy68 = "";
                            creatCopy85 = "";
                        }
                    }
                }

                // Message success ..
                txtDone.Text = "Done!";
            }

            catch (Exception ex)
            {
                // Show message of Any Exception
                MessageBox.Show(ex.Message);
            }
        }

        // Methode Copy Folder
        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath,true);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
    }
}
