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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(School_Management));
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
            this.PanelCover = new System.Windows.Forms.Panel();
            this.Settings_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title_Panel_Cover = new System.Windows.Forms.Label();
            this.ChooseClass = new System.Windows.Forms.Label();
            this.groupNameComboBox = new System.Windows.Forms.ComboBox();
            this.AccessMain = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule-Maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_fn
            // 
            this.textBox_fn.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_fn.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fn.ForeColor = System.Drawing.Color.Teal;
            this.textBox_fn.Location = new System.Drawing.Point(197, 129);
            this.textBox_fn.Name = "textBox_fn";
            this.textBox_fn.Size = new System.Drawing.Size(370, 27);
            this.textBox_fn.TabIndex = 2;
            // 
            // textBox_ln
            // 
            this.textBox_ln.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_ln.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ln.ForeColor = System.Drawing.Color.Teal;
            this.textBox_ln.Location = new System.Drawing.Point(197, 174);
            this.textBox_ln.Name = "textBox_ln";
            this.textBox_ln.Size = new System.Drawing.Size(370, 27);
            this.textBox_ln.TabIndex = 4;
            // 
            // textBox_subj
            // 
            this.textBox_subj.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_subj.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subj.ForeColor = System.Drawing.Color.Teal;
            this.textBox_subj.Location = new System.Drawing.Point(197, 223);
            this.textBox_subj.Name = "textBox_subj";
            this.textBox_subj.Size = new System.Drawing.Size(370, 27);
            this.textBox_subj.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject";
            // 
            // dropdown_room
            // 
            this.dropdown_room.BackColor = System.Drawing.Color.LightCyan;
            this.dropdown_room.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_room.ForeColor = System.Drawing.Color.Teal;
            this.dropdown_room.FormattingEnabled = true;
            this.dropdown_room.Location = new System.Drawing.Point(838, 129);
            this.dropdown_room.Name = "dropdown_room";
            this.dropdown_room.Size = new System.Drawing.Size(121, 27);
            this.dropdown_room.TabIndex = 8;
            this.dropdown_room.Text = "Room";
            this.dropdown_room.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(665, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choose Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dropdown_time
            // 
            this.dropdown_time.BackColor = System.Drawing.Color.LightCyan;
            this.dropdown_time.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_time.ForeColor = System.Drawing.Color.Teal;
            this.dropdown_time.FormattingEnabled = true;
            this.dropdown_time.Items.AddRange(new object[] {
            "08:00:00",
            "10:00:00",
            "12:00:00",
            "14:00:00",
            "16:00:00",
            "18:00:00"});
            this.dropdown_time.Location = new System.Drawing.Point(838, 177);
            this.dropdown_time.Name = "dropdown_time";
            this.dropdown_time.Size = new System.Drawing.Size(121, 27);
            this.dropdown_time.TabIndex = 10;
            this.dropdown_time.Text = "08:00:00";
            this.dropdown_time.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(665, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Choose Period";
            // 
            // bt_next
            // 
            this.bt_next.BackColor = System.Drawing.Color.LightCyan;
            this.bt_next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_next.Location = new System.Drawing.Point(29, 338);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(218, 57);
            this.bt_next.TabIndex = 13;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = false;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.Azure;
            this.bt_submit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_submit.Location = new System.Drawing.Point(541, 338);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(218, 57);
            this.bt_submit.TabIndex = 14;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(12, 433);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 322);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // nr_hours
            // 
            this.nr_hours.AutoSize = true;
            this.nr_hours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_hours.ForeColor = System.Drawing.Color.Black;
            this.nr_hours.Location = new System.Drawing.Point(670, 223);
            this.nr_hours.Name = "nr_hours";
            this.nr_hours.Size = new System.Drawing.Size(150, 29);
            this.nr_hours.TabIndex = 11;
            this.nr_hours.Text = "Classes/week";
            // 
            // textBox_number_of_classes
            // 
            this.textBox_number_of_classes.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_number_of_classes.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_number_of_classes.ForeColor = System.Drawing.Color.Teal;
            this.textBox_number_of_classes.Location = new System.Drawing.Point(838, 223);
            this.textBox_number_of_classes.Name = "textBox_number_of_classes";
            this.textBox_number_of_classes.Size = new System.Drawing.Size(121, 27);
            this.textBox_number_of_classes.TabIndex = 12;
            this.textBox_number_of_classes.TextChanged += new System.EventHandler(this.textBox_number_of_classes_TextChanged);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Azure;
            this.Finish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Finish.Location = new System.Drawing.Point(796, 338);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(227, 57);
            this.Finish.TabIndex = 15;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelCover
            // 
            this.PanelCover.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelCover.Controls.Add(this.Settings_button);
            this.PanelCover.Controls.Add(this.pictureBox1);
            this.PanelCover.Controls.Add(this.Title_Panel_Cover);
            this.PanelCover.Controls.Add(this.ChooseClass);
            this.PanelCover.Controls.Add(this.groupNameComboBox);
            this.PanelCover.Controls.Add(this.AccessMain);
            this.PanelCover.Location = new System.Drawing.Point(12, 12);
            this.PanelCover.Name = "PanelCover";
            this.PanelCover.Size = new System.Drawing.Size(1030, 743);
            this.PanelCover.TabIndex = 16;
            this.PanelCover.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCover_Paint);
            // 
            // Settings_button
            // 
            this.Settings_button.BackColor = System.Drawing.Color.Teal;
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_button.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_button.Location = new System.Drawing.Point(770, 551);
            this.Settings_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(214, 52);
            this.Settings_button.TabIndex = 7;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = false;
            this.Settings_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 341);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // Title_Panel_Cover
            // 
            this.Title_Panel_Cover.AutoSize = true;
            this.Title_Panel_Cover.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Panel_Cover.Location = new System.Drawing.Point(423, 182);
            this.Title_Panel_Cover.Name = "Title_Panel_Cover";
            this.Title_Panel_Cover.Size = new System.Drawing.Size(427, 68);
            this.Title_Panel_Cover.TabIndex = 5;
            this.Title_Panel_Cover.Text = "Plan Your Classes";
            this.Title_Panel_Cover.Click += new System.EventHandler(this.Title_Panel_Cover_Click);
            // 
            // ChooseClass
            // 
            this.ChooseClass.AutoSize = true;
            this.ChooseClass.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseClass.Location = new System.Drawing.Point(63, 373);
            this.ChooseClass.Name = "ChooseClass";
            this.ChooseClass.Size = new System.Drawing.Size(227, 49);
            this.ChooseClass.TabIndex = 3;
            this.ChooseClass.Text = "ChooseClass";
            this.ChooseClass.Click += new System.EventHandler(this.ChooseClass_Click);
            // 
            // groupNameComboBox
            // 
            this.groupNameComboBox.BackColor = System.Drawing.Color.Azure;
            this.groupNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupNameComboBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameComboBox.ForeColor = System.Drawing.Color.Teal;
            this.groupNameComboBox.FormattingEnabled = true;
            this.groupNameComboBox.Items.AddRange(new object[] {
            "F_ENG_CS1A (Faculty of Engineering - Computer Science, Year 1, Series A)",
            "F_ENG_CS1B (Faculty of Engineering - Computer Science, Year 1, Series B)",
            "F_ENG_CS2A (Faculty of Engineering - Computer Science, Year 2, Series A)",
            "F_ENG_CS2B (Faculty of Engineering - Computer Science, Year 2, Series B)",
            "F_ENG_CS3A (Faculty of Engineering - Computer Science, Year 3, Series A)",
            "F_ENG_CS3B (Faculty of Engineering - Computer Science, Year 3, Series B)",
            "F_SCI_BIO1A (Faculty of Science - Biology, Year 1, Series A)",
            "F_SCI_BIO1B (Faculty of Science - Biology, Year 1, Series B)",
            "F_SCI_BIO2A (Faculty of Science - Biology, Year 2, Series A)",
            "F_SCI_BIO2B (Faculty of Science - Biology, Year 2, Series B)",
            "F_SCI_BIO3A (Faculty of Science - Biology, Year 3, Series A)",
            "F_SCI_BIO3B (Faculty of Science - Biology, Year 3, Series B)",
            "F_ART_HIST1A (Faculty of Arts - History, Year 1, Series A)",
            "F_ART_HIST1B (Faculty of Arts - History, Year 1, Series B)",
            "F_ART_HIST2A (Faculty of Arts - History, Year 2, Series A)",
            "F_ART_HIST2B (Faculty of Arts - History, Year 2, Series B)",
            "F_ART_HIST3A (Faculty of Arts - History, Year 3, Series A)",
            "F_ART_HIST3B (Faculty of Arts - History, Year 3, Series B)",
            "F_PSYCH_PSYCH1A (Faculty of Psychology - Psychology, Year 1, Series A)",
            "F_PSYCH_PSYCH1B (Faculty of Psychology - Psychology, Year 1, Series B)",
            "F_PSYCH_PSYCH2A (Faculty of Psychology - Psychology, Year 2, Series A)",
            "F_PSYCH_PSYCH2B (Faculty of Psychology - Psychology, Year 2, Series B)",
            "F_PSYCH_PSYCH3A (Faculty of Psychology - Psychology, Year 3, Series A)",
            "F_PSYCH_PSYCH3B (Faculty of Psychology - Psychology, Year 3, Series B)",
            "F_LAW_LAW1A (Faculty of Law - Law, Year 1, Series A)",
            "F_LAW_LAW1B (Faculty of Law - Law, Year 1, Series B)",
            "F_LAW_LAW2A (Faculty of Law - Law, Year 2, Series A)",
            "F_LAW_LAW2B (Faculty of Law - Law, Year 2, Series B)",
            "F_LAW_LAW3A (Faculty of Law - Law, Year 3, Series A)",
            "F_LAW_LAW3B (Faculty of Law - Law, Year 3, Series B)",
            "F_MED_MED1A (Faculty of Medicine - Medicine, Year 1, Series A)",
            "F_MED_MED1B (Faculty of Medicine - Medicine, Year 1, Series B)",
            "F_MED_MED2A (Faculty of Medicine - Medicine, Year 2, Series A)",
            "F_MED_MED2B (Faculty of Medicine - Medicine, Year 2, Series B)",
            "F_MED_MED3A (Faculty of Medicine - Medicine, Year 3, Series A)",
            "F_MED_MED3B (Faculty of Medicine - Medicine, Year 3, Series B)",
            "F_ENG_ART1A (Faculty of Engineering - Art, Year 1, Series A)",
            "F_ENG_ART1B (Faculty of Engineering - Art, Year 1, Series B)",
            "F_ENG_ART2A (Faculty of Engineering - Art, Year 2, Series A)",
            "F_ENG_ART2B (Faculty of Engineering - Art, Year 2, Series B)",
            "F_ENG_ART3A (Faculty of Engineering - Art, Year 3, Series A)",
            "F_ENG_ART3B (Faculty of Engineering - Art, Year 3, Series B)",
            "F_SCI_CHEM1A (Faculty of Science - Chemistry, Year 1, Series A)",
            "F_SCI_CHEM1B (Faculty of Science - Chemistry, Year 1, Series B)",
            "F_SCI_CHEM2A (Faculty of Science - Chemistry, Year 2, Series A)",
            "F_SCI_CHEM2B (Faculty of Science - Chemistry, Year 2, Series B)",
            "F_SCI_CHEM3A (Faculty of Science - Chemistry, Year 3, Series A)",
            "F_SCI_CHEM3B (Faculty of Science - Chemistry, Year 3, Series B)",
            "F_BUS_MGMT1A (Faculty of Business - Management, Year 1, Series A)",
            "F_BUS_MGMT1B (Faculty of Business - Management, Year 1, Series B"});
            this.groupNameComboBox.Location = new System.Drawing.Point(308, 382);
            this.groupNameComboBox.Name = "groupNameComboBox";
            this.groupNameComboBox.Size = new System.Drawing.Size(676, 32);
            this.groupNameComboBox.TabIndex = 2;
            this.groupNameComboBox.Text = "ChooseClass";
            this.groupNameComboBox.SelectedIndexChanged += new System.EventHandler(this.groupNameComboBox_SelectedIndexChanged);
            // 
            // AccessMain
            // 
            this.AccessMain.BackColor = System.Drawing.Color.Teal;
            this.AccessMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessMain.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessMain.Location = new System.Drawing.Point(770, 470);
            this.AccessMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.AccessMain.Name = "AccessMain";
            this.AccessMain.Size = new System.Drawing.Size(214, 65);
            this.AccessMain.TabIndex = 1;
            this.AccessMain.Text = "AccessMain";
            this.AccessMain.UseVisualStyleBackColor = false;
            this.AccessMain.Click += new System.EventHandler(this.AccessMain_Click);
            this.AccessMain.Paint += new System.Windows.Forms.PaintEventHandler(this.AccessMain_Paint);
            // 
            // delete_bt
            // 
            this.delete_bt.BackColor = System.Drawing.Color.LightCyan;
            this.delete_bt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_bt.Location = new System.Drawing.Point(287, 338);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(218, 57);
            this.delete_bt.TabIndex = 17;
            this.delete_bt.Text = "Delete";
            this.delete_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.delete_bt.UseVisualStyleBackColor = false;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // School_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1050, 767);
            this.Controls.Add(this.PanelCover);
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
            this.Controls.Add(this.delete_bt);
            this.Name = "School_Management";
            this.Text = "School_Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelCover.ResumeLayout(false);
            this.PanelCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel PanelCover;
        private System.Windows.Forms.Button AccessMain;
        private System.Windows.Forms.Label ChooseClass;
        private System.Windows.Forms.ComboBox groupNameComboBox;
        private System.Windows.Forms.Label Title_Panel_Cover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button Settings_button;
    }
}

