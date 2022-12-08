namespace HashCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.selectedFileName = new System.Windows.Forms.Label();
            this.md5HashLabel = new System.Windows.Forms.Label();
            this.sha1HashLabel = new System.Windows.Forms.Label();
            this.sha256HashLabel = new System.Windows.Forms.Label();
            this.sha384HashLabel = new System.Windows.Forms.Label();
            this.crc32HashLabel = new System.Windows.Forms.Label();
            this.md5CheckBox = new System.Windows.Forms.CheckBox();
            this.sha1CheckBox = new System.Windows.Forms.CheckBox();
            this.sha256CheckBox = new System.Windows.Forms.CheckBox();
            this.sha384CheckBox = new System.Windows.Forms.CheckBox();
            this.crc32CheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Review = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(14, 9);
            this.chooseFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(147, 47);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // selectedFileName
            // 
            this.selectedFileName.AutoSize = true;
            this.selectedFileName.Location = new System.Drawing.Point(168, 23);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(113, 20);
            this.selectedFileName.TabIndex = 1;
            this.selectedFileName.Text = "No file selected";
            this.selectedFileName.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // md5HashLabel
            // 
            this.md5HashLabel.AutoSize = true;
            this.md5HashLabel.Location = new System.Drawing.Point(106, 64);
            this.md5HashLabel.Name = "md5HashLabel";
            this.md5HashLabel.Size = new System.Drawing.Size(65, 20);
            this.md5HashLabel.TabIndex = 2;
            this.md5HashLabel.Text = "No Data";
            // 
            // sha1HashLabel
            // 
            this.sha1HashLabel.AutoSize = true;
            this.sha1HashLabel.Location = new System.Drawing.Point(106, 84);
            this.sha1HashLabel.Name = "sha1HashLabel";
            this.sha1HashLabel.Size = new System.Drawing.Size(65, 20);
            this.sha1HashLabel.TabIndex = 3;
            this.sha1HashLabel.Text = "No Data";
            // 
            // sha256HashLabel
            // 
            this.sha256HashLabel.AutoSize = true;
            this.sha256HashLabel.Location = new System.Drawing.Point(106, 104);
            this.sha256HashLabel.Name = "sha256HashLabel";
            this.sha256HashLabel.Size = new System.Drawing.Size(65, 20);
            this.sha256HashLabel.TabIndex = 4;
            this.sha256HashLabel.Text = "No Data";
            // 
            // sha384HashLabel
            // 
            this.sha384HashLabel.AutoSize = true;
            this.sha384HashLabel.Location = new System.Drawing.Point(106, 124);
            this.sha384HashLabel.Name = "sha384HashLabel";
            this.sha384HashLabel.Size = new System.Drawing.Size(65, 20);
            this.sha384HashLabel.TabIndex = 5;
            this.sha384HashLabel.Text = "No Data";
            // 
            // crc32HashLabel
            // 
            this.crc32HashLabel.AutoSize = true;
            this.crc32HashLabel.Location = new System.Drawing.Point(106, 144);
            this.crc32HashLabel.Name = "crc32HashLabel";
            this.crc32HashLabel.Size = new System.Drawing.Size(65, 20);
            this.crc32HashLabel.TabIndex = 6;
            this.crc32HashLabel.Text = "No Data";
            // 
            // md5CheckBox
            // 
            this.md5CheckBox.AutoSize = true;
            this.md5CheckBox.Location = new System.Drawing.Point(14, 64);
            this.md5CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.md5CheckBox.Name = "md5CheckBox";
            this.md5CheckBox.Size = new System.Drawing.Size(63, 24);
            this.md5CheckBox.TabIndex = 12;
            this.md5CheckBox.Text = "MD5";
            this.md5CheckBox.UseVisualStyleBackColor = true;
            // 
            // sha1CheckBox
            // 
            this.sha1CheckBox.AutoSize = true;
            this.sha1CheckBox.Location = new System.Drawing.Point(14, 84);
            this.sha1CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sha1CheckBox.Name = "sha1CheckBox";
            this.sha1CheckBox.Size = new System.Drawing.Size(68, 24);
            this.sha1CheckBox.TabIndex = 13;
            this.sha1CheckBox.Text = "SHA1";
            this.sha1CheckBox.UseVisualStyleBackColor = true;
            // 
            // sha256CheckBox
            // 
            this.sha256CheckBox.AutoSize = true;
            this.sha256CheckBox.Location = new System.Drawing.Point(14, 104);
            this.sha256CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sha256CheckBox.Name = "sha256CheckBox";
            this.sha256CheckBox.Size = new System.Drawing.Size(84, 24);
            this.sha256CheckBox.TabIndex = 14;
            this.sha256CheckBox.Text = "SHA256";
            this.sha256CheckBox.UseVisualStyleBackColor = true;
            // 
            // sha384CheckBox
            // 
            this.sha384CheckBox.AutoSize = true;
            this.sha384CheckBox.Location = new System.Drawing.Point(14, 124);
            this.sha384CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sha384CheckBox.Name = "sha384CheckBox";
            this.sha384CheckBox.Size = new System.Drawing.Size(84, 24);
            this.sha384CheckBox.TabIndex = 15;
            this.sha384CheckBox.Text = "SHA384";
            this.sha384CheckBox.UseVisualStyleBackColor = true;
            // 
            // crc32CheckBox
            // 
            this.crc32CheckBox.AutoSize = true;
            this.crc32CheckBox.Location = new System.Drawing.Point(14, 144);
            this.crc32CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crc32CheckBox.Name = "crc32CheckBox";
            this.crc32CheckBox.Size = new System.Drawing.Size(74, 24);
            this.crc32CheckBox.TabIndex = 16;
            this.crc32CheckBox.Text = "CRC32";
            this.crc32CheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(14, 171);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(147, 37);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate selected";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(955, 176);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Review
            // 
            this.Review.Location = new System.Drawing.Point(819, 175);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(94, 29);
            this.Review.TabIndex = 21;
            this.Review.Text = "Review";
            this.Review.UseVisualStyleBackColor = true;
            this.Review.Click += new System.EventHandler(this.Review_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(199, 171);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 34);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 221);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.crc32CheckBox);
            this.Controls.Add(this.sha384CheckBox);
            this.Controls.Add(this.sha256CheckBox);
            this.Controls.Add(this.sha1CheckBox);
            this.Controls.Add(this.md5CheckBox);
            this.Controls.Add(this.crc32HashLabel);
            this.Controls.Add(this.sha384HashLabel);
            this.Controls.Add(this.sha256HashLabel);
            this.Controls.Add(this.sha1HashLabel);
            this.Controls.Add(this.md5HashLabel);
            this.Controls.Add(this.selectedFileName);
            this.Controls.Add(this.chooseFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Калькулятор контрольних сум. Болгар, Бондар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chooseFileButton;
        private Label selectedFileName;
        private Label md5HashLabel;
        private Label sha1HashLabel;
        private Label sha256HashLabel;
        private Label sha384HashLabel;
        private Label crc32HashLabel;
        private CheckBox md5CheckBox;
        private CheckBox sha1CheckBox;
        private CheckBox sha256CheckBox;
        private CheckBox sha384CheckBox;
        private CheckBox crc32CheckBox;
        private Button calculateButton;
        private Button Exit;
        private Button Review;
        private Button Save;
        private TextBox textBox1;
    }
}