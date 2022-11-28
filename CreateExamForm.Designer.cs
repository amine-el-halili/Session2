namespace Session2
{
    partial class CreateExamForm
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
            this.txtBox_title = new System.Windows.Forms.TextBox();
            this.txtBox_duration = new System.Windows.Forms.TextBox();
            this.datePicker_openedAt = new System.Windows.Forms.DateTimePicker();
            this.datePicker_closedAt = new System.Windows.Forms.DateTimePicker();
            this.btn_saveExam = new System.Windows.Forms.Button();
            this.btn_cancelExam = new System.Windows.Forms.Button();
            this.btn_addOpenQuestion = new System.Windows.Forms.Button();
            this.btn_addQcm = new System.Windows.Forms.Button();
            this.add_dichotomyQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_title
            // 
            this.txtBox_title.Location = new System.Drawing.Point(129, 40);
            this.txtBox_title.Name = "txtBox_title";
            this.txtBox_title.Size = new System.Drawing.Size(260, 27);
            this.txtBox_title.TabIndex = 0;
            // 
            // txtBox_duration
            // 
            this.txtBox_duration.Location = new System.Drawing.Point(129, 90);
            this.txtBox_duration.Name = "txtBox_duration";
            this.txtBox_duration.Size = new System.Drawing.Size(260, 27);
            this.txtBox_duration.TabIndex = 1;
            // 
            // datePicker_openedAt
            // 
            this.datePicker_openedAt.Location = new System.Drawing.Point(129, 136);
            this.datePicker_openedAt.Name = "datePicker_openedAt";
            this.datePicker_openedAt.Size = new System.Drawing.Size(260, 27);
            this.datePicker_openedAt.TabIndex = 2;
            // 
            // datePicker_closedAt
            // 
            this.datePicker_closedAt.Location = new System.Drawing.Point(129, 185);
            this.datePicker_closedAt.Name = "datePicker_closedAt";
            this.datePicker_closedAt.Size = new System.Drawing.Size(260, 27);
            this.datePicker_closedAt.TabIndex = 3;
            // 
            // btn_saveExam
            // 
            this.btn_saveExam.Location = new System.Drawing.Point(388, 402);
            this.btn_saveExam.Name = "btn_saveExam";
            this.btn_saveExam.Size = new System.Drawing.Size(153, 36);
            this.btn_saveExam.TabIndex = 4;
            this.btn_saveExam.Text = "Save";
            this.btn_saveExam.UseVisualStyleBackColor = true;
            // 
            // btn_cancelExam
            // 
            this.btn_cancelExam.Location = new System.Drawing.Point(572, 402);
            this.btn_cancelExam.Name = "btn_cancelExam";
            this.btn_cancelExam.Size = new System.Drawing.Size(153, 36);
            this.btn_cancelExam.TabIndex = 5;
            this.btn_cancelExam.Text = "Cancel";
            this.btn_cancelExam.UseVisualStyleBackColor = true;
            this.btn_cancelExam.Click += new System.EventHandler(this.btn_cancelExam_Click);
            // 
            // btn_addOpenQuestion
            // 
            this.btn_addOpenQuestion.Location = new System.Drawing.Point(485, 38);
            this.btn_addOpenQuestion.Name = "btn_addOpenQuestion";
            this.btn_addOpenQuestion.Size = new System.Drawing.Size(196, 31);
            this.btn_addOpenQuestion.TabIndex = 6;
            this.btn_addOpenQuestion.Text = "Add open question";
            this.btn_addOpenQuestion.UseVisualStyleBackColor = true;
            this.btn_addOpenQuestion.Click += new System.EventHandler(this.btn_addOpenQuestion_Click);
            // 
            // btn_addQcm
            // 
            this.btn_addQcm.Location = new System.Drawing.Point(485, 88);
            this.btn_addQcm.Name = "btn_addQcm";
            this.btn_addQcm.Size = new System.Drawing.Size(196, 31);
            this.btn_addQcm.TabIndex = 7;
            this.btn_addQcm.Text = "Add QCM";
            this.btn_addQcm.UseVisualStyleBackColor = true;
            // 
            // add_dichotomyQuestion
            // 
            this.add_dichotomyQuestion.Location = new System.Drawing.Point(485, 136);
            this.add_dichotomyQuestion.Name = "add_dichotomyQuestion";
            this.add_dichotomyQuestion.Size = new System.Drawing.Size(196, 31);
            this.add_dichotomyQuestion.TabIndex = 8;
            this.add_dichotomyQuestion.Text = "Add dichotomy question";
            this.add_dichotomyQuestion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "opened at";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "closed at";
            // 
            // CreateExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_dichotomyQuestion);
            this.Controls.Add(this.btn_addQcm);
            this.Controls.Add(this.btn_addOpenQuestion);
            this.Controls.Add(this.btn_cancelExam);
            this.Controls.Add(this.btn_saveExam);
            this.Controls.Add(this.datePicker_closedAt);
            this.Controls.Add(this.datePicker_openedAt);
            this.Controls.Add(this.txtBox_duration);
            this.Controls.Add(this.txtBox_title);
            this.Name = "CreateExamForm";
            this.Text = "CreateExamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateExamForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox_title;
        private TextBox txtBox_duration;
        private DateTimePicker datePicker_openedAt;
        private DateTimePicker datePicker_closedAt;
        private Button btn_saveExam;
        private Button btn_cancelExam;
        private Button btn_addOpenQuestion;
        private Button btn_addQcm;
        private Button add_dichotomyQuestion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}