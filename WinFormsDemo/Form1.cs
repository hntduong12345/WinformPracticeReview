namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to my application");
            btn_PlayAgain.Enabled = false;
            btn_NewRound.Enabled = false;
            btn_Close.Enabled = false;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            btn_PlayAgain.Enabled = true;
            btn_NewRound.Enabled = true;
            btn_Close.Enabled = true;
        }
    }
}
