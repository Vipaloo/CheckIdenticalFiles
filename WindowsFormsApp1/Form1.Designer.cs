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
            this.btnFolder1 = new System.Windows.Forms.Button();
            this.labelPath1 = new System.Windows.Forms.Label();
            this.labelPath2 = new System.Windows.Forms.Label();
            this.btnFolder2 = new System.Windows.Forms.Button();
            this.SelectFolder1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPrintFiles = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Debug_mode = new System.Windows.Forms.CheckBox();
            this.ProgrammName = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.Label();
            this.DublicatesPath = new System.Windows.Forms.Button();
            this.LabelDublicatesPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFolder1
            // 
            this.btnFolder1.Location = new System.Drawing.Point(43, 29);
            this.btnFolder1.Name = "btnFolder1";
            this.btnFolder1.Size = new System.Drawing.Size(116, 45);
            this.btnFolder1.TabIndex = 0;
            this.btnFolder1.Text = "select folder 1";
            this.btnFolder1.UseVisualStyleBackColor = true;
            this.btnFolder1.Click += new System.EventHandler(this.btnFolder1_Click);
            // 
            // labelPath1
            // 
            this.labelPath1.AutoSize = true;
            this.labelPath1.Location = new System.Drawing.Point(61, 105);
            this.labelPath1.Name = "labelPath1";
            this.labelPath1.Size = new System.Drawing.Size(80, 16);
            this.labelPath1.TabIndex = 1;
            this.labelPath1.Text = "folder 1 path";
            this.labelPath1.Click += new System.EventHandler(this.labelHelloWorld_Click);
            // 
            // labelPath2
            // 
            this.labelPath2.AutoSize = true;
            this.labelPath2.Location = new System.Drawing.Point(61, 247);
            this.labelPath2.Name = "labelPath2";
            this.labelPath2.Size = new System.Drawing.Size(80, 16);
            this.labelPath2.TabIndex = 3;
            this.labelPath2.Text = "folder 2 path";
            this.labelPath2.Click += new System.EventHandler(this.labelPath2_Click);
            // 
            // btnFolder2
            // 
            this.btnFolder2.Location = new System.Drawing.Point(43, 171);
            this.btnFolder2.Name = "btnFolder2";
            this.btnFolder2.Size = new System.Drawing.Size(116, 45);
            this.btnFolder2.TabIndex = 2;
            this.btnFolder2.Text = "select folder 2";
            this.btnFolder2.UseVisualStyleBackColor = true;
            this.btnFolder2.Click += new System.EventHandler(this.btnFolder2_Click);
            // 
            // SelectFolder1
            // 
            this.SelectFolder1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnPrintFiles
            // 
            this.btnPrintFiles.Location = new System.Drawing.Point(360, 171);
            this.btnPrintFiles.Name = "btnPrintFiles";
            this.btnPrintFiles.Size = new System.Drawing.Size(177, 69);
            this.btnPrintFiles.TabIndex = 4;
            this.btnPrintFiles.Text = "Move files";
            this.btnPrintFiles.UseVisualStyleBackColor = true;
            this.btnPrintFiles.Click += new System.EventHandler(this.btnPrintFiles_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(626, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(321, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Put all files that have duplicates in separate folder";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Debug_mode
            // 
            this.Debug_mode.AutoSize = true;
            this.Debug_mode.Location = new System.Drawing.Point(626, 55);
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
            this.ProgrammName.Location = new System.Drawing.Point(330, 20);
            this.ProgrammName.Name = "ProgrammName";
            this.ProgrammName.Size = new System.Drawing.Size(223, 29);
            this.ProgrammName.TabIndex = 7;
            this.ProgrammName.Text = "Search for dublicates";
            // 
            // debugText
            // 
            this.debugText.AutoSize = true;
            this.debugText.Location = new System.Drawing.Point(598, 128);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(14, 16);
            this.debugText.TabIndex = 8;
            this.debugText.Text = "_";
            // 
            // DublicatesPath
            // 
            this.DublicatesPath.Location = new System.Drawing.Point(43, 299);
            this.DublicatesPath.Name = "DublicatesPath";
            this.DublicatesPath.Size = new System.Drawing.Size(116, 45);
            this.DublicatesPath.TabIndex = 10;
            this.DublicatesPath.Text = "folder where to put dublicates";
            this.DublicatesPath.UseVisualStyleBackColor = true;
            this.DublicatesPath.Click += new System.EventHandler(this.DublicatesPath_Click);
            // 
            // LabelDublicatesPath
            // 
            this.LabelDublicatesPath.AutoSize = true;
            this.LabelDublicatesPath.Location = new System.Drawing.Point(52, 369);
            this.LabelDublicatesPath.Name = "LabelDublicatesPath";
            this.LabelDublicatesPath.Size = new System.Drawing.Size(98, 16);
            this.LabelDublicatesPath.TabIndex = 11;
            this.LabelDublicatesPath.Text = "dublicates path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 491);
            this.Controls.Add(this.LabelDublicatesPath);
            this.Controls.Add(this.DublicatesPath);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.ProgrammName);
            this.Controls.Add(this.Debug_mode);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnPrintFiles);
            this.Controls.Add(this.labelPath2);
            this.Controls.Add(this.btnFolder2);
            this.Controls.Add(this.labelPath1);
            this.Controls.Add(this.btnFolder1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFolder1;
        private System.Windows.Forms.Label labelPath1;
        private System.Windows.Forms.Label labelPath2;
        private System.Windows.Forms.Button btnFolder2;
        private System.Windows.Forms.FolderBrowserDialog SelectFolder1;
        private System.Windows.Forms.Button btnPrintFiles;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox Debug_mode;
        private System.Windows.Forms.Label ProgrammName;
        private System.Windows.Forms.Label debugText;
        private System.Windows.Forms.Button DublicatesPath;
        private System.Windows.Forms.Label LabelDublicatesPath;
    }
}

