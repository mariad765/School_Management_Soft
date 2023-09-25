namespace School_Management_Soft
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_1 = new System.Windows.Forms.MenuStrip();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Room_List = new System.Windows.Forms.DataGridView();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Labs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Edit = new System.Windows.Forms.Label();
            this.panel_time = new System.Windows.Forms.Panel();
            this.given_time_2 = new System.Windows.Forms.TextBox();
            this.start_time_1 = new System.Windows.Forms.TextBox();
            this.laber_time = new System.Windows.Forms.Label();
            this.save_new_time = new System.Windows.Forms.Button();
            this.save_room = new System.Windows.Forms.Button();
            this.database_panel_settings = new System.Windows.Forms.Panel();
            this.database_instra_settings = new System.Windows.Forms.Label();
            this.con_string = new System.Windows.Forms.TextBox();
            this.Finish_table_name = new System.Windows.Forms.TextBox();
            this.Start_table_name = new System.Windows.Forms.TextBox();
            this.save_database_settings = new System.Windows.Forms.Button();
            this.Menu_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_List)).BeginInit();
            this.panel_time.SuspendLayout();
            this.database_panel_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu_1
            // 
            this.Menu_1.BackColor = System.Drawing.Color.MintCream;
            this.Menu_1.BackgroundImage = global::School_Management_Soft.Properties.Resources.pexels_dids_2675047;
            this.Menu_1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.timesToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.Menu_1.Location = new System.Drawing.Point(0, 0);
            this.Menu_1.Name = "Menu_1";
            this.Menu_1.Size = new System.Drawing.Size(616, 37);
            this.Menu_1.TabIndex = 2;
            this.Menu_1.Text = "Menu_1";
            this.Menu_1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_1_ItemClicked);
            this.Menu_1.PaintGrip += new System.Windows.Forms.PaintEventHandler(this.Menu_1_PaintGrip);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.ForeColor = System.Drawing.Color.LightCyan;
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(99, 33);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // timesToolStripMenuItem
            // 
            this.timesToolStripMenuItem.ForeColor = System.Drawing.Color.LightCyan;
            this.timesToolStripMenuItem.Name = "timesToolStripMenuItem";
            this.timesToolStripMenuItem.Size = new System.Drawing.Size(89, 33);
            this.timesToolStripMenuItem.Text = "Times";
            this.timesToolStripMenuItem.Click += new System.EventHandler(this.timesToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.ForeColor = System.Drawing.Color.LightCyan;
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(102, 33);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.ForeColor = System.Drawing.Color.LightCyan;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(123, 33);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // Room_List
            // 
            this.Room_List.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.Room_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Room_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rooms,
            this.Labs});
            this.Room_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Room_List.GridColor = System.Drawing.Color.DarkSlateGray;
            this.Room_List.Location = new System.Drawing.Point(12, 175);
            this.Room_List.Name = "Room_List";
            this.Room_List.RowHeadersWidth = 62;
            this.Room_List.RowTemplate.Height = 28;
            this.Room_List.Size = new System.Drawing.Size(592, 503);
            this.Room_List.TabIndex = 3;
            this.Room_List.Visible = false;
            this.Room_List.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Room_List_CellBeginEdit);
            this.Room_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_List_CellContentClick);
            this.Room_List.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_List_CellValueChanged);
            this.Room_List.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Room_List_RowsRemoved_1);
            this.Room_List.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Room_List_UserAddedRow);
            this.Room_List.Resize += new System.EventHandler(this.Room_List_Resize);
            // 
            // Rooms
            // 
            this.Rooms.HeaderText = "Rooms";
            this.Rooms.MinimumWidth = 8;
            this.Rooms.Name = "Rooms";
            this.Rooms.Width = 150;
            // 
            // Labs
            // 
            this.Labs.HeaderText = "Labs";
            this.Labs.MinimumWidth = 8;
            this.Labs.Name = "Labs";
            this.Labs.Width = 150;
            // 
            // Room_Edit
            // 
            this.Room_Edit.AutoSize = true;
            this.Room_Edit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Room_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Room_Edit.Location = new System.Drawing.Point(12, 63);
            this.Room_Edit.Name = "Room_Edit";
            this.Room_Edit.Size = new System.Drawing.Size(584, 87);
            this.Room_Edit.TabIndex = 4;
            this.Room_Edit.Text = "Add a room , delete a room. There is a maximum of two\r\ntypes of rooms . This list" +
    " must be updated every time the \r\nsoft is used.";
            this.Room_Edit.Visible = false;
            // 
            // panel_time
            // 
            this.panel_time.Controls.Add(this.database_panel_settings);
            this.panel_time.Controls.Add(this.save_new_time);
            this.panel_time.Controls.Add(this.given_time_2);
            this.panel_time.Controls.Add(this.start_time_1);
            this.panel_time.Controls.Add(this.laber_time);
            this.panel_time.Location = new System.Drawing.Point(0, 31);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(632, 689);
            this.panel_time.TabIndex = 5;
            this.panel_time.Visible = false;
            this.panel_time.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_time_Paint);
            // 
            // given_time_2
            // 
            this.given_time_2.BackColor = System.Drawing.Color.LightCyan;
            this.given_time_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.given_time_2.ForeColor = System.Drawing.Color.Teal;
            this.given_time_2.Location = new System.Drawing.Point(37, 208);
            this.given_time_2.Name = "given_time_2";
            this.given_time_2.Size = new System.Drawing.Size(259, 32);
            this.given_time_2.TabIndex = 2;
            this.given_time_2.Text = "Lower time";
            // 
            // start_time_1
            // 
            this.start_time_1.BackColor = System.Drawing.Color.LightCyan;
            this.start_time_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time_1.ForeColor = System.Drawing.Color.Teal;
            this.start_time_1.Location = new System.Drawing.Point(37, 150);
            this.start_time_1.Name = "start_time_1";
            this.start_time_1.Size = new System.Drawing.Size(259, 32);
            this.start_time_1.TabIndex = 1;
            this.start_time_1.Text = "Upper time";
            // 
            // laber_time
            // 
            this.laber_time.AutoSize = true;
            this.laber_time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laber_time.Location = new System.Drawing.Point(32, 30);
            this.laber_time.Name = "laber_time";
            this.laber_time.Size = new System.Drawing.Size(552, 145);
            this.laber_time.TabIndex = 0;
            this.laber_time.Text = "Feel free to set some boundaries on the time. You can \r\nset the time a class can " +
    "start, but it must not be later \r\nwhatever time you set.\r\n\r\n\r\n";
            this.laber_time.Click += new System.EventHandler(this.laber_time_Click);
            // 
            // save_new_time
            // 
            this.save_new_time.BackColor = System.Drawing.Color.Teal;
            this.save_new_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_new_time.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_new_time.Location = new System.Drawing.Point(341, 161);
            this.save_new_time.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.save_new_time.Name = "save_new_time";
            this.save_new_time.Size = new System.Drawing.Size(214, 65);
            this.save_new_time.TabIndex = 4;
            this.save_new_time.Text = "Save";
            this.save_new_time.UseVisualStyleBackColor = false;
            this.save_new_time.Click += new System.EventHandler(this.save_new_time_Click);
            // 
            // save_room
            // 
            this.save_room.BackColor = System.Drawing.Color.Teal;
            this.save_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_room.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_room.Location = new System.Drawing.Point(472, 123);
            this.save_room.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.save_room.Name = "save_room";
            this.save_room.Size = new System.Drawing.Size(113, 48);
            this.save_room.TabIndex = 6;
            this.save_room.Text = "Save";
            this.save_room.UseVisualStyleBackColor = false;
            this.save_room.Visible = false;
            this.save_room.Click += new System.EventHandler(this.save_room_Click);
            // 
            // database_panel_settings
            // 
            this.database_panel_settings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.database_panel_settings.Controls.Add(this.save_database_settings);
            this.database_panel_settings.Controls.Add(this.Start_table_name);
            this.database_panel_settings.Controls.Add(this.Finish_table_name);
            this.database_panel_settings.Controls.Add(this.con_string);
            this.database_panel_settings.Controls.Add(this.database_instra_settings);
            this.database_panel_settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_panel_settings.Location = new System.Drawing.Point(0, 3);
            this.database_panel_settings.Name = "database_panel_settings";
            this.database_panel_settings.Size = new System.Drawing.Size(616, 661);
            this.database_panel_settings.TabIndex = 5;
            this.database_panel_settings.Visible = false;
            // 
            // database_instra_settings
            // 
            this.database_instra_settings.AutoSize = true;
            this.database_instra_settings.Location = new System.Drawing.Point(29, 40);
            this.database_instra_settings.Name = "database_instra_settings";
            this.database_instra_settings.Size = new System.Drawing.Size(567, 87);
            this.database_instra_settings.TabIndex = 0;
            this.database_instra_settings.Text = "Set the Database connection string and the intial tables \r\nnames. You will need t" +
    "o change them every time you \r\nopen the app.\r\n";
            // 
            // con_string
            // 
            this.con_string.BackColor = System.Drawing.Color.LightCyan;
            this.con_string.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_string.ForeColor = System.Drawing.Color.Teal;
            this.con_string.Location = new System.Drawing.Point(37, 171);
            this.con_string.Name = "con_string";
            this.con_string.Size = new System.Drawing.Size(548, 37);
            this.con_string.TabIndex = 1;
            this.con_string.Text = "YourConnectionString";
            this.con_string.Visible = false;
            this.con_string.TextChanged += new System.EventHandler(this.con_string_TextChanged);
            // 
            // Finish_table_name
            // 
            this.Finish_table_name.BackColor = System.Drawing.Color.LightCyan;
            this.Finish_table_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish_table_name.ForeColor = System.Drawing.Color.Teal;
            this.Finish_table_name.Location = new System.Drawing.Point(34, 233);
            this.Finish_table_name.Name = "Finish_table_name";
            this.Finish_table_name.Size = new System.Drawing.Size(548, 37);
            this.Finish_table_name.TabIndex = 2;
            this.Finish_table_name.Text = "YourFinishTableName";
            this.Finish_table_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Start_table_name
            // 
            this.Start_table_name.BackColor = System.Drawing.Color.LightCyan;
            this.Start_table_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_table_name.ForeColor = System.Drawing.Color.Teal;
            this.Start_table_name.Location = new System.Drawing.Point(34, 297);
            this.Start_table_name.Name = "Start_table_name";
            this.Start_table_name.Size = new System.Drawing.Size(548, 37);
            this.Start_table_name.TabIndex = 3;
            this.Start_table_name.Text = "YourStartTableName";
            // 
            // save_database_settings
            // 
            this.save_database_settings.BackColor = System.Drawing.Color.Teal;
            this.save_database_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_database_settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_database_settings.Location = new System.Drawing.Point(440, 369);
            this.save_database_settings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.save_database_settings.Name = "save_database_settings";
            this.save_database_settings.Size = new System.Drawing.Size(142, 60);
            this.save_database_settings.TabIndex = 7;
            this.save_database_settings.Text = "Save";
            this.save_database_settings.UseVisualStyleBackColor = false;
            this.save_database_settings.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(616, 722);
            this.Controls.Add(this.save_room);
            this.Controls.Add(this.panel_time);
            this.Controls.Add(this.Menu_1);
            this.Controls.Add(this.Room_List);
            this.Controls.Add(this.Room_Edit);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Menu_1.ResumeLayout(false);
            this.Menu_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_List)).EndInit();
            this.panel_time.ResumeLayout(false);
            this.panel_time.PerformLayout();
            this.database_panel_settings.ResumeLayout(false);
            this.database_panel_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip Menu_1;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.DataGridView Room_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Labs;
        private System.Windows.Forms.Label Room_Edit;
        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.Label laber_time;
        private System.Windows.Forms.TextBox start_time_1;
        private System.Windows.Forms.TextBox given_time_2;
        private System.Windows.Forms.Button save_new_time;
        private System.Windows.Forms.Button save_room;
        private System.Windows.Forms.Panel database_panel_settings;
        private System.Windows.Forms.TextBox Finish_table_name;
        private System.Windows.Forms.TextBox con_string;
        private System.Windows.Forms.Label database_instra_settings;
        private System.Windows.Forms.TextBox Start_table_name;
        private System.Windows.Forms.Button save_database_settings;
    }
}