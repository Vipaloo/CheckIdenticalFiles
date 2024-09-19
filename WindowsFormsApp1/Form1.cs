using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for button click
        private void btnFolder1_Click(object sender, EventArgs e)
        {
            // Create and configure a FolderBrowserDialog
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";

                // Show the dialog and check if the user clicked OK
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Display the selected folder path in the label
                    labelPath1.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        // Event handler for label click
        private void labelHelloWorld_Click(object sender, EventArgs e)
        {
            labelPath1.Text = "Goodbye World!";
        }

        // Event handler for FolderBrowserDialog HelpRequest (optional)
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("This is the folder browser dialog help.");
        }

        private void btnFolder2_Click(object sender, EventArgs e)
        {
            // Create and configure a FolderBrowserDialog
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";

                // Show the dialog and check if the user clicked OK
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Display the selected folder path in the label
                    labelPath2.Text = folderBrowserDialog.SelectedPath;
                }
            }

        }

        private void labelPath2_Click(object sender, EventArgs e)
        {

        }
    }
}
