using System.Text.RegularExpressions;

namespace ValidatingPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifying_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
            bool hasLowercase = Regex.IsMatch(password, "[a-z]");
            bool hasNumber = Regex.IsMatch(password, "[\\d]");
            bool hasChars = Regex.IsMatch(password, "[^a-zA-Z0-9]");

            if (password.Length >= 8 && hasUppercase && hasLowercase && hasNumber && hasChars)
            {
                lblMessages.Text = "You Entered a Valid Password";
            }
            else
            {
                lblMessages.Text = "!Error: Enter a Valid Password";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
