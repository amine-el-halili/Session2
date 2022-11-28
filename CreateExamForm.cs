using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class CreateExamForm : Form
    {
        Exam exam;
        List<Question> questions = new List<Question>();
        public CreateExamForm()
        {
            InitializeComponent();
        }

        private void CreateExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void btn_cancelExam_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            this.Close();
        }

        private void btn_addOpenQuestion_Click(object sender, EventArgs e)
        {
            CreateOpenQuestionForm frm = new CreateOpenQuestionForm();
            frm.Show(this);
            this.Enabled = false;
        }
    }
}
