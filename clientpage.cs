using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelseabeach
{
    public partial class clientpage : Form
    {
        public void clear()
        {
            textBox_NumberOfDays.Text = "";
            textBox_price.Text = "";
        }

        public void clear1()
        {
            textBox_NumberOfDays.Text = "";
            textBox_price.Text = "";
            textBox_addroom.Text = "";
            textBox_roomid.Text = "";
            bedtypetextbox.Text = "";
            roomtypetextbox.Text = "";
            textBox_addroomprice.Text = "";
        }

        public void SetComboBox(string query, ComboBox combo)
        {
        }

        public clientpage()
        {
            InitializeComponent();
            Theme.Apply(this, "Customer");
            // Screens are swapped by hiding them, so closing the open window with X must end the whole app.
            FormClosed += (s, e) => Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            loginpage add_Room = new loginpage();
            add_Room.Show();
            Visible = false;
        }

        private void button_checkout_Click(object sender, EventArgs e)
        {
        }

        private void button_booknow_Click(object sender, EventArgs e)
        {
        }

        private void button_showprice_Click(object sender, EventArgs e)
        {
            int days, pricePerDay;
            if (!int.TryParse(textBox_NumberOfDays.Text.Trim(), out days) || days <= 0 ||
                !int.TryParse(textBox_addroomprice.Text.Trim(), out pricePerDay) || pricePerDay <= 0)
            {
                MessageBox.Show("Please enter valid whole numbers greater than 0!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox_price.Text = (days * pricePerDay).ToString();
        }

        private void comboBox_bedtype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button_showdata_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlCommand cmd = new SqlCommand("select * from addroom", con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["roomid"], reader["roomnumber"], reader["bedtype"], reader["roomtype"], reader["price"], reader["booked"]);
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
                            bedtypetextbox.Text = reader["bedtype"].ToString();
                            roomtypetextbox.Text = reader["roomtype"].ToString();
                            textBox_addroomprice.Text = reader["price"].ToString();
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Room not found", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_booknow_Click_1(object sender, EventArgs e)
        {
            string roomid = textBox_roomid.Text.Trim();
            string roomnumber = textBox_addroom.Text;
            string bedType = bedtypetextbox.Text;
            string roomType = roomtypetextbox.Text;
            string price = textBox_price.Text;
            string numberOfDays = textBox_NumberOfDays.Text.Trim();
            string pricePerDay = textBox_addroomprice.Text;

            if (roomid == "" || roomnumber == "" || bedType == "" || roomType == "" ||
                price == "" || numberOfDays == "" || pricePerDay == "")
            {
                MessageBox.Show("Please enter all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = Db.Open())
                using (SqlTransaction tx = con.BeginTransaction())
                {
                    // Marking the room booked only if it is still free makes the check and the
                    // update one step, so two customers cannot book the same room at once.
                    int marked;
                    using (SqlCommand mark = new SqlCommand(
                        "update addroom set booked = 'YES' where roomid = @roomid and booked = 'NO'", con, tx))
                    {
                        mark.Parameters.AddWithValue("@roomid", roomid);
                        marked = mark.ExecuteNonQuery();
                    }

                    if (marked != 1)
                    {
                        tx.Rollback();
                        MessageBox.Show("room is already booked");
                        button_showdata_Click(null, null);
                        return;
                    }

                    using (SqlCommand insert = new SqlCommand(
                        "insert into Customerroombook (roomid, roomnumber, bedtype, roomtype, price, numberOfDays, PricePerDay, booked) " +
                        "values (@roomid, @roomnumber, @bedtype, @roomtype, @price, @days, @perday, 'Yes')", con, tx))
                    {
                        insert.Parameters.AddWithValue("@roomid", roomid);
                        insert.Parameters.AddWithValue("@roomnumber", roomnumber);
                        insert.Parameters.AddWithValue("@bedtype", bedType);
                        insert.Parameters.AddWithValue("@roomtype", roomType);
                        insert.Parameters.AddWithValue("@price", price);
                        insert.Parameters.AddWithValue("@days", numberOfDays);
                        insert.Parameters.AddWithValue("@perday", pricePerDay);
                        insert.ExecuteNonQuery();
                    }

                    tx.Commit();
                }

                MessageBox.Show("room is booked");
                clear1();
                button_showdata_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_addbedtype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox_NumberOfDays_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
