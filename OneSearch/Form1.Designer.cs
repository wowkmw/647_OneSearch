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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SpellCheckB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonButton
            // 
            this.jsonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.jsonButton.FlatAppearance.BorderSize = 0;
            this.jsonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.jsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jsonButton.Image = ((System.Drawing.Image)(resources.GetObject("jsonButton.Image")));
            this.jsonButton.Location = new System.Drawing.Point(457, 241);
            this.jsonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(115, 41);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.Text = "Load";
            this.jsonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.jsonButton.UseVisualStyleBackColor = false;
            this.jsonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buildIndex
            // 
            this.buildIndex.BackColor = System.Drawing.Color.Gray;
            this.buildIndex.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buildIndex.FlatAppearance.BorderSize = 0;
            this.buildIndex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(230)))));
            this.buildIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildIndex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buildIndex.Image = ((System.Drawing.Image)(resources.GetObject("buildIndex.Image")));
            this.buildIndex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildIndex.Location = new System.Drawing.Point(201, 369);
            this.buildIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildIndex.Name = "buildIndex";
            this.buildIndex.Size = new System.Drawing.Size(143, 41);
            this.buildIndex.TabIndex = 1;
            this.buildIndex.Text = "Create Index";
            this.buildIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildIndex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buildIndex.UseVisualStyleBackColor = false;
            this.buildIndex.Click += new System.EventHandler(this.button2_Click);
            // 
            // indexButton
            // 
            this.indexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.indexButton.FlatAppearance.BorderSize = 0;
            this.indexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.indexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.indexButton.Image = ((System.Drawing.Image)(resources.GetObject("indexButton.Image")));
            this.indexButton.Location = new System.Drawing.Point(457, 313);
            this.indexButton.Margin = new System.Windows.Forms.Padding(0);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(115, 41);
            this.indexButton.TabIndex = 2;
            this.indexButton.Text = "Save";
            this.indexButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.indexButton.UseVisualStyleBackColor = false;
            this.indexButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // jsonPath
            // 
            this.jsonPath.Location = new System.Drawing.Point(27, 241);
            this.jsonPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jsonPath.Multiline = true;
            this.jsonPath.Name = "jsonPath";
            this.jsonPath.Size = new System.Drawing.Size(431, 41);
            this.jsonPath.TabIndex = 3;
            // 
            // showIndexPath
            // 
            this.showIndexPath.Location = new System.Drawing.Point(27, 313);
            this.showIndexPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showIndexPath.Multiline = true;
            this.showIndexPath.Name = "showIndexPath";
            this.showIndexPath.Size = new System.Drawing.Size(431, 41);
            this.showIndexPath.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 597);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(431, 41);
            this.textBox3.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(87)))), ((int)(((byte)(38)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(457, 597);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 41);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(74)))));
            this.ExitApp.FlatAppearance.BorderSize = 0;
            this.ExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitApp.Image = ((System.Drawing.Image)(resources.GetObject("ExitApp.Image")));
            this.ExitApp.Location = new System.Drawing.Point(735, 731);
            this.ExitApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(125, 41);
            this.ExitApp.TabIndex = 7;
            this.ExitApp.Text = "EXIT";
            this.ExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitApp.UseVisualStyleBackColor = false;
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
            this.ResulttView.Location = new System.Drawing.Point(67, 172);
            this.ResulttView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResulttView.Name = "ResulttView";
            this.ResulttView.Size = new System.Drawing.Size(793, 548);
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
            this.SaveResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(87)))), ((int)(((byte)(38)))));
            this.SaveResults.FlatAppearance.BorderSize = 0;
            this.SaveResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaveResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveResults.Image = ((System.Drawing.Image)(resources.GetObject("SaveResults.Image")));
            this.SaveResults.Location = new System.Drawing.Point(511, 731);
            this.SaveResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveResults.Name = "SaveResults";
            this.SaveResults.Size = new System.Drawing.Size(176, 41);
            this.SaveResults.TabIndex = 9;
            this.SaveResults.Text = "Save Results";
            this.SaveResults.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveResults.UseVisualStyleBackColor = false;
            this.SaveResults.Click += new System.EventHandler(this.SaveResults_Click);
            // 
            // FinalWord
            // 
            this.FinalWord.AutoSize = true;
            this.FinalWord.BackColor = System.Drawing.Color.Transparent;
            this.FinalWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FinalWord.Location = new System.Drawing.Point(64, 44);
            this.FinalWord.Name = "FinalWord";
            this.FinalWord.Size = new System.Drawing.Size(196, 17);
            this.FinalWord.TabIndex = 12;
            this.FinalWord.Text = "Your final search word(s):";
            // 
            // TotalResult
            // 
            this.TotalResult.AutoSize = true;
            this.TotalResult.BackColor = System.Drawing.Color.Transparent;
            this.TotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalResult.ForeColor = System.Drawing.Color.Yellow;
            this.TotalResult.Location = new System.Drawing.Point(64, 103);
            this.TotalResult.Name = "TotalResult";
            this.TotalResult.Size = new System.Drawing.Size(109, 17);
            this.TotalResult.TabIndex = 13;
            this.TotalResult.Text = "Total Results:";
            // 
            // FinalWordBox
            // 
            this.FinalWordBox.Location = new System.Drawing.Point(275, 23);
            this.FinalWordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinalWordBox.Multiline = true;
            this.FinalWordBox.Name = "FinalWordBox";
            this.FinalWordBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FinalWordBox.Size = new System.Drawing.Size(585, 60);
            this.FinalWordBox.TabIndex = 14;
            this.FinalWordBox.TextChanged += new System.EventHandler(this.FinalWordBox_TextChanged);
            // 
            // TotalResultBox
            // 
            this.TotalResultBox.Location = new System.Drawing.Point(67, 123);
            this.TotalResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalResultBox.Multiline = true;
            this.TotalResultBox.Name = "TotalResultBox";
            this.TotalResultBox.Size = new System.Drawing.Size(106, 24);
            this.TotalResultBox.TabIndex = 15;
            // 
            // AsIsBox
            // 
            this.AsIsBox.AutoSize = true;
            this.AsIsBox.Location = new System.Drawing.Point(269, 664);
            this.AsIsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.JsonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JsonS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JsonS.Location = new System.Drawing.Point(629, 103);
            this.JsonS.Name = "JsonS";
            this.JsonS.Size = new System.Drawing.Size(67, 17);
            this.JsonS.TabIndex = 17;
            this.JsonS.Text = "Json(s):";
            // 
            // IndexS
            // 
            this.IndexS.AutoSize = true;
            this.IndexS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IndexS.Location = new System.Drawing.Point(757, 103);
            this.IndexS.Name = "IndexS";
            this.IndexS.Size = new System.Drawing.Size(71, 17);
            this.IndexS.TabIndex = 18;
            this.IndexS.Text = "Index(s):";
            // 
            // SearchS
            // 
            this.SearchS.AutoSize = true;
            this.SearchS.BackColor = System.Drawing.Color.Transparent;
            this.SearchS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchS.Location = new System.Drawing.Point(508, 103);
            this.SearchS.Name = "SearchS";
            this.SearchS.Size = new System.Drawing.Size(84, 17);
            this.SearchS.TabIndex = 19;
            this.SearchS.Text = "Search(s):";
            // 
            // JsonBS
            // 
            this.JsonBS.Location = new System.Drawing.Point(632, 123);
            this.JsonBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JsonBS.Multiline = true;
            this.JsonBS.Name = "JsonBS";
            this.JsonBS.Size = new System.Drawing.Size(100, 24);
            this.JsonBS.TabIndex = 20;
            // 
            // IndexBS
            // 
            this.IndexBS.Location = new System.Drawing.Point(760, 123);
            this.IndexBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IndexBS.Name = "IndexBS";
            this.IndexBS.Size = new System.Drawing.Size(100, 23);
            this.IndexBS.TabIndex = 21;
            // 
            // SearchBS
            // 
            this.SearchBS.Location = new System.Drawing.Point(511, 123);
            this.SearchBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBS.Multiline = true;
            this.SearchBS.Name = "SearchBS";
            this.SearchBS.Size = new System.Drawing.Size(100, 24);
            this.SearchBS.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 158);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(27, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 71);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 578);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type your query:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 665);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select different types of searches:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.TotalResult);
            this.panel1.Controls.Add(this.SearchS);
            this.panel1.Controls.Add(this.SearchBS);
            this.panel1.Controls.Add(this.TotalResultBox);
            this.panel1.Controls.Add(this.FinalWordBox);
            this.panel1.Controls.Add(this.SaveResults);
            this.panel1.Controls.Add(this.ExitApp);
            this.panel1.Controls.Add(this.IndexBS);
            this.panel1.Controls.Add(this.JsonBS);
            this.panel1.Controls.Add(this.ResulttView);
            this.panel1.Controls.Add(this.FinalWord);
            this.panel1.Controls.Add(this.IndexS);
            this.panel1.Controls.Add(this.JsonS);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(601, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 785);
            this.panel1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(67, 731);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 16);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "*Click on the row rank to see the complete passage.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Select file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Select index path:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(1, 539);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 4);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(201, 717);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 4);
            this.panel3.TabIndex = 32;
            // 
            // SpellCheckB
            // 
            this.SpellCheckB.AutoSize = true;
            this.SpellCheckB.Location = new System.Drawing.Point(416, 664);
            this.SpellCheckB.Name = "SpellCheckB";
            this.SpellCheckB.Size = new System.Drawing.Size(104, 21);
            this.SpellCheckB.TabIndex = 33;
            this.SpellCheckB.Text = "Spell Check";
            this.SpellCheckB.UseVisualStyleBackColor = true;
            this.SpellCheckB.CheckedChanged += new System.EventHandler(this.SpellCheckB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tomato;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(23, 740);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "About";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1521, 786);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpellCheckB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AsIsBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.showIndexPath);
            this.Controls.Add(this.jsonPath);
            this.Controls.Add(this.indexButton);
            this.Controls.Add(this.buildIndex);
            this.Controls.Add(this.jsonButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OneSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox SpellCheckB;
        private System.Windows.Forms.Label label5;
    }
}

