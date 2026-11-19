using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelseabeach
{
    public partial class Employeeform : Form
    {
        public Employeeform()
        {
            InitializeComponent();
            // Screens are swapped by hiding them, so closing the open window with X must end the whole app.
            FormClosed += (s, e) => Application.Exit();
        }

        public void clear()
        {
            textBox_addroom.Text = "";
            comboBox_addbedtype.SelectedIndex = -1;
            comboBox_addroomtype.SelectedIndex = -1;
            textBox_addroomprice.Text = "";
            textBox_roomid.Text = "";
        }

        private bool RoomFieldsFilled()
        {
            return textBox_addroom.Text.Trim() != "" && comboBox_addbedtype.Text != "" &&
                   comboBox_addroomtype.Text != "" && textBox_addroomprice.Text.Trim() != "";
        }

        private bool PriceIsValid()
        {
            // Whole numbers only: the booking screen multiplies the price as an integer.
            int price;
            if (int.TryParse(textBox_addroomprice.Text.Trim(), out price) && price > 0) return true;
            MessageBox.Show("Please enter the price as a whole number greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void button_addroom_Click(object sender, EventArgs e)
        {
            if (!RoomFieldsFilled())
            {
                MessageBox.Show("please enter all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PriceIsValid()) return;

            try
            {
                using (SqlConnection con = Db.Open())
                {
                    using (SqlCommand check = new SqlCommand("select count(*) from addroom where roomnumber = @roomnumber", con))
                    {
                        check.Parameters.AddWithValue("@roomnumber", textBox_addroom.Text.Trim());
                        if ((int)check.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("THIS ROOM NUMBER IS ALREADY ADDED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "insert into addroom (roomnumber, bedtype, roomtype, price, booked) values (@roomnumber, @bedtype, @roomtype, @price, 'NO')", con))
                    {
                        cmd.Parameters.AddWithValue("@roomnumber", textBox_addroom.Text.Trim());
                        cmd.Parameters.AddWithValue("@bedtype", comboBox_addbedtype.Text);
                        cmd.Parameters.AddWithValue("@roomtype", comboBox_addroomtype.Text);
                        cmd.Parameters.AddWithValue("@price", textBox_addroomprice.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("room added successfully");
                button_showdata_Click(null, null);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_showdata_Click(object sender, EventArgs e)
        {
            LoadRooms("select * from addroom", null);
        }

        private void LoadRooms(string query, string search)
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (search != null) cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["roomid"], reader["roomnumber"], reader["bedtype"], reader["roomtype"], reader["price"], reader["booked"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand("select * from addroom where roomid = @roomid", con))
                {
                    cmd.Parameters.AddWithValue("@roomid", textBox_roomid.Text.Trim());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox_addroom.Text = reader["roomnumber"].ToString();
                            comboBox_addbedtype.Text = reader["bedtype"].ToString();
                            comboBox_addroomtype.Text = reader["roomtype"].ToString();
                            textBox_addroomprice.Text = reader["price"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Room not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_roomid.Text.Trim() == "" || !RoomFieldsFilled())
            {
                MessageBox.Show("please enter all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PriceIsValid()) return;

            try
            {
                int result;
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand(
                    "update addroom set roomnumber = @roomnumber, bedtype = @bedtype, roomtype = @roomtype, price = @price where roomid = @roomid", con))
                {
                    cmd.Parameters.AddWithValue("@roomnumber", textBox_addroom.Text.Trim());
                    cmd.Parameters.AddWithValue("@bedtype", comboBox_addbedtype.Text);
                    cmd.Parameters.AddWithValue("@roomtype", comboBox_addroomtype.Text);
                    cmd.Parameters.AddWithValue("@price", textBox_addroomprice.Text.Trim());
                    cmd.Parameters.AddWithValue("@roomid", textBox_roomid.Text.Trim());
                    result = cmd.ExecuteNonQuery();
                }

                if (result > 0)
                {
                    MessageBox.Show("room updated successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("update failed!! please Try again");
                }
                button_showdata_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            LoadRooms(
                "select * from addroom where cast(roomid as nvarchar(50)) like @search or roomnumber like @search or bedtype like @search " +
                "or roomtype like @search or cast(price as nvarchar(50)) like @search or booked like @search",
                textBox_search.Text.Trim());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string roomid = textBox_roomid.Text.Trim();
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
                using (SqlCommand cmd = new SqlCommand("delete from addroom where roomid = @roomid", con))
                {
                    cmd.Parameters.AddWithValue("@roomid", roomid);
                    cmd.ExecuteNonQuery();
                }
                clear();
                button_showdata_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                textBox_roomid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            loginpage add_Room = new loginpage();
            add_Room.Show();
            Visible = false;
        }
    }
}
