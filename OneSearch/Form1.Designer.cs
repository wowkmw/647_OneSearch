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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jsonButton = new System.Windows.Forms.Button();
            this.buildIndex = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.jsonPath = new System.Windows.Forms.TextBox();
            this.showIndexPath = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.ResulttView = new System.Windows.Forms.ListView();
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FinalWord = new System.Windows.Forms.Label();
            this.TotalResult = new System.Windows.Forms.Label();
            this.FinalWordBox = new System.Windows.Forms.TextBox();
            this.TotalResultBox = new System.Windows.Forms.TextBox();
            this.AsIsBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(674, 153);
            this.jsonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(171, 44);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.Text = "JSON Path";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buildIndex
            // 
            this.buildIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildIndex.Location = new System.Drawing.Point(192, 296);
            this.buildIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buildIndex.Name = "buildIndex";
            this.buildIndex.Size = new System.Drawing.Size(309, 46);
            this.buildIndex.TabIndex = 1;
            this.buildIndex.Text = ">>Initialize Search Engine";
            this.buildIndex.UseVisualStyleBackColor = true;
            this.buildIndex.Click += new System.EventHandler(this.button2_Click);
            // 
            // indexButton
            // 
            this.indexButton.Location = new System.Drawing.Point(674, 225);
            this.indexButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(171, 45);
            this.indexButton.TabIndex = 2;
            this.indexButton.Text = "Index Path";
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // jsonPath
            // 
            this.jsonPath.Location = new System.Drawing.Point(18, 158);
            this.jsonPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jsonPath.Name = "jsonPath";
            this.jsonPath.Size = new System.Drawing.Size(644, 35);
            this.jsonPath.TabIndex = 3;
            // 
            // showIndexPath
            // 
            this.showIndexPath.Location = new System.Drawing.Point(18, 231);
            this.showIndexPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showIndexPath.Name = "showIndexPath";
            this.showIndexPath.Size = new System.Drawing.Size(644, 35);
            this.showIndexPath.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 374);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(644, 35);
            this.textBox3.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(675, 368);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(170, 45);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(18, 802);
            this.ExitApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(166, 50);
            this.ExitApp.TabIndex = 7;
            this.ExitApp.Text = "EXIT";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // ResulttView
            // 
            this.ResulttView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ResulttView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rank,
            this.score,
            this.URL,
            this.result});
            this.ResulttView.FullRowSelect = true;
            this.ResulttView.HideSelection = false;
            this.ResulttView.Location = new System.Drawing.Point(874, 18);
            this.ResulttView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResulttView.Name = "ResulttView";
            this.ResulttView.Size = new System.Drawing.Size(1188, 832);
            this.ResulttView.TabIndex = 8;
            this.ResulttView.UseCompatibleStateImageBehavior = false;
            this.ResulttView.View = System.Windows.Forms.View.Details;
            this.ResulttView.SelectedIndexChanged += new System.EventHandler(this.ResulttView_SelectedIndexChanged);
            // 
            // rank
            // 
            this.rank.Text = "rank";
            this.rank.Width = 89;
            // 
            // score
            // 
            this.score.Text = "score";
            this.score.Width = 90;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 79;
            // 
            // result
            // 
            this.result.Text = "result";
            this.result.Width = 681;
            // 
            // SaveResults
            // 
            this.SaveResults.Location = new System.Drawing.Point(675, 802);
            this.SaveResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveResults.Name = "SaveResults";
            this.SaveResults.Size = new System.Drawing.Size(168, 50);
            this.SaveResults.TabIndex = 9;
            this.SaveResults.Text = "Save Results";
            this.SaveResults.UseVisualStyleBackColor = true;
            this.SaveResults.Click += new System.EventHandler(this.SaveResults_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 90);
            this.label1.TabIndex = 11;
            this.label1.Text = "One Search";
            // 
            // FinalWord
            // 
            this.FinalWord.AutoSize = true;
            this.FinalWord.Location = new System.Drawing.Point(18, 538);
            this.FinalWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalWord.Name = "FinalWord";
            this.FinalWord.Size = new System.Drawing.Size(226, 24);
            this.FinalWord.TabIndex = 12;
            this.FinalWord.Text = "Final search word:";
            // 
            // TotalResult
            // 
            this.TotalResult.AutoSize = true;
            this.TotalResult.Location = new System.Drawing.Point(18, 628);
            this.TotalResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(178, 24);
            this.TotalResult.TabIndex = 13;
            this.TotalResult.Text = "Total Results:";
            // 
            // FinalWordBox
            // 
            this.FinalWordBox.Location = new System.Drawing.Point(18, 568);
            this.FinalWordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinalWordBox.Name = "FinalWordBox";
            this.FinalWordBox.Size = new System.Drawing.Size(644, 35);
            this.FinalWordBox.TabIndex = 14;
            // 
            // TotalResultBox
            // 
            this.TotalResultBox.Location = new System.Drawing.Point(18, 658);
            this.TotalResultBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalResultBox.Name = "TotalResultBox";
            this.TotalResultBox.Size = new System.Drawing.Size(148, 35);
            this.TotalResultBox.TabIndex = 15;
            // 
            // AsIsBox
            // 
            this.AsIsBox.AutoSize = true;
            this.AsIsBox.Location = new System.Drawing.Point(20, 434);
            this.AsIsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AsIsBox.Name = "AsIsBox";
            this.AsIsBox.Size = new System.Drawing.Size(186, 28);
            this.AsIsBox.TabIndex = 16;
            this.AsIsBox.Text = "Search As-Is";
            this.AsIsBox.UseVisualStyleBackColor = true;
            this.AsIsBox.CheckedChanged += new System.EventHandler(this.AsIsBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2082, 870);
            this.Controls.Add(this.AsIsBox);
            this.Controls.Add(this.TotalResultBox);
            this.Controls.Add(this.FinalWordBox);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.FinalWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveResults);
            this.Controls.Add(this.ResulttView);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.showIndexPath);
            this.Controls.Add(this.jsonPath);
            this.Controls.Add(this.indexButton);
            this.Controls.Add(this.buildIndex);
            this.Controls.Add(this.jsonButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "OneSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListView ResulttView;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.ColumnHeader result;
        private System.Windows.Forms.Button SaveResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FinalWord;
        private System.Windows.Forms.Label TotalResult;
        private System.Windows.Forms.TextBox FinalWordBox;
        private System.Windows.Forms.TextBox TotalResultBox;
        private System.Windows.Forms.CheckBox AsIsBox;
        private System.Windows.Forms.ColumnHeader URL;
    }
}

