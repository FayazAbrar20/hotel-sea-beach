using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelseabeach
{
    public partial class registrationpage : Form
    {
        public registrationpage()
        {
            InitializeComponent();
            Theme.Apply(this, "Register");
            // Screens are swapped by hiding them, so closing the open window with X must end the whole app.
            FormClosed += (s, e) => Application.Exit();
            textBox4.UseSystemPasswordChar = true;   // hide the password while typing
            dateTimePicker1.MaxDate = DateTime.Today; // no birth dates in the future
        }

        private void username_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginpage pr = new loginpage();
            pr.Show();
            Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        // Field map: comboBox1 = role, textBox1 = username, textBox4 = password,
        // textBox2 = email, textBox5 = mobile, dateTimePicker1 = date of birth,
        // comboBox2 = gender, textBox3 = address.
        private void button2_Click(object sender, EventArgs e)
        {
            string role = comboBox1.Text;
            string username = textBox1.Text.Trim();
            string password = textBox4.Text;
            string email = textBox2.Text.Trim();
            string mobile = textBox5.Text.Trim().Replace(" ", "").Replace("-", "");
            string gender = comboBox2.Text;
            string address = textBox3.Text.Trim();
            DateTime dob = dateTimePicker1.Value.Date;

            List<string> errors = SignupValidator.Validate(role, username, password, email, mobile, dob, gender, address, DateTime.Today);
            if (errors.Count > 0)
            {
                MessageBox.Show("Please fix the following:\n\n- " + string.Join("\n- ", errors),
                                "Check your details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Db.Open())
                {
                    if (Exists(con, "select count(*) from registrationone where username = @v", username))
                    {
                        MessageBox.Show("This username is already taken.");
                        return;
                    }
                    if (Exists(con, "select count(*) from registrationone where email = @v", email))
                    {
                        MessageBox.Show("An account with this email already exists.");
                        return;
                    }
                    if (Exists(con, "select count(*) from registrationone where mobile = @v", mobile))
                    {
                        MessageBox.Show("An account with this mobile number already exists.");
                        return;
                    }

                    // Only the very first account may sign up as Manager (to set up the hotel).
                    // After that, Manager accounts must be created by an existing Manager in the database.
                    bool firstManager = false;
                    if (role == "Manager")
                    {
                        if (Exists(con, "select count(*) from registrationone where role = @v", "Manager"))
                        {
                            MessageBox.Show("Manager accounts cannot be created from the signup screen.\nPlease register as Employee or Customer.",
                                            "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        firstManager = true;
                    }

                    using (SqlCommand insert = new SqlCommand(
                        "insert into registrationone values (@role, @username, @password, @email, @mobile, @dob, @gender, @address, @status)", con))
                    {
                        insert.Parameters.AddWithValue("@role", role);
                        insert.Parameters.AddWithValue("@username", username);
                        insert.Parameters.AddWithValue("@password", PasswordHasher.Hash(password));
                        insert.Parameters.AddWithValue("@email", email);
                        insert.Parameters.AddWithValue("@mobile", mobile);
                        insert.Parameters.AddWithValue("@dob", dob.ToString("yyyy-MM-dd"));
                        insert.Parameters.AddWithValue("@gender", gender);
                        insert.Parameters.AddWithValue("@address", address);
                        // The first Manager is active straight away; everyone else waits for a Manager.
                        insert.Parameters.AddWithValue("@status", firstManager ? "1" : "0");
                        insert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(role == "Manager"
                    ? "Manager account created. You can log in now."
                    : "Account created. A Manager must activate it before you can log in.");

                loginpage pr = new loginpage();
                pr.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool Exists(SqlConnection con, string query, string value)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@v", value);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void registrationpage_Load(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
