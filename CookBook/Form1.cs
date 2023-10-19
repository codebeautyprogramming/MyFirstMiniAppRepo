namespace CookBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GreetUserBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;

            string message = "Welcome, " + firstName + " " + lastName;
            MessageBox.Show(message);
        }

      
    }
}