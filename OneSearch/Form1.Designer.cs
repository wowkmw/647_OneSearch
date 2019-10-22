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
            this.FinalWord = new System.Windows.Forms.Label();
            this.TotalResult = new System.Windows.Forms.Label();
            this.FinalWordBox = new System.Windows.Forms.TextBox();
            this.TotalResultBox = new System.Windows.Forms.TextBox();
            this.AsIsBox = new System.Windows.Forms.CheckBox();
            this.JsonS = new System.Windows.Forms.Label();
            this.IndexS = new System.Windows.Forms.Label();
            this.SearchS = new System.Windows.Forms.Label();
            this.JsonBS = new System.Windows.Forms.TextBox();
            this.IndexBS = new System.Windows.Forms.TextBox();
            this.SearchBS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(449, 124);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(114, 29);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.Text = "JSON Path";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buildIndex
            // 
            this.buildIndex.BackColor = System.Drawing.SystemColors.Control;
            this.buildIndex.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buildIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildIndex.Location = new System.Drawing.Point(93, 220);
            this.buildIndex.Name = "buildIndex";
            this.buildIndex.Size = new System.Drawing.Size(275, 46);
            this.buildIndex.TabIndex = 1;
            this.buildIndex.Text = ">>> Initialize Search Engine";
            this.buildIndex.UseVisualStyleBackColor = false;
            this.buildIndex.Click += new System.EventHandler(this.button2_Click);
            // 
            // indexButton
            // 
            this.indexButton.Location = new System.Drawing.Point(449, 172);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(114, 30);
            this.indexButton.TabIndex = 2;
            this.indexButton.Text = "Index Path";
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // jsonPath
            // 
            this.jsonPath.Location = new System.Drawing.Point(12, 127);
            this.jsonPath.Name = "jsonPath";
            this.jsonPath.Size = new System.Drawing.Size(431, 22);
            this.jsonPath.TabIndex = 3;
            // 
            // showIndexPath
            // 
            this.showIndexPath.Location = new System.Drawing.Point(12, 176);
            this.showIndexPath.Name = "showIndexPath";
            this.showIndexPath.Size = new System.Drawing.Size(431, 22);
            this.showIndexPath.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(431, 22);
            this.textBox3.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(449, 284);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 30);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(12, 535);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(111, 33);
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
            this.ResulttView.Location = new System.Drawing.Point(583, 12);
            this.ResulttView.Name = "ResulttView";
            this.ResulttView.Size = new System.Drawing.Size(793, 556);
            this.ResulttView.TabIndex = 8;
            this.ResulttView.UseCompatibleStateImageBehavior = false;
            this.ResulttView.View = System.Windows.Forms.View.Details;
            this.ResulttView.SelectedIndexChanged += new System.EventHandler(this.ResulttView_SelectedIndexChanged);
            // 
            // rank
            // 
            this.rank.Text = "rank";
            this.rank.Width = 50;
            // 
            // score
            // 
            this.score.Text = "score";
            this.score.Width = 70;
            // 
            // URL
            // 
            this.URL.Text = "url";
            this.URL.Width = 258;
            // 
            // result
            // 
            this.result.Text = "result";
            this.result.Width = 409;
            // 
            // SaveResults
            // 
            this.SaveResults.Location = new System.Drawing.Point(450, 535);
            this.SaveResults.Name = "SaveResults";
            this.SaveResults.Size = new System.Drawing.Size(112, 33);
            this.SaveResults.TabIndex = 9;
            this.SaveResults.Text = "Save Results";
            this.SaveResults.UseVisualStyleBackColor = true;
            this.SaveResults.Click += new System.EventHandler(this.SaveResults_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FinalWord
            // 
            this.FinalWord.AutoSize = true;
            this.FinalWord.Location = new System.Drawing.Point(12, 372);
            this.FinalWord.Name = "FinalWord";
            this.FinalWord.Size = new System.Drawing.Size(129, 17);
            this.FinalWord.TabIndex = 12;
            this.FinalWord.Text = "Final Search Word:";
            // 
            // TotalResult
            // 
            this.TotalResult.AutoSize = true;
            this.TotalResult.Location = new System.Drawing.Point(12, 455);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(95, 17);
            this.TotalResult.TabIndex = 13;
            this.TotalResult.Text = "Total Results:";
            // 
            // FinalWordBox
            // 
            this.FinalWordBox.Location = new System.Drawing.Point(12, 392);
            this.FinalWordBox.Name = "FinalWordBox";
            this.FinalWordBox.Size = new System.Drawing.Size(431, 22);
            this.FinalWordBox.TabIndex = 14;
            // 
            // TotalResultBox
            // 
            this.TotalResultBox.Location = new System.Drawing.Point(12, 475);
            this.TotalResultBox.Name = "TotalResultBox";
            this.TotalResultBox.Size = new System.Drawing.Size(100, 22);
            this.TotalResultBox.TabIndex = 15;
            // 
            // AsIsBox
            // 
            this.AsIsBox.AutoSize = true;
            this.AsIsBox.Location = new System.Drawing.Point(12, 328);
            this.AsIsBox.Name = "AsIsBox";
            this.AsIsBox.Size = new System.Drawing.Size(110, 21);
            this.AsIsBox.TabIndex = 16;
            this.AsIsBox.Text = "Search As-Is";
            this.AsIsBox.UseVisualStyleBackColor = true;
            this.AsIsBox.CheckedChanged += new System.EventHandler(this.AsIsBox_CheckedChanged);
            // 
            // JsonS
            // 
            this.JsonS.AutoSize = true;
            this.JsonS.Location = new System.Drawing.Point(283, 455);
            this.JsonS.Name = "JsonS";
            this.JsonS.Size = new System.Drawing.Size(59, 17);
            this.JsonS.TabIndex = 17;
            this.JsonS.Text = "Json(s):";
            // 
            // IndexS
            // 
            this.IndexS.AutoSize = true;
            this.IndexS.Location = new System.Drawing.Point(422, 455);
            this.IndexS.Name = "IndexS";
            this.IndexS.Size = new System.Drawing.Size(62, 17);
            this.IndexS.TabIndex = 18;
            this.IndexS.Text = "Index(s):";
            // 
            // SearchS
            // 
            this.SearchS.AutoSize = true;
            this.SearchS.Location = new System.Drawing.Point(144, 455);
            this.SearchS.Name = "SearchS";
            this.SearchS.Size = new System.Drawing.Size(74, 17);
            this.SearchS.TabIndex = 19;
            this.SearchS.Text = "Search(s):";
            // 
            // JsonBS
            // 
            this.JsonBS.Location = new System.Drawing.Point(286, 475);
            this.JsonBS.Name = "JsonBS";
            this.JsonBS.Size = new System.Drawing.Size(100, 22);
            this.JsonBS.TabIndex = 20;
            // 
            // IndexBS
            // 
            this.IndexBS.Location = new System.Drawing.Point(425, 475);
            this.IndexBS.Name = "IndexBS";
            this.IndexBS.Size = new System.Drawing.Size(100, 22);
            this.IndexBS.TabIndex = 21;
            // 
            // SearchBS
            // 
            this.SearchBS.Location = new System.Drawing.Point(147, 475);
            this.SearchBS.Name = "SearchBS";
            this.SearchBS.Size = new System.Drawing.Size(100, 22);
            this.SearchBS.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 578);
            this.Controls.Add(this.SearchBS);
            this.Controls.Add(this.IndexBS);
            this.Controls.Add(this.JsonBS);
            this.Controls.Add(this.SearchS);
            this.Controls.Add(this.IndexS);
            this.Controls.Add(this.JsonS);
            this.Controls.Add(this.AsIsBox);
            this.Controls.Add(this.TotalResultBox);
            this.Controls.Add(this.FinalWordBox);
            this.Controls.Add(this.TotalResult);
            this.Controls.Add(this.FinalWord);
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
        private System.Windows.Forms.Label FinalWord;
        private System.Windows.Forms.Label TotalResult;
        private System.Windows.Forms.TextBox FinalWordBox;
        private System.Windows.Forms.TextBox TotalResultBox;
        private System.Windows.Forms.CheckBox AsIsBox;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.Label JsonS;
        private System.Windows.Forms.Label IndexS;
        private System.Windows.Forms.Label SearchS;
        private System.Windows.Forms.TextBox JsonBS;
        private System.Windows.Forms.TextBox IndexBS;
        private System.Windows.Forms.TextBox SearchBS;
    }
}

