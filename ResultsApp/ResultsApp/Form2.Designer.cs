namespace ResultsApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.xmlButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject1ScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject2ScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject3ScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.classNumberDataGridViewTextBoxColumn,
            this.groupCodeDataGridViewTextBoxColumn,
            this.subject1ScoreDataGridViewTextBoxColumn,
            this.subject2ScoreDataGridViewTextBoxColumn,
            this.subject3ScoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(778, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Computing";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(778, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Business";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show Group";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(778, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Advanced";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xmlButton
            // 
            this.xmlButton.Location = new System.Drawing.Point(781, 347);
            this.xmlButton.Name = "xmlButton";
            this.xmlButton.Size = new System.Drawing.Size(75, 37);
            this.xmlButton.TabIndex = 6;
            this.xmlButton.Text = "Generate XML File";
            this.xmlButton.UseVisualStyleBackColor = true;
            this.xmlButton.Click += new System.EventHandler(this.xmlButton_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "registrationNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "registrationNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "studentName";
            this.dataGridViewTextBoxColumn3.HeaderText = "studentName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // classNumberDataGridViewTextBoxColumn
            // 
            this.classNumberDataGridViewTextBoxColumn.DataPropertyName = "classNumber";
            this.classNumberDataGridViewTextBoxColumn.HeaderText = "classNumber";
            this.classNumberDataGridViewTextBoxColumn.Name = "classNumberDataGridViewTextBoxColumn";
            this.classNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupCodeDataGridViewTextBoxColumn
            // 
            this.groupCodeDataGridViewTextBoxColumn.DataPropertyName = "groupCode";
            this.groupCodeDataGridViewTextBoxColumn.HeaderText = "groupCode";
            this.groupCodeDataGridViewTextBoxColumn.Name = "groupCodeDataGridViewTextBoxColumn";
            this.groupCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subject1ScoreDataGridViewTextBoxColumn
            // 
            this.subject1ScoreDataGridViewTextBoxColumn.DataPropertyName = "subject1Score";
            this.subject1ScoreDataGridViewTextBoxColumn.HeaderText = "subject1Score";
            this.subject1ScoreDataGridViewTextBoxColumn.Name = "subject1ScoreDataGridViewTextBoxColumn";
            this.subject1ScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subject2ScoreDataGridViewTextBoxColumn
            // 
            this.subject2ScoreDataGridViewTextBoxColumn.DataPropertyName = "subject2Score";
            this.subject2ScoreDataGridViewTextBoxColumn.HeaderText = "subject2Score";
            this.subject2ScoreDataGridViewTextBoxColumn.Name = "subject2ScoreDataGridViewTextBoxColumn";
            this.subject2ScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subject3ScoreDataGridViewTextBoxColumn
            // 
            this.subject3ScoreDataGridViewTextBoxColumn.DataPropertyName = "subject3Score";
            this.subject3ScoreDataGridViewTextBoxColumn.HeaderText = "subject3Score";
            this.subject3ScoreDataGridViewTextBoxColumn.Name = "subject3ScoreDataGridViewTextBoxColumn";
            this.subject3ScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(ResultsApp.Student);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 407);
            this.Controls.Add(this.xmlButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Search...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button xmlButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject1ScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject2ScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject3ScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}