namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFolder1 = new System.Windows.Forms.Button();
            this.labelPath1 = new System.Windows.Forms.Label();
            this.labelPath2 = new System.Windows.Forms.Label();
            this.btnFolder2 = new System.Windows.Forms.Button();
            this.SelectFolder1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.chkboxMoveAllDublicates = new System.Windows.Forms.CheckBox();
            this.Debug_mode = new System.Windows.Forms.CheckBox();
            this.ProgrammName = new System.Windows.Forms.Label();
            this.DublicatesPath = new System.Windows.Forms.Button();
            this.LabelDublicatesPath = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.TextBox();
            this.btnClearPath1 = new System.Windows.Forms.Button();
            this.btnClearPath2 = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.labelFileSizes = new System.Windows.Forms.Label();
            this.buttonStopProcessing = new System.Windows.Forms.Button();
            this.labelCheckOnly = new System.Windows.Forms.Label();
            this.labelIgnore = new System.Windows.Forms.Label();
            this.textBoxCheckOnlyExtensions = new System.Windows.Forms.TextBox();
            this.textBoxIgnoreExtensions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFolder1
            // 
            this.btnFolder1.Location = new System.Drawing.Point(43, 29);
            this.btnFolder1.Name = "btnFolder1";
            this.btnFolder1.Size = new System.Drawing.Size(116, 45);
            this.btnFolder1.TabIndex = 0;
            this.btnFolder1.Text = "Select folder 1";
            this.btnFolder1.UseVisualStyleBackColor = true;
            this.btnFolder1.Click += new System.EventHandler(this.btnFolder1_Click);
            // 
            // labelPath1
            // 
            this.labelPath1.AutoSize = true;
            this.labelPath1.Location = new System.Drawing.Point(52, 105);
            this.labelPath1.Name = "labelPath1";
            this.labelPath1.Size = new System.Drawing.Size(105, 16);
            this.labelPath1.TabIndex = 1;
            this.labelPath1.Text = "Select 1st folder!";
            this.labelPath1.Click += new System.EventHandler(this.labelHelloWorld_Click);
            // 
            // labelPath2
            // 
            this.labelPath2.AutoSize = true;
            this.labelPath2.Location = new System.Drawing.Point(52, 242);
            this.labelPath2.Name = "labelPath2";
            this.labelPath2.Size = new System.Drawing.Size(110, 16);
            this.labelPath2.TabIndex = 3;
            this.labelPath2.Text = "Select 2nd folder!";
            this.labelPath2.Click += new System.EventHandler(this.labelPath2_Click);
            // 
            // btnFolder2
            // 
            this.btnFolder2.Location = new System.Drawing.Point(43, 171);
            this.btnFolder2.Name = "btnFolder2";
            this.btnFolder2.Size = new System.Drawing.Size(116, 45);
            this.btnFolder2.TabIndex = 2;
            this.btnFolder2.Text = "Select folder 2";
            this.btnFolder2.UseVisualStyleBackColor = true;
            this.btnFolder2.Click += new System.EventHandler(this.btnFolder2_Click);
            // 
            // SelectFolder1
            // 
            this.SelectFolder1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMoveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMoveFiles.Location = new System.Drawing.Point(458, 147);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(177, 69);
            this.btnMoveFiles.TabIndex = 4;
            this.btnMoveFiles.Text = "Move files";
            this.btnMoveFiles.UseVisualStyleBackColor = false;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // chkboxMoveAllDublicates
            // 
            this.chkboxMoveAllDublicates.AutoSize = true;
            this.chkboxMoveAllDublicates.Location = new System.Drawing.Point(721, 29);
            this.chkboxMoveAllDublicates.Name = "chkboxMoveAllDublicates";
            this.chkboxMoveAllDublicates.Size = new System.Drawing.Size(321, 20);
            this.chkboxMoveAllDublicates.TabIndex = 5;
            this.chkboxMoveAllDublicates.Text = "Put all files that have duplicates in separate folder";
            this.chkboxMoveAllDublicates.UseVisualStyleBackColor = true;
            this.chkboxMoveAllDublicates.CheckedChanged += new System.EventHandler(this.chkbxMoveAllDublicates_CheckedChanged);
            // 
            // Debug_mode
            // 
            this.Debug_mode.AutoSize = true;
            this.Debug_mode.Location = new System.Drawing.Point(721, 55);
            this.Debug_mode.Name = "Debug_mode";
            this.Debug_mode.Size = new System.Drawing.Size(108, 20);
            this.Debug_mode.TabIndex = 6;
            this.Debug_mode.Text = "Debug mode";
            this.Debug_mode.UseVisualStyleBackColor = true;
            this.Debug_mode.CheckedChanged += new System.EventHandler(this.Debug_mode_CheckedChanged);
            // 
            // ProgrammName
            // 
            this.ProgrammName.AutoSize = true;
            this.ProgrammName.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.ProgrammName.Location = new System.Drawing.Point(425, 20);
            this.ProgrammName.Name = "ProgrammName";
            this.ProgrammName.Size = new System.Drawing.Size(223, 29);
            this.ProgrammName.TabIndex = 7;
            this.ProgrammName.Text = "Search for dublicates";
            // 
            // DublicatesPath
            // 
            this.DublicatesPath.Location = new System.Drawing.Point(43, 299);
            this.DublicatesPath.Name = "DublicatesPath";
            this.DublicatesPath.Size = new System.Drawing.Size(116, 45);
            this.DublicatesPath.TabIndex = 10;
            this.DublicatesPath.Text = "Select folder for dublicates";
            this.DublicatesPath.UseVisualStyleBackColor = true;
            this.DublicatesPath.Click += new System.EventHandler(this.DublicatesPath_Click);
            // 
            // LabelDublicatesPath
            // 
            this.LabelDublicatesPath.AutoSize = true;
            this.LabelDublicatesPath.Location = new System.Drawing.Point(52, 369);
            this.LabelDublicatesPath.Name = "LabelDublicatesPath";
            this.LabelDublicatesPath.Size = new System.Drawing.Size(160, 16);
            this.LabelDublicatesPath.TabIndex = 11;
            this.LabelDublicatesPath.Text = "Select path for dublicates!";
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(712, 102);
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugText.Size = new System.Drawing.Size(970, 566);
            this.debugText.TabIndex = 12;
            this.debugText.Text = resources.GetString("debugText.Text");
            this.debugText.WordWrap = false;
            // 
            // btnClearPath1
            // 
            this.btnClearPath1.Location = new System.Drawing.Point(226, 29);
            this.btnClearPath1.Name = "btnClearPath1";
            this.btnClearPath1.Size = new System.Drawing.Size(116, 45);
            this.btnClearPath1.TabIndex = 13;
            this.btnClearPath1.Text = "Clear path 1";
            this.btnClearPath1.UseVisualStyleBackColor = true;
            this.btnClearPath1.Click += new System.EventHandler(this.btnClearPath1_Click);
            // 
            // btnClearPath2
            // 
            this.btnClearPath2.Location = new System.Drawing.Point(226, 171);
            this.btnClearPath2.Name = "btnClearPath2";
            this.btnClearPath2.Size = new System.Drawing.Size(116, 45);
            this.btnClearPath2.TabIndex = 14;
            this.btnClearPath2.Text = "Clear path 2";
            this.btnClearPath2.UseVisualStyleBackColor = true;
            this.btnClearPath2.Click += new System.EventHandler(this.btnClearPath2_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(12, 623);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(72, 48);
            this.Version.TabIndex = 15;
            this.Version.Text = "V 1.2.0\r\n23.10.2024\r\nby Vipaloo";
            // 
            // labelFileSizes
            // 
            this.labelFileSizes.AutoSize = true;
            this.labelFileSizes.Location = new System.Drawing.Point(427, 313);
            this.labelFileSizes.Name = "labelFileSizes";
            this.labelFileSizes.Size = new System.Drawing.Size(221, 16);
            this.labelFileSizes.TabIndex = 16;
            this.labelFileSizes.Text = "Here will be displayed all files sizes!";
            // 
            // buttonStopProcessing
            // 
            this.buttonStopProcessing.BackColor = System.Drawing.Color.Red;
            this.buttonStopProcessing.Enabled = false;
            this.buttonStopProcessing.Location = new System.Drawing.Point(496, 242);
            this.buttonStopProcessing.Name = "buttonStopProcessing";
            this.buttonStopProcessing.Size = new System.Drawing.Size(99, 47);
            this.buttonStopProcessing.TabIndex = 17;
            this.buttonStopProcessing.Text = "Stop processing";
            this.buttonStopProcessing.UseVisualStyleBackColor = false;
            this.buttonStopProcessing.Click += new System.EventHandler(this.buttonStopProcessing_Click);
            // 
            // labelCheckOnly
            // 
            this.labelCheckOnly.AutoSize = true;
            this.labelCheckOnly.Location = new System.Drawing.Point(110, 427);
            this.labelCheckOnly.Name = "labelCheckOnly";
            this.labelCheckOnly.Size = new System.Drawing.Size(76, 16);
            this.labelCheckOnly.TabIndex = 18;
            this.labelCheckOnly.Text = "Check only:";
            // 
            // labelIgnore
            // 
            this.labelIgnore.AutoSize = true;
            this.labelIgnore.Location = new System.Drawing.Point(274, 427);
            this.labelIgnore.Name = "labelIgnore";
            this.labelIgnore.Size = new System.Drawing.Size(48, 16);
            this.labelIgnore.TabIndex = 19;
            this.labelIgnore.Text = "Ignore:";
            // 
            // textBoxCheckOnlyExtensions
            // 
            this.textBoxCheckOnlyExtensions.Location = new System.Drawing.Point(113, 460);
            this.textBoxCheckOnlyExtensions.Multiline = true;
            this.textBoxCheckOnlyExtensions.Name = "textBoxCheckOnlyExtensions";
            this.textBoxCheckOnlyExtensions.Size = new System.Drawing.Size(73, 198);
            this.textBoxCheckOnlyExtensions.TabIndex = 20;
            // 
            // textBoxIgnoreExtensions
            // 
            this.textBoxIgnoreExtensions.Location = new System.Drawing.Point(277, 460);
            this.textBoxIgnoreExtensions.Multiline = true;
            this.textBoxIgnoreExtensions.Name = "textBoxIgnoreExtensions";
            this.textBoxIgnoreExtensions.Size = new System.Drawing.Size(73, 198);
            this.textBoxIgnoreExtensions.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1694, 680);
            this.Controls.Add(this.textBoxIgnoreExtensions);
            this.Controls.Add(this.textBoxCheckOnlyExtensions);
            this.Controls.Add(this.labelIgnore);
            this.Controls.Add(this.labelCheckOnly);
            this.Controls.Add(this.buttonStopProcessing);
            this.Controls.Add(this.labelFileSizes);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.btnClearPath2);
            this.Controls.Add(this.btnClearPath1);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.LabelDublicatesPath);
            this.Controls.Add(this.DublicatesPath);
            this.Controls.Add(this.ProgrammName);
            this.Controls.Add(this.Debug_mode);
            this.Controls.Add(this.chkboxMoveAllDublicates);
            this.Controls.Add(this.btnMoveFiles);
            this.Controls.Add(this.labelPath2);
            this.Controls.Add(this.btnFolder2);
            this.Controls.Add(this.labelPath1);
            this.Controls.Add(this.btnFolder1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Dublicate Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolder1;
        private System.Windows.Forms.Label labelPath1;
        private System.Windows.Forms.Label labelPath2;
        private System.Windows.Forms.Button btnFolder2;
        private System.Windows.Forms.FolderBrowserDialog SelectFolder1;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.CheckBox chkboxMoveAllDublicates;
        private System.Windows.Forms.CheckBox Debug_mode;
        private System.Windows.Forms.Label ProgrammName;
        private System.Windows.Forms.Button DublicatesPath;
        private System.Windows.Forms.Label LabelDublicatesPath;
        private System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.Button btnClearPath1;
        private System.Windows.Forms.Button btnClearPath2;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label labelFileSizes;
        private System.Windows.Forms.Button buttonStopProcessing;
        private System.Windows.Forms.Label labelCheckOnly;
        private System.Windows.Forms.Label labelIgnore;
        private System.Windows.Forms.TextBox textBoxCheckOnlyExtensions;
        private System.Windows.Forms.TextBox textBoxIgnoreExtensions;
    }
}

