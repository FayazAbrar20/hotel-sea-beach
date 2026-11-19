namespace hotelseabeach
{
    partial class Employeeform
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
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_info = new System.Windows.Forms.Button();
            this.textBox_roomid = new System.Windows.Forms.TextBox();
            this.label_roomid = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_showdata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_addroom = new System.Windows.Forms.Button();
            this.textBox_addroom = new System.Windows.Forms.TextBox();
            this.textBox_addroomprice = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.comboBox_addroomtype = new System.Windows.Forms.ComboBox();
            this.label_roomnumber = new System.Windows.Forms.Label();
            this.label_roomtype = new System.Windows.Forms.Label();
            this.label_bed = new System.Windows.Forms.Label();
            this.comboBox_addbedtype = new System.Windows.Forms.ComboBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_signout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(372, 69);
            this.button_search.Margin = new System.Windows.Forms.Padding(2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(118, 32);
            this.button_search.TabIndex = 48;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(514, 69);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(369, 32);
            this.textBox_search.TabIndex = 47;
            // 
            // button_info
            // 
            this.button_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info.Location = new System.Drawing.Point(259, 92);
            this.button_info.Margin = new System.Windows.Forms.Padding(2);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(80, 30);
            this.button_info.TabIndex = 46;
            this.button_info.Text = "info";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // textBox_roomid
            // 
            this.textBox_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_roomid.Location = new System.Drawing.Point(106, 94);
            this.textBox_roomid.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_roomid.Name = "textBox_roomid";
            this.textBox_roomid.Size = new System.Drawing.Size(148, 26);
            this.textBox_roomid.TabIndex = 45;
            // 
            // label_roomid
            // 
            this.label_roomid.AutoSize = true;
            this.label_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomid.Location = new System.Drawing.Point(9, 96);
            this.label_roomid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomid.Name = "label_roomid";
            this.label_roomid.Size = new System.Drawing.Size(80, 20);
            this.label_roomid.TabIndex = 44;
            this.label_roomid.Text = "Room ID";
            // 
            // button_update
            // 
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(13, 293);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(119, 32);
            this.button_update.TabIndex = 43;
            this.button_update.Text = "Update Row";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(190, 293);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 32);
            this.button_delete.TabIndex = 42;
            this.button_delete.Text = "Delete Row";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_showdata
            // 
            this.button_showdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showdata.Location = new System.Drawing.Point(372, 386);
            this.button_showdata.Margin = new System.Windows.Forms.Padding(2);
            this.button_showdata.Name = "button_showdata";
            this.button_showdata.Size = new System.Drawing.Size(118, 32);
            this.button_showdata.TabIndex = 41;
            this.button_showdata.Text = "Show Data";
            this.button_showdata.UseVisualStyleBackColor = true;
            this.button_showdata.Click += new System.EventHandler(this.button_showdata_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(372, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 269);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_addroom
            // 
            this.button_addroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addroom.Location = new System.Drawing.Point(826, 442);
            this.button_addroom.Margin = new System.Windows.Forms.Padding(2);
            this.button_addroom.Name = "button_addroom";
            this.button_addroom.Size = new System.Drawing.Size(140, 49);
            this.button_addroom.TabIndex = 39;
            this.button_addroom.Text = "Add Room";
            this.button_addroom.UseVisualStyleBackColor = true;
            this.button_addroom.Click += new System.EventHandler(this.button_addroom_Click);
            // 
            // textBox_addroom
            // 
            this.textBox_addroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addroom.Location = new System.Drawing.Point(106, 123);
            this.textBox_addroom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addroom.Name = "textBox_addroom";
            this.textBox_addroom.Size = new System.Drawing.Size(233, 26);
            this.textBox_addroom.TabIndex = 38;
            // 
            // textBox_addroomprice
            // 
            this.textBox_addroomprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addroomprice.Location = new System.Drawing.Point(106, 234);
            this.textBox_addroomprice.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addroomprice.Name = "textBox_addroomprice";
            this.textBox_addroomprice.Size = new System.Drawing.Size(233, 26);
            this.textBox_addroomprice.TabIndex = 37;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(9, 233);
            this.label_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(49, 20);
            this.label_Price.TabIndex = 36;
            this.label_Price.Text = "Price";
            // 
            // comboBox_addroomtype
            // 
            this.comboBox_addroomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addroomtype.FormattingEnabled = true;
            this.comboBox_addroomtype.Items.AddRange(new object[] {
            "AC",
            "NON-AC"});
            this.comboBox_addroomtype.Location = new System.Drawing.Point(106, 199);
            this.comboBox_addroomtype.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_addroomtype.Name = "comboBox_addroomtype";
            this.comboBox_addroomtype.Size = new System.Drawing.Size(233, 25);
            this.comboBox_addroomtype.TabIndex = 35;
            // 
            // label_roomnumber
            // 
            this.label_roomnumber.AutoSize = true;
            this.label_roomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomnumber.Location = new System.Drawing.Point(9, 125);
            this.label_roomnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomnumber.Name = "label_roomnumber";
            this.label_roomnumber.Size = new System.Drawing.Size(91, 20);
            this.label_roomnumber.TabIndex = 34;
            this.label_roomnumber.Text = "Room NO.";
            // 
            // label_roomtype
            // 
            this.label_roomtype.AutoSize = true;
            this.label_roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomtype.Location = new System.Drawing.Point(9, 199);
            this.label_roomtype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomtype.Name = "label_roomtype";
            this.label_roomtype.Size = new System.Drawing.Size(99, 20);
            this.label_roomtype.TabIndex = 33;
            this.label_roomtype.Text = "Room Type";
            // 
            // label_bed
            // 
            this.label_bed.AutoSize = true;
            this.label_bed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bed.Location = new System.Drawing.Point(9, 164);
            this.label_bed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bed.Name = "label_bed";
            this.label_bed.Size = new System.Drawing.Size(84, 20);
            this.label_bed.TabIndex = 32;
            this.label_bed.Text = "Bed Type";
            // 
            // comboBox_addbedtype
            // 
            this.comboBox_addbedtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addbedtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addbedtype.FormattingEnabled = true;
            this.comboBox_addbedtype.Items.AddRange(new object[] {
            "single bed",
            "double bed",
            "triple bed"});
            this.comboBox_addbedtype.Location = new System.Drawing.Point(106, 161);
            this.comboBox_addbedtype.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_addbedtype.Name = "comboBox_addbedtype";
            this.comboBox_addbedtype.Size = new System.Drawing.Size(233, 25);
            this.comboBox_addbedtype.TabIndex = 31;
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
            // button_signout
            // 
            this.button_signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signout.Location = new System.Drawing.Point(34, 420);
            this.button_signout.Margin = new System.Windows.Forms.Padding(2);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(140, 49);
            this.button_signout.TabIndex = 49;
            this.button_signout.Text = "Sign Out";
            this.button_signout.UseVisualStyleBackColor = true;
            this.button_signout.Click += new System.EventHandler(this.button_signout_Click);
            // 
            // Employeeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 523);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.textBox_roomid);
            this.Controls.Add(this.label_roomid);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_showdata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_addroom);
            this.Controls.Add(this.textBox_addroom);
            this.Controls.Add(this.textBox_addroomprice);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.comboBox_addroomtype);
            this.Controls.Add(this.label_roomnumber);
            this.Controls.Add(this.label_roomtype);
            this.Controls.Add(this.label_bed);
            this.Controls.Add(this.comboBox_addbedtype);
            this.Name = "Employeeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employeeform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.TextBox textBox_roomid;
        private System.Windows.Forms.Label label_roomid;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_showdata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_addroom;
        private System.Windows.Forms.TextBox textBox_addroom;
        private System.Windows.Forms.TextBox textBox_addroomprice;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.ComboBox comboBox_addroomtype;
        private System.Windows.Forms.Label label_roomnumber;
        private System.Windows.Forms.Label label_roomtype;
        private System.Windows.Forms.Label label_bed;
        private System.Windows.Forms.ComboBox comboBox_addbedtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button_signout;
    }
}