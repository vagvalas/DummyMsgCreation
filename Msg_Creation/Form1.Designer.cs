namespace Msg_Creation
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_generate = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_outputDirectory = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_selectCSV = new System.Windows.Forms.Button();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_OutputFolder = new System.Windows.Forms.Label();
            this.lbl_selectCSV = new System.Windows.Forms.Label();
            this.txtb_from_email = new System.Windows.Forms.TextBox();
            this.txtb_from_name = new System.Windows.Forms.TextBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_displayed_name = new System.Windows.Forms.Label();
            this.lbl_to_recipient = new System.Windows.Forms.Label();
            this.txtb_to_email = new System.Windows.Forms.TextBox();
            this.txtb_to_name = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.txtb_subject = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rich_txtb_body = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(710, 119);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.btnSelectRange_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(710, 161);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.btnSelectRange_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(810, 439);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_outputDirectory
            // 
            this.btn_outputDirectory.Location = new System.Drawing.Point(616, 393);
            this.btn_outputDirectory.Name = "btn_outputDirectory";
            this.btn_outputDirectory.Size = new System.Drawing.Size(116, 23);
            this.btn_outputDirectory.TabIndex = 3;
            this.btn_outputDirectory.Text = "Browse Output Dir";
            this.btn_outputDirectory.UseVisualStyleBackColor = true;
            this.btn_outputDirectory.Click += new System.EventHandler(this.outDirectory_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_selectCSV
            // 
            this.btn_selectCSV.Location = new System.Drawing.Point(136, 389);
            this.btn_selectCSV.Name = "btn_selectCSV";
            this.btn_selectCSV.Size = new System.Drawing.Size(75, 23);
            this.btn_selectCSV.TabIndex = 4;
            this.btn_selectCSV.Text = "Select CSV";
            this.btn_selectCSV.UseVisualStyleBackColor = true;
            this.btn_selectCSV.Click += new System.EventHandler(this.selectCSV_Click);
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(634, 125);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(70, 15);
            this.lbl_startDate.TabIndex = 5;
            this.lbl_startDate.Text = "1. Start Date";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(634, 167);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(66, 15);
            this.lbl_endDate.TabIndex = 6;
            this.lbl_endDate.Text = "2. End Date";
            // 
            // lbl_OutputFolder
            // 
            this.lbl_OutputFolder.AutoSize = true;
            this.lbl_OutputFolder.Location = new System.Drawing.Point(517, 397);
            this.lbl_OutputFolder.Name = "lbl_OutputFolder";
            this.lbl_OutputFolder.Size = new System.Drawing.Size(93, 15);
            this.lbl_OutputFolder.TabIndex = 7;
            this.lbl_OutputFolder.Text = "3. Output Folder";
            // 
            // lbl_selectCSV
            // 
            this.lbl_selectCSV.AutoSize = true;
            this.lbl_selectCSV.Location = new System.Drawing.Point(32, 393);
            this.lbl_selectCSV.Name = "lbl_selectCSV";
            this.lbl_selectCSV.Size = new System.Drawing.Size(98, 15);
            this.lbl_selectCSV.TabIndex = 8;
            this.lbl_selectCSV.Text = "4. Select Info CSV";
            // 
            // txtb_from_email
            // 
            this.txtb_from_email.Location = new System.Drawing.Point(93, 37);
            this.txtb_from_email.Name = "txtb_from_email";
            this.txtb_from_email.Size = new System.Drawing.Size(100, 23);
            this.txtb_from_email.TabIndex = 9;
            // 
            // txtb_from_name
            // 
            this.txtb_from_name.Location = new System.Drawing.Point(223, 37);
            this.txtb_from_name.Name = "txtb_from_name";
            this.txtb_from_name.Size = new System.Drawing.Size(100, 23);
            this.txtb_from_name.TabIndex = 10;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(11, 40);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(76, 15);
            this.lbl_from.TabIndex = 11;
            this.lbl_from.Text = "From/Sender";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(123, 19);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email";
            // 
            // lbl_displayed_name
            // 
            this.lbl_displayed_name.AutoSize = true;
            this.lbl_displayed_name.Location = new System.Drawing.Point(223, 19);
            this.lbl_displayed_name.Name = "lbl_displayed_name";
            this.lbl_displayed_name.Size = new System.Drawing.Size(93, 15);
            this.lbl_displayed_name.TabIndex = 13;
            this.lbl_displayed_name.Text = "Displayed Name";
            // 
            // lbl_to_recipient
            // 
            this.lbl_to_recipient.AutoSize = true;
            this.lbl_to_recipient.Location = new System.Drawing.Point(13, 74);
            this.lbl_to_recipient.Name = "lbl_to_recipient";
            this.lbl_to_recipient.Size = new System.Drawing.Size(74, 15);
            this.lbl_to_recipient.TabIndex = 14;
            this.lbl_to_recipient.Text = "To/Recipient";
            // 
            // txtb_to_email
            // 
            this.txtb_to_email.Location = new System.Drawing.Point(93, 71);
            this.txtb_to_email.Name = "txtb_to_email";
            this.txtb_to_email.Size = new System.Drawing.Size(100, 23);
            this.txtb_to_email.TabIndex = 15;
            // 
            // txtb_to_name
            // 
            this.txtb_to_name.Location = new System.Drawing.Point(223, 71);
            this.txtb_to_name.Name = "txtb_to_name";
            this.txtb_to_name.Size = new System.Drawing.Size(100, 23);
            this.txtb_to_name.TabIndex = 16;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(49, 103);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(46, 15);
            this.lbl_subject.TabIndex = 17;
            this.lbl_subject.Text = "Subject";
            // 
            // txtb_subject
            // 
            this.txtb_subject.Location = new System.Drawing.Point(93, 100);
            this.txtb_subject.Name = "txtb_subject";
            this.txtb_subject.Size = new System.Drawing.Size(230, 23);
            this.txtb_subject.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Main Body";
            // 
            // rich_txtb_body
            // 
            this.rich_txtb_body.Location = new System.Drawing.Point(93, 161);
            this.rich_txtb_body.Name = "rich_txtb_body";
            this.rich_txtb_body.Size = new System.Drawing.Size(429, 187);
            this.rich_txtb_body.TabIndex = 20;
            this.rich_txtb_body.Text = "";
            this.rich_txtb_body.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxBody_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 556);
            this.Controls.Add(this.rich_txtb_body);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtb_subject);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.txtb_to_name);
            this.Controls.Add(this.txtb_to_email);
            this.Controls.Add(this.lbl_to_recipient);
            this.Controls.Add(this.lbl_displayed_name);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.txtb_from_name);
            this.Controls.Add(this.txtb_from_email);
            this.Controls.Add(this.lbl_selectCSV);
            this.Controls.Add(this.lbl_OutputFolder);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.btn_selectCSV);
            this.Controls.Add(this.btn_outputDirectory);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btn_generate;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_outputDirectory;
        private OpenFileDialog openFileDialog1;
        private Button btn_selectCSV;
        private Label lbl_startDate;
        private Label lbl_endDate;
        private Label lbl_OutputFolder;
        private Label lbl_selectCSV;
        private Label lbl_from;
        private Label lbl_email;
        private Label lbl_displayed_name;
        private Label lbl_to_recipient;
        private Label lbl_subject;
        private Label label10;
        private TextBox txtb_from_email;
        private TextBox txtb_from_name;
        private TextBox txtb_to_email;
        private TextBox txtb_to_name;
        private TextBox txtb_subject;
        private RichTextBox rich_txtb_body;
    }
}