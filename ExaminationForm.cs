namespace Session2
{
    public partial class ExaminationForm : Form
    {
        public ExaminationForm()
        {
            InitializeComponent();
        }

        public void loadListExams()
        {
            cmbox_exams.DataSource = Exam.getALl();
            cmbox_exams.DisplayMember = "title";
            cmbox_exams.ValueMember =  "id";
        }
        private void btn_createExam_Click(object sender, EventArgs e)
        {
            var createExamForm = new CreateExamForm();
            createExamForm.Show(this);
            this.Enabled = false;
        }

        private void ExaminationForm_Load(object sender, EventArgs e)
        {
            loadListExams();
        }
    }
}
