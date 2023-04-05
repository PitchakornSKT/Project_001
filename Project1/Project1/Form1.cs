namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.formDiagnostic1.Visible = false;
            this.formInformation1.Visible = false;
            this.label2.Text = "หน้าหลัก";
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            this.formDiagnostic1.Visible = true;
            this.formInformation1.Visible = false;
            this.label2.Text = "การพยากรณ์โรคหัวใจ";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.formInformation1.Visible = true;
            this.formDiagnostic1.Visible=false;
            this.label2.Text = "ข้อมูลคนไข้";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void formDiagnostic1_Load(object sender, EventArgs e)
        {

        }
    }
}