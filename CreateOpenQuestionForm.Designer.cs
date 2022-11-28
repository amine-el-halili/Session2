namespace Session2
{
    partial class CreateOpenQuestionForm
    {
        int cmbbox_change_count = 0;
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
            this.richTextBox_openQuestion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox_openQuestion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addOpenQuestion = new System.Windows.Forms.Button();
            this.btn_cancelOpenQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_openQuestion
            // 
            this.richTextBox_openQuestion.Location = new System.Drawing.Point(124, 44);
            this.richTextBox_openQuestion.Name = "richTextBox_openQuestion";
            this.richTextBox_openQuestion.Size = new System.Drawing.Size(222, 83);
            this.richTextBox_openQuestion.TabIndex = 0;
            this.richTextBox_openQuestion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statement";
            // 
            // txtBox_Note
            // 
            this.txtBox_Note.Location = new System.Drawing.Point(124, 157);
            this.txtBox_Note.Name = "txtBox_Note";
            this.txtBox_Note.Size = new System.Drawing.Size(222, 27);
            this.txtBox_Note.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note";
            // 
            // cmbBox_openQuestion
            // 
            this.cmbBox_openQuestion.FormattingEnabled = true;
            this.cmbBox_openQuestion.Location = new System.Drawing.Point(527, 44);
            this.cmbBox_openQuestion.Name = "cmbBox_openQuestion";
            this.cmbBox_openQuestion.Size = new System.Drawing.Size(246, 28);
            this.cmbBox_openQuestion.TabIndex = 4;
            this.cmbBox_openQuestion.SelectedIndexChanged += new System.EventHandler(this.cmbBox_openQuestion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exist questions";
            // 
            // btn_addOpenQuestion
            // 
            this.btn_addOpenQuestion.Location = new System.Drawing.Point(403, 363);
            this.btn_addOpenQuestion.Name = "btn_addOpenQuestion";
            this.btn_addOpenQuestion.Size = new System.Drawing.Size(127, 35);
            this.btn_addOpenQuestion.TabIndex = 6;
            this.btn_addOpenQuestion.Text = "Add";
            this.btn_addOpenQuestion.UseVisualStyleBackColor = true;
            this.btn_addOpenQuestion.Click += new System.EventHandler(this.btn_addOpenQuestion_Click);
            // 
            // btn_cancelOpenQuestion
            // 
            this.btn_cancelOpenQuestion.Location = new System.Drawing.Point(592, 363);
            this.btn_cancelOpenQuestion.Name = "btn_cancelOpenQuestion";
            this.btn_cancelOpenQuestion.Size = new System.Drawing.Size(127, 35);
            this.btn_cancelOpenQuestion.TabIndex = 7;
            this.btn_cancelOpenQuestion.Text = "Cancel";
            this.btn_cancelOpenQuestion.UseVisualStyleBackColor = true;
            this.btn_cancelOpenQuestion.Click += new System.EventHandler(this.btn_cancelOpenQuestion_Click);
            // 
            // CreateOpenQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelOpenQuestion);
            this.Controls.Add(this.btn_addOpenQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBox_openQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_openQuestion);
            this.Name = "CreateOpenQuestionForm";
            this.Text = "CreateOpenQuestionForm";
            this.Load += new System.EventHandler(this.CreateOpenQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox_openQuestion;
        private Label label1;
        private TextBox txtBox_Note;
        private Label label2;
        private ComboBox cmbBox_openQuestion;
        private Label label3;
        private Button btn_addOpenQuestion;
        private Button btn_cancelOpenQuestion;
    }
}