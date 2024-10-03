using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String path1 = "";
        String path2 = "";
        String dublicatesPath = "";
        List<string> allFilesPaths = new List<string>();  // List to hold all file paths
        List<byte[]> allHashes = new List<byte[]>(); // List to hold all byte[] hashes
        List<List<string>> identicalFiles = new List<List<string>>(); // List to hold groups of similar files

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for button click to select the first folder
        private void btnFolder1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    labelPath1.Text = folderBrowserDialog.SelectedPath;
                    path1 = folderBrowserDialog.SelectedPath;
                }
            }
        }

        // Event handler for button click to select the second folder
        private void btnFolder2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    labelPath2.Text = folderBrowserDialog.SelectedPath;
                    path2 = folderBrowserDialog.SelectedPath;
                }
            }
        }

        // Event handler for button click to process the files and find identical ones
        // Main function
        private async void btnPrintFiles_Click(object sender, EventArgs e)
        {
            if (path1 == "" && path2 == "")
            {
                // If no folder selected 
                MessageBox.Show($"Please select folder from where to take files!",
                    "No selected folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (dublicatesPath == "")
            {
                // If no path for dublicates selected 
                MessageBox.Show($"Please select folder where to put dublicates!",
                    "No path for dublicates",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (!Debug_mode.Checked)
            {
                DialogResult ConfirmationResult = MessageBox.Show($"This will move all identical files without any further conformations. If you are not sure that you want to move files, use debug mode first.",
                    "Are you sure you want to move files?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (ConfirmationResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Update the debug text immediately
            debugText.Text = "Working on it...";

            // Clear previous data
            allFilesPaths.Clear();
            allHashes.Clear();
            identicalFiles.Clear();

            // Run file processing in a background task
            await Task.Run(() =>
            {
                // Call the recursive DFS function starting from path1 and path2
                if(path1 != "")
                {
                    GetFilesDFS(path1);
                }
                if(path2 != "")
                {
                    GetFilesDFS(path2);
                }
                // Compare all hashes and group identical files
                CompareAndGroupHashes();

                // Display the results in the console
                Console.WriteLine("Groups of identical files:");
                if (chkboxMoveAllDublicates.Checked)
                {
                    foreach (var group in identicalFiles)
                    {
                        Console.WriteLine("Identical files:");
                        foreach (var file in group)
                        {
                            Console.WriteLine(file);
                            if (Debug_mode.Checked)
                            {
                                debugText.Text += file + " will be moved to --> " + dublicatesPath + "\n";
                            }
                            else
                            {
                                MoveIdenticalFiles(file);
                                debugText.Text = "Done!";
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    foreach (var group in identicalFiles)
                    {
                        foreach (var file in group)
                        {
                            if (Debug_mode.Checked)
                            {
                                // Safely update debugText using Invoke to marshal the call to the UI thread
                                this.Invoke(new Action(() =>
                                {
                                    if (file != group[0])
                                    {
                                        debugText.Text += file + " will be moved to --> " + dublicatesPath + "\n";
                                    }
                                }));
                            }
                            else
                            {
                                if (file == group[0])
                                {
                                    continue;
                                }
                                MoveIdenticalFiles(file);
                                this.Invoke(new Action(() =>
                                {
                                    debugText.Text = "Done!";
                                }));
                            }
                        }
                    }
                }
            });
        }

        // DFS method to recursively get files in directories and subdirectories
        private void GetFilesDFS(string directory)
        {
            try
            {
                // Get all files in the current directory
                string[] files = Directory.GetFiles(directory);

                // Process each file
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                    allFilesPaths.Add(file); // Add file path to the list

                    using (var md5 = MD5.Create())
                    {
                        using (var fileStream = File.OpenRead(file))
                        {
                            byte[] hashBytes = md5.ComputeHash(fileStream); // Compute the hash
                            allHashes.Add(hashBytes); // Add the byte[] array to the list
                        }
                    }
                }

                // Get all subdirectories in the current directory
                string[] subDirectories = Directory.GetDirectories(directory);

                // Recursively call this method for each subdirectory
                foreach (string subDir in subDirectories)
                {
                    GetFilesDFS(subDir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied to folder: " + directory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Method to compare hashes and group identical files
        private void CompareAndGroupHashes()
        {
            var checkedHashes = new HashSet<int>(); // Track already compared hashes

            for (int i = 0; i < allHashes.Count; i++)
            {
                if (checkedHashes.Contains(i))
                    continue;

                var similarGroup = new List<string> { allFilesPaths[i] };

                for (int j = i + 1; j < allHashes.Count; j++)
                {
                    if (allHashes[i].SequenceEqual(allHashes[j]))
                    {
                        similarGroup.Add(allFilesPaths[j]);
                        checkedHashes.Add(j); // Mark this hash as checked
                    }
                }

                if (similarGroup.Count > 1)
                {
                    identicalFiles.Add(similarGroup); // Add the group of similar files to the list
                }
            }
        }

        private void MoveIdenticalFiles(string oldPath)
        {
            try
            {
                // Get the file name from the old path
                string fileName = Path.GetFileName(oldPath);

                // Construct the new file path
                string newPath = Path.Combine(dublicatesPath, fileName);

                // Check if the file already exists at the new location
                if (File.Exists(newPath))
                {
                    MessageBox.Show($"File '{newPath}' already exists in the destination folder.", "File Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method since the file already exists
                }

                // Move the file to the new location
                File.Move(oldPath, newPath);

            }
            catch (IOException ioEx)
            {
                // If an IOException occurs, inform the user
                MessageBox.Show($"An error occurred while moving the file: {ioEx.Message}", "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch any other exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Unchanged event handlers (just placeholders to keep the structure intact)
        private void labelHelloWorld_Click(object sender, EventArgs e)
        {
            labelPath1.Text = "Goodbye World!";
        }

        private void labelPath2_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("This is the folder browser dialog help.");
        }

        private void chkbxMoveAllDublicates_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Debug_mode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DublicatesPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    LabelDublicatesPath.Text = folderBrowserDialog.SelectedPath;
                    dublicatesPath = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}
