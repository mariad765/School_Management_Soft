namespace School_Management_Soft
{
    partial class School_Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fn = new System.Windows.Forms.TextBox();
            this.textBox_ln = new System.Windows.Forms.TextBox();
            this.textBox_subj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdown_room = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dropdown_time = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nr_hours = new System.Windows.Forms.Label();
            this.textBox_number_of_classes = new System.Windows.Forms.TextBox();
            this.Finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(381, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule-Maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_fn
            // 
            this.textBox_fn.Location = new System.Drawing.Point(377, 185);
            this.textBox_fn.Name = "textBox_fn";
            this.textBox_fn.Size = new System.Drawing.Size(370, 26);
            this.textBox_fn.TabIndex = 2;
            // 
            // textBox_ln
            // 
            this.textBox_ln.Location = new System.Drawing.Point(377, 236);
            this.textBox_ln.Name = "textBox_ln";
            this.textBox_ln.Size = new System.Drawing.Size(370, 26);
            this.textBox_ln.TabIndex = 4;
            // 
            // textBox_subj
            // 
            this.textBox_subj.Location = new System.Drawing.Point(377, 287);
            this.textBox_subj.Name = "textBox_subj";
            this.textBox_subj.Size = new System.Drawing.Size(370, 26);
            this.textBox_subj.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject";
            // 
            // dropdown_room
            // 
            this.dropdown_room.FormattingEnabled = true;
            this.dropdown_room.Items.AddRange(new object[] {
            "Room A",
            "Room B",
            "Room C",
            "Room D",
            "Room E",
            "Room F"});
            this.dropdown_room.Location = new System.Drawing.Point(238, 333);
            this.dropdown_room.Name = "dropdown_room";
            this.dropdown_room.Size = new System.Drawing.Size(121, 28);
            this.dropdown_room.TabIndex = 8;
            this.dropdown_room.Text = "Room A";
            this.dropdown_room.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choose Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dropdown_time
            // 
            this.dropdown_time.FormattingEnabled = true;
            this.dropdown_time.Items.AddRange(new object[] {
            "08:00:00",
            "10:00:00",
            "12:00:00",
            "14:00:00",
            "16:00:00",
            "18:00:00"});
            this.dropdown_time.Location = new System.Drawing.Point(522, 333);
            this.dropdown_time.Name = "dropdown_time";
            this.dropdown_time.Size = new System.Drawing.Size(121, 28);
            this.dropdown_time.TabIndex = 10;
            this.dropdown_time.Text = "08:00:00";
            this.dropdown_time.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Choose Period";
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(289, 389);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(218, 57);
            this.bt_next.TabIndex = 13;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(550, 389);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(218, 57);
            this.bt_submit.TabIndex = 14;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 285);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nr_hours
            // 
            this.nr_hours.AutoSize = true;
            this.nr_hours.Location = new System.Drawing.Point(699, 333);
            this.nr_hours.Name = "nr_hours";
            this.nr_hours.Size = new System.Drawing.Size(106, 20);
            this.nr_hours.TabIndex = 11;
            this.nr_hours.Text = "Classes/week";
            // 
            // textBox_number_of_classes
            // 
            this.textBox_number_of_classes.Location = new System.Drawing.Point(811, 330);
            this.textBox_number_of_classes.Name = "textBox_number_of_classes";
            this.textBox_number_of_classes.Size = new System.Drawing.Size(100, 26);
            this.textBox_number_of_classes.TabIndex = 12;
            this.textBox_number_of_classes.TextChanged += new System.EventHandler(this.textBox_number_of_classes_TextChanged);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.LawnGreen;
            this.Finish.Location = new System.Drawing.Point(753, 69);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(158, 50);
            this.Finish.TabIndex = 15;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.button1_Click);
            // 
            // School_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1050, 767);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.textBox_number_of_classes);
            this.Controls.Add(this.nr_hours);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dropdown_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropdown_room);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_subj);
            this.Controls.Add(this.textBox_ln);
            this.Controls.Add(this.textBox_fn);
            this.Controls.Add(this.label1);
            this.Name = "School_Management";
            this.Text = "School_Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fn;
        private System.Windows.Forms.TextBox textBox_ln;
        private System.Windows.Forms.TextBox textBox_subj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropdown_room;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropdown_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nr_hours;
        private System.Windows.Forms.TextBox textBox_number_of_classes;
        private System.Windows.Forms.Button Finish;
    }
}

