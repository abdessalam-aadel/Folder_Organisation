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
            Process.Start("https://github.com/abdessalam-aadel");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                txtBoxLoad.Text = FD.SelectedPath;
            }
        }

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
            txtDone.Text = "";
            if (txtBoxLoad.Text == "")
            {
                return;
            }

            // Creat Folder Result (IF68 && IF85E)

            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string Result = pathDesktop + @"\Result";
            if (!Directory.Exists(Result))
            {
                Directory.CreateDirectory(Result);
            }

            string R68 = pathDesktop + @"\Result\R68";
            if (!Directory.Exists(R68))
            {
                Directory.CreateDirectory(R68);
            }

            string R85 = pathDesktop + @"\Result\R85";
            if (!Directory.Exists(R85))
            {
                Directory.CreateDirectory(R85);
            }

            string[] allFolder = Directory.GetDirectories(txtBoxLoad.Text);

            string creatCopy68 = "";
            string creatCopy85 = "";

            foreach (string folderpath in allFolder)
            {
                DirectoryInfo difolder = new DirectoryInfo(folderpath);
                string[] subFolder = Directory.GetDirectories(folderpath);
                foreach (string subfolderpath in subFolder)
                {
                    DirectoryInfo disub = new DirectoryInfo(subfolderpath);
                    string[] files = Directory.GetFiles(subfolderpath);

                    // ==> IF68
                    if (disub.Name == txtBoxFolder1.Text)
                    {
                        if (files.Length == 0)
                        {
                            creatCopy68 = "0";
                        }
                        else
                        {
                            creatCopy68 = "1";
                        }
                    }
                    else { }

                    // ==> IF85E
                    if (disub.Name == txtBoxFolder2.Text)
                    {
                        if (files.Length == 0)
                        {
                            creatCopy85 = "0";
                        }
                        else
                        {
                            creatCopy85 = "1";
                        }
                    }
                    else { }

                    // Creat Copy folder to Result Folder
                    if (creatCopy68 == "1" && creatCopy85 == "1")
                    {
                        // D'ont Copy Folder
                        creatCopy68 = "";
                        creatCopy85 = "";
                    }

                    else if (creatCopy68 == "1" && creatCopy85 == "0")
                    {
                        CopyDirectory(folderpath, R68 + @"\" + difolder.Name, true);
                        creatCopy68 = "";
                        creatCopy85 = "";
                    }

                    else if (creatCopy68 == "0" && creatCopy85 == "1")
                    {
                        CopyDirectory(folderpath, R85 + @"\" + difolder.Name, true);
                        creatCopy68 = "";
                        creatCopy85 = "";
                    }

                    else if (creatCopy68 == "0" && creatCopy85 == "0")
                    {
                        CopyDirectory(folderpath, Result + @"\" + difolder.Name, true);
                        creatCopy68 = "";
                        creatCopy85 = "";
                    }
                }
            }
            txtDone.Text = "Done!";
        }

        // Methode Copy Folder
        //static public void CopyFolder(string sourceFolder, string destFolder)
        //{
        //    if (!Directory.Exists(destFolder))
        //        Directory.CreateDirectory(destFolder);
        //    string[] files = Directory.GetFiles(sourceFolder);
        //    foreach (string file in files)
        //    {
        //        string name = Path.GetFileName(file);
        //        string dest = Path.Combine(destFolder, name);
        //        File.Copy(file, dest);
        //    }
        //    string[] folders = Directory.GetDirectories(sourceFolder);
        //    foreach (string folder in folders)
        //    {
        //        string name = Path.GetFileName(folder);
        //        string dest = Path.Combine(destFolder, name);
        //        CopyFolder(folder, dest);
        //    }
        //}

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
