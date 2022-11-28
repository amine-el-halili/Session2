namespace Session2
{
    partial class ExaminationForm
    {
        private List<Exam> exams;


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
            this.btn_createExam = new System.Windows.Forms.Button();
            this.cmbox_exams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_createExam
            // 
            this.btn_createExam.Location = new System.Drawing.Point(430, 122);
            this.btn_createExam.Name = "btn_createExam";
            this.btn_createExam.Size = new System.Drawing.Size(138, 29);
            this.btn_createExam.TabIndex = 0;
            this.btn_createExam.Text = "Create exam";
            this.btn_createExam.UseVisualStyleBackColor = true;
            this.btn_createExam.Click += new System.EventHandler(this.btn_createExam_Click);
            // 
            // cmbox_exams
            // 
            this.cmbox_exams.FormattingEnabled = true;
            this.cmbox_exams.Location = new System.Drawing.Point(182, 123);
            this.cmbox_exams.Name = "cmbox_exams";
            this.cmbox_exams.Size = new System.Drawing.Size(151, 28);
            this.cmbox_exams.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "list of exams";
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox_exams);
            this.Controls.Add(this.btn_createExam);
            this.Name = "ExaminationForm";
            this.Text = "Initial";
            this.Load += new System.EventHandler(this.ExaminationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_createExam;
        private ComboBox cmbox_exams;
        private Label label1;
    }
}