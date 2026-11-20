using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelseabeach
{
    public partial class managerform : Form
    {
        public managerform()
        {
            InitializeComponent();
            Theme.Apply(this, "Manager");
            // Screens are swapped by hiding them, so closing the open window with X must end the whole app.
            FormClosed += (s, e) => Application.Exit();
        }

        private void button_showdata_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "role";
            dataGridView1.Columns[2].HeaderText = "username";
            dataGridView1.Columns[3].HeaderText = "email";
            dataGridView1.Columns[4].HeaderText = "gender";
            dataGridView1.Columns[5].HeaderText = "status";
            dataGridView1.Columns[6].Visible = false;

            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand(
                    "select id, role, username, email, gender, status from registrationone where role <> 'Manager'", con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["id"], reader["role"], reader["username"], reader["email"], reader["gender"], reader["status"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Activate an account.
        private void button_info_Click(object sender, EventArgs e)
        {
            SetStatus("1", "0", "status changed to active", "status is already active");
        }

        // Deactivate an account (never a Manager account).
        private void button1_Click(object sender, EventArgs e)
        {
            SetStatus("0", "1", "status changed to deactivate", "status is already deactivate");
        }

        private void SetStatus(string newStatus, string currentStatus, string okMessage, string noChangeMessage)
        {
            string id = textBox_id.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("Please enter a user id.");
                return;
            }

            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand(
                    "update registrationone set status = @new where id = @id and status = @current and role <> 'Manager'", con))
                {
                    cmd.Parameters.AddWithValue("@new", newStatus);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@current", currentStatus);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(okMessage);
                        textBox_id.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(noChangeMessage);
                    }
                }
                button_showdata_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signout_Click(object sender, EventArgs e)
        {
            loginpage pr = new loginpage();
            pr.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Show all bookings.
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "roomid";
            dataGridView1.Columns[1].HeaderText = "bedtype";
            dataGridView1.Columns[2].HeaderText = "roomtype";
            dataGridView1.Columns[3].HeaderText = "numberofDays";
            dataGridView1.Columns[4].HeaderText = "price";
            dataGridView1.Columns[5].HeaderText = "Price Per Day";
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[6].HeaderText = "booked";

            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand("select * from customerroombook", con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["roomid"], reader["bedtype"], reader["roomtype"], reader["numberOfDays"], reader["price"], reader["PricePerDay"], reader["booked"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete a room and its bookings together.
        private void delete_Click(object sender, EventArgs e)
        {
            string roomid = textBox1.Text.Trim();
            if (roomid == "")
            {
                MessageBox.Show("Please enter a room id.");
                return;
            }
            if (MessageBox.Show("do you want to delete??", "confirm,delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlTransaction tx = con.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("delete from customerroombook where roomid = @roomid", con, tx))
                    {
                        cmd.Parameters.AddWithValue("@roomid", roomid);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand("delete from addroom where roomid = @roomid", con, tx))
                    {
                        cmd.Parameters.AddWithValue("@roomid", roomid);
                        cmd.ExecuteNonQuery();
                    }
                    tx.Commit();
                }
                textBox1.Text = "";
                button_showdata_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
