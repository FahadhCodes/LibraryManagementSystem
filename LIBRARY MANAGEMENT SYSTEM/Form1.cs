namespace LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Admin" && textBox2.Text=="Fhd@2948")
            {
                this.DialogResult = DialogResult.OK; // SIGNAL success
                this.Close();
            }
            else
            {
                MessageBox.Show("Username Or password is incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
