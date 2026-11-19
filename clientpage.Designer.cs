namespace hotelseabeach
{
    partial class clientpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_priceperday = new System.Windows.Forms.Label();
            this.textBox_NumberOfDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_showprice = new System.Windows.Forms.Button();
            this.button_signout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_showdata = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.textBox_roomid = new System.Windows.Forms.TextBox();
            this.label_roomid = new System.Windows.Forms.Label();
            this.textBox_addroom = new System.Windows.Forms.TextBox();
            this.textBox_addroomprice = new System.Windows.Forms.TextBox();
            this.label_roomnumber = new System.Windows.Forms.Label();
            this.label_roomtype = new System.Windows.Forms.Label();
            this.label_bed = new System.Windows.Forms.Label();
            this.button_booknow = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.bedtypetextbox = new System.Windows.Forms.TextBox();
            this.roomtypetextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_priceperday
            // 
            this.label_priceperday.AutoSize = true;
            this.label_priceperday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priceperday.Location = new System.Drawing.Point(12, 181);
            this.label_priceperday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_priceperday.Name = "label_priceperday";
            this.label_priceperday.Size = new System.Drawing.Size(117, 20);
            this.label_priceperday.TabIndex = 44;
            this.label_priceperday.Text = "Price Per Day";
            // 
            // textBox_NumberOfDays
            // 
            this.textBox_NumberOfDays.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_NumberOfDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberOfDays.Location = new System.Drawing.Point(155, 220);
            this.textBox_NumberOfDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NumberOfDays.Name = "textBox_NumberOfDays";
            this.textBox_NumberOfDays.Size = new System.Drawing.Size(135, 23);
            this.textBox_NumberOfDays.TabIndex = 41;
            this.textBox_NumberOfDays.TextChanged += new System.EventHandler(this.textBox_NumberOfDays_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Number Of Days";
            // 
            // button_showprice
            // 
            this.button_showprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showprice.Location = new System.Drawing.Point(320, 216);
            this.button_showprice.Margin = new System.Windows.Forms.Padding(2);
            this.button_showprice.Name = "button_showprice";
            this.button_showprice.Size = new System.Drawing.Size(74, 30);
            this.button_showprice.TabIndex = 37;
            this.button_showprice.Text = "BILL";
            this.button_showprice.UseVisualStyleBackColor = true;
            this.button_showprice.Click += new System.EventHandler(this.button_showprice_Click);
            // 
            // button_signout
            // 
            this.button_signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signout.Location = new System.Drawing.Point(964, 471);
            this.button_signout.Margin = new System.Windows.Forms.Padding(2);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(140, 49);
            this.button_signout.TabIndex = 35;
            this.button_signout.Text = "Sign Out";
            this.button_signout.UseVisualStyleBackColor = true;
            this.button_signout.Click += new System.EventHandler(this.button_signout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(513, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 269);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ROOM ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ROOM NUMBER";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "BED TYPE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ROOM TYPE";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ROOM PRICE";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Booked";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // button_showdata
            // 
            this.button_showdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showdata.Location = new System.Drawing.Point(513, 341);
            this.button_showdata.Margin = new System.Windows.Forms.Padding(2);
            this.button_showdata.Name = "button_showdata";
            this.button_showdata.Size = new System.Drawing.Size(118, 32);
            this.button_showdata.TabIndex = 49;
            this.button_showdata.Text = "Show Data";
            this.button_showdata.UseVisualStyleBackColor = true;
            this.button_showdata.Click += new System.EventHandler(this.button_showdata_Click);
            // 
            // button_info
            // 
            this.button_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info.Location = new System.Drawing.Point(295, 38);
            this.button_info.Margin = new System.Windows.Forms.Padding(2);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(80, 30);
            this.button_info.TabIndex = 60;
            this.button_info.Text = "info";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // textBox_roomid
            // 
            this.textBox_roomid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_roomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_roomid.Location = new System.Drawing.Point(142, 40);
            this.textBox_roomid.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_roomid.Name = "textBox_roomid";
            this.textBox_roomid.Size = new System.Drawing.Size(148, 26);
            this.textBox_roomid.TabIndex = 59;
            // 
            // label_roomid
            // 
            this.label_roomid.AutoSize = true;
            this.label_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomid.Location = new System.Drawing.Point(30, 40);
            this.label_roomid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomid.Name = "label_roomid";
            this.label_roomid.Size = new System.Drawing.Size(80, 20);
            this.label_roomid.TabIndex = 58;
            this.label_roomid.Text = "Room ID";
            // 
            // textBox_addroom
            // 
            this.textBox_addroom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_addroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_addroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addroom.Location = new System.Drawing.Point(142, 69);
            this.textBox_addroom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addroom.Name = "textBox_addroom";
            this.textBox_addroom.ReadOnly = true;
            this.textBox_addroom.Size = new System.Drawing.Size(233, 26);
            this.textBox_addroom.TabIndex = 57;
            // 
            // textBox_addroomprice
            // 
            this.textBox_addroomprice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_addroomprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_addroomprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addroomprice.Location = new System.Drawing.Point(142, 178);
            this.textBox_addroomprice.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addroomprice.Name = "textBox_addroomprice";
            this.textBox_addroomprice.ReadOnly = true;
            this.textBox_addroomprice.Size = new System.Drawing.Size(233, 26);
            this.textBox_addroomprice.TabIndex = 56;
            // 
            // label_roomnumber
            // 
            this.label_roomnumber.AutoSize = true;
            this.label_roomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomnumber.Location = new System.Drawing.Point(30, 69);
            this.label_roomnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomnumber.Name = "label_roomnumber";
            this.label_roomnumber.Size = new System.Drawing.Size(91, 20);
            this.label_roomnumber.TabIndex = 53;
            this.label_roomnumber.Text = "Room NO.";
            // 
            // label_roomtype
            // 
            this.label_roomtype.AutoSize = true;
            this.label_roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomtype.Location = new System.Drawing.Point(30, 143);
            this.label_roomtype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomtype.Name = "label_roomtype";
            this.label_roomtype.Size = new System.Drawing.Size(99, 20);
            this.label_roomtype.TabIndex = 52;
            this.label_roomtype.Text = "Room Type";
            // 
            // label_bed
            // 
            this.label_bed.AutoSize = true;
            this.label_bed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bed.Location = new System.Drawing.Point(30, 108);
            this.label_bed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bed.Name = "label_bed";
            this.label_bed.Size = new System.Drawing.Size(84, 20);
            this.label_bed.TabIndex = 51;
            this.label_bed.Text = "Bed Type";
            // 
            // button_booknow
            // 
            this.button_booknow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_booknow.Location = new System.Drawing.Point(55, 324);
            this.button_booknow.Margin = new System.Windows.Forms.Padding(2);
            this.button_booknow.Name = "button_booknow";
            this.button_booknow.Size = new System.Drawing.Size(140, 49);
            this.button_booknow.TabIndex = 61;
            this.button_booknow.Text = "Book Now";
            this.button_booknow.UseVisualStyleBackColor = true;
            this.button_booknow.Click += new System.EventHandler(this.button_booknow_Click_1);
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(181, 264);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(135, 23);
            this.textBox_price.TabIndex = 63;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(35, 263);
            this.label_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(94, 20);
            this.label_Price.TabIndex = 62;
            this.label_Price.Text = "Total Price";
            // 
            // bedtypetextbox
            // 
            this.bedtypetextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bedtypetextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bedtypetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedtypetextbox.Location = new System.Drawing.Point(155, 108);
            this.bedtypetextbox.Margin = new System.Windows.Forms.Padding(2);
            this.bedtypetextbox.Name = "bedtypetextbox";
            this.bedtypetextbox.ReadOnly = true;
            this.bedtypetextbox.Size = new System.Drawing.Size(233, 26);
            this.bedtypetextbox.TabIndex = 64;
            // 
            // roomtypetextbox
            // 
            this.roomtypetextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roomtypetextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomtypetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtypetextbox.Location = new System.Drawing.Point(161, 148);
            this.roomtypetextbox.Margin = new System.Windows.Forms.Padding(2);
            this.roomtypetextbox.Name = "roomtypetextbox";
            this.roomtypetextbox.ReadOnly = true;
            this.roomtypetextbox.Size = new System.Drawing.Size(233, 26);
            this.roomtypetextbox.TabIndex = 65;
            // 
            // clientpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1172, 570);
            this.Controls.Add(this.roomtypetextbox);
            this.Controls.Add(this.bedtypetextbox);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.button_booknow);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.textBox_roomid);
            this.Controls.Add(this.label_roomid);
            this.Controls.Add(this.textBox_addroom);
            this.Controls.Add(this.textBox_addroomprice);
            this.Controls.Add(this.label_roomnumber);
            this.Controls.Add(this.label_roomtype);
            this.Controls.Add(this.label_bed);
            this.Controls.Add(this.button_showdata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_priceperday);
            this.Controls.Add(this.textBox_NumberOfDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_showprice);
            this.Controls.Add(this.button_signout);
            this.Name = "clientpage";
            this.Text = "clientpage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_priceperday;
        private System.Windows.Forms.TextBox textBox_NumberOfDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_showprice;
        private System.Windows.Forms.Button button_signout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button_showdata;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.TextBox textBox_roomid;
        private System.Windows.Forms.Label label_roomid;
        private System.Windows.Forms.TextBox textBox_addroom;
        private System.Windows.Forms.TextBox textBox_addroomprice;
        private System.Windows.Forms.Label label_roomnumber;
        private System.Windows.Forms.Label label_roomtype;
        private System.Windows.Forms.Label label_bed;
        private System.Windows.Forms.Button button_booknow;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox bedtypetextbox;
        private System.Windows.Forms.TextBox roomtypetextbox;
    }
}