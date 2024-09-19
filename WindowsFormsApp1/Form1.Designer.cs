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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 487);
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
    }
}

