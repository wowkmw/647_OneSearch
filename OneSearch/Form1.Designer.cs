namespace OneSearch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jsonButton = new System.Windows.Forms.Button();
            this.buildIndex = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.jsonPath = new System.Windows.Forms.TextBox();
            this.showIndexPath = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(449, 26);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(114, 29);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.Text = "JSON Path";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buildIndex
            // 
            this.buildIndex.Location = new System.Drawing.Point(128, 121);
            this.buildIndex.Name = "buildIndex";
            this.buildIndex.Size = new System.Drawing.Size(199, 31);
            this.buildIndex.TabIndex = 1;
            this.buildIndex.Text = ">>Initialize Search Engine<<";
            this.buildIndex.UseVisualStyleBackColor = true;
            this.buildIndex.Click += new System.EventHandler(this.button2_Click);
            // 
            // indexButton
            // 
            this.indexButton.Location = new System.Drawing.Point(449, 74);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(114, 30);
            this.indexButton.TabIndex = 2;
            this.indexButton.Text = "Index Path";
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // jsonPath
            // 
            this.jsonPath.Location = new System.Drawing.Point(12, 29);
            this.jsonPath.Name = "jsonPath";
            this.jsonPath.Size = new System.Drawing.Size(431, 22);
            this.jsonPath.TabIndex = 3;
            this.jsonPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showIndexPath
            // 
            this.showIndexPath.Location = new System.Drawing.Point(12, 78);
            this.showIndexPath.Name = "showIndexPath";
            this.showIndexPath.Size = new System.Drawing.Size(431, 22);
            this.showIndexPath.TabIndex = 4;
            this.showIndexPath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(431, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(450, 173);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 30);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(12, 441);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(111, 33);
            this.ExitApp.TabIndex = 7;
            this.ExitApp.Text = "EXIT...";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 486);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.showIndexPath);
            this.Controls.Add(this.jsonPath);
            this.Controls.Add(this.indexButton);
            this.Controls.Add(this.buildIndex);
            this.Controls.Add(this.jsonButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.Button buildIndex;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.TextBox jsonPath;
        private System.Windows.Forms.TextBox showIndexPath;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button ExitApp;
    }
}

