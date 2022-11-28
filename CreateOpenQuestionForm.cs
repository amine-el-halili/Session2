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
    public partial class CreateOpenQuestionForm : Form
    {
        private List<OpenQuestion> questions;
        private OpenQuestion question;
        public CreateOpenQuestionForm()
        {
            InitializeComponent();
            cmbBox_openQuestion.SelectedValue = "0";
        }

        private void loadExistOpenQuestion()
        {
            questions = OpenQuestion.getAll();
            cmbBox_openQuestion.DataSource = questions;
            cmbBox_openQuestion.DisplayMember = "statement";
            cmbBox_openQuestion.ValueMember = "id";
        }

        private void btn_cancelOpenQuestion_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            this.Close();
        }

        private void CreateOpenQuestionForm_Load(object sender, EventArgs e)
        {
            loadExistOpenQuestion();
        }

        private void cmbBox_openQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_change_count++ > 1)
            {
                question = OpenQuestion.getById(int.Parse(cmbBox_openQuestion.SelectedValue.ToString()));
                richTextBox_openQuestion.Text = question.Statement;
                txtBox_Note.Text = question.Note.ToString();
            }
        }

        private void btn_addOpenQuestion_Click(object sender, EventArgs e)
        {
            question.Note = int.Parse(txtBox_Note.Text);
            question.Statement = richTextBox_openQuestion.Text;
            this.Close();
        }
    }
}
