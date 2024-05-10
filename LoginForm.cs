

using Microsoft.Data.SqlClient;
using System.Data;

namespace PDF_Viewer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //sqlconnection
        SqlConnection con = new SqlConnection(@"Data Source=Avaling_Hawx\SQLEXPRESS;Initial Catalog=PDFView;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e) 
        {
            string username = usernameField.Text;
            string password = passwordField.Text;

            // Check if username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password cannot be empty.");
                return;
            }

            if (username.Length < 5 || password.Length < 5)
            {
                MessageBox.Show("Username and password should be at least 5 characters long.");
                return;
            }

            //sql query
            SqlCommand cmd = new SqlCommand("select * from Login where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapt.Fill(dtable);
            con.Close();
            if(dtable.Rows.Count > 0)
            {
                username = usernameField.Text;
                password = passwordField.Text;

                //navigate to the home page
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                usernameField.Clear();
                passwordField.Clear();

                usernameField.Focus();
            }
            //if count is equal to 1, the user is valid      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
