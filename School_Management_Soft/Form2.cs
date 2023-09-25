﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using School_Management_Soft;
using static iTextSharp.text.pdf.events.IndexEvents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Management_Soft
{
    public partial class SettingsForm : Form
    {
        private School_Management schoolManagement;
        private List<string> roomList = Globals.roomList;
        private List<string> labList = Globals.labList;
        double given_time1 = Globals.GivenTime1;
        double given_time2 = Globals.GivenTime2;

        public SettingsForm(School_Management sm)
        {
            InitializeComponent();
            this.schoolManagement = sm;
          
         
            // Subscribe to the CellValueChanged event


            // You can now work with roomList and labList
        }



        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loop through all controls on the form
            foreach (Control control in Controls)
            {
                // Check if the control is not the MenuStrip
                if (!(control is MenuStrip))
                {
                    // Hide the control by setting its Visible property to false
                    control.Visible = false;
                }
            }
            save_room.Visible = true;
            Room_Edit.Visible = true;
            Room_List.Visible = true;
          
            PopulateFromLists();

        }

        private void Menu_1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_1_PaintGrip(object sender, PaintEventArgs e)
        {

        }

        private void Room_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Room_List_Resize(object sender, EventArgs e)
        {

        }


        private void PopulateFromLists()
        {
            for (int i = 0; i < Math.Max(roomList.Count, labList.Count); i++)
            {
                string item1 = (i < roomList.Count) ? roomList[i] : string.Empty;
                string item2 = (i < labList.Count) ? labList[i] : string.Empty;
                Room_List.Rows.Add(item1, item2);
            }
        }


        private void Room_List_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void Room_List_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void Room_List_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = Room_List.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string newValue = cell.Value?.ToString();

                // Update the corresponding list based on the column index
                if (e.ColumnIndex == 0)
                {
                    roomList[e.RowIndex] = newValue;
                }
                else if (e.ColumnIndex == 1)
                {
                    labList[e.RowIndex] = newValue;
                }
            }
        }

        private void Room_List_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
                // Initialize the corresponding list elements for the new row
                int rowIndex = e.Row.Index;

                // Make sure the lists have enough elements
                while (roomList.Count < rowIndex)
                {
                    roomList.Add(null); // Add null elements as needed
                }

                while (labList.Count < rowIndex)
                {
                    labList.Add(null); // Add null elements as needed
                }

                // Check if any cell in the new row is not empty
                bool hasValue = false;

                foreach (DataGridViewCell cell in e.Row.Cells)
                {
                    if (!string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        hasValue = true;
                        break;
                    }
                }

                // If any cell has a value, add it to the corresponding list
                if (hasValue)
                {
                    if (!string.IsNullOrWhiteSpace(e.Row.Cells[0].Value?.ToString()))
                    {
                        roomList[rowIndex] = e.Row.Cells[0].Value?.ToString();
                    }

                    if (!string.IsNullOrWhiteSpace(e.Row.Cells[1].Value?.ToString()))
                    {
                        labList[rowIndex] = e.Row.Cells[1].Value?.ToString();
                    }
                }
            


        }

        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loop through all controls on the form
            foreach (Control control in Controls)
            {
                // Check if the control is not the MenuStrip
                if (!(control is MenuStrip))
                {
                    // Hide the control by setting its Visible property to false
                    control.Visible = false;
                }
            }
            Controls.Add(database_panel_settings); // Add database_panel_settings first
            Controls.Add(panel_time);             // Add panel_time later
            // Ensure that the parent controls of panel_time are visible
            panel_time.Parent.Visible = true;

            // Make panel_time visible
            panel_time.Visible = true;



        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void panel_time_Paint(object sender, PaintEventArgs e)
        {

        }

        private void laber_time_Click(object sender, EventArgs e)
        {
        }

        private void save_new_time_Click(object sender, EventArgs e)
        {
            try
            {
                string text1 = start_time_1.Text;
                string text2 = given_time_2.Text;
               

                if (double.TryParse(text1, out given_time1) && double.TryParse(text2, out given_time2))
                {
                    MessageBox.Show("Time up value: " + given_time1);
                    Globals.GivenTime1 = given_time1;
                    Globals.GivenTime2 = given_time2;
                    MessageBox.Show("Time down value: " + given_time2);
                 
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
            }
          





        }

        private void save_room_Click(object sender, EventArgs e)
        {
            Globals.labList = labList;
            Globals.roomList= roomList;
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loop through all controls on the form
            foreach (Control control in Controls)
            {
                // Check if the control is not the MenuStrip
                if (!(control is MenuStrip))
                {
                    // Hide the control by setting its Visible property to false
                    control.Visible = false;
                }
            }
            // Ensure that the parent controls of database_panel_settings are visible
            database_panel_settings.Parent.Visible = true;

            // Make database_panel_settings and its child controls visible
            database_panel_settings.Visible = true;
            con_string.Visible = true;
            database_instra_settings.Visible = true;
            database_panel_settings.Controls.Add(save_database_settings);
            database_panel_settings.Controls.Add(con_string);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void con_string_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.connectionStringDefault=con_string.Text;
            Globals.Finished_shedule = Finish_table_name.Text;
            Globals.Table_schedule = Start_table_name.Text;
         

        }
    }
}
