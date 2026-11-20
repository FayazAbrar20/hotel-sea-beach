using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelseabeach
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
            Theme.Apply(this, "Login");
            // Screens are swapped by hiding them, so closing the open window with X must end the whole app.
            FormClosed += (s, e) => Application.Exit();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            t2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void logintextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Paasword_Click(object sender, EventArgs e)
        {
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            new registrationpage().Show();
            Visible = false;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = t1.Text.Trim();
            string password = t2.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                using (SqlConnection con = Db.Open())
                {
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("select * from registrationone where username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("incorrect username or password");
                        return;
                    }

                    DataRow user = dt.Rows[0];
                    string stored = user["password"].ToString();
                    bool ok;

                    if (PasswordHasher.IsHashed(stored))
                    {
                        ok = PasswordHasher.Verify(password, stored);
                    }
                    else
                    {
                        // Account created before passwords were hashed: check the old
                        // plain-text value once, then replace it with a hash.
                        ok = stored == password;
                        if (ok)
                        {
                            using (SqlCommand upgrade = new SqlCommand(
                                "update registrationone set password = @hash where username = @username", con))
                            {
                                upgrade.Parameters.AddWithValue("@hash", PasswordHasher.Hash(password));
                                upgrade.Parameters.AddWithValue("@username", username);
                                upgrade.ExecuteNonQuery();
                            }
                        }
                    }

                    if (!ok)
                    {
                        MessageBox.Show("incorrect username or password");
                        return;
                    }

                    string role = user[1].ToString();
                    string status = user[9].ToString();
                    if (status != "1")
                    {
                        MessageBox.Show("status not active, please contact Manager");
                        return;
                    }

                    Form next;
                    if (role == "Employee") next = new Employeeform();
                    else if (role == "Customer") next = new clientpage();
                    else if (role == "Manager") next = new managerform();
                    else
                    {
                        MessageBox.Show("Unknown role, please contact Manager");
                        return;
                    }

                    RecordLogin(con, username);
                    next.Show();
                    Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Keeps a login history without storing the password.
        // Needs the LoginHistory table from database/migrate.sql; if it is missing,
        // logging is skipped and the login still succeeds.
        private static void RecordLogin(SqlConnection con, string username)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "insert into LoginHistory (username, login_time) values (@username, @time)", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                // Login history is optional.
            }
        }
    }
}
