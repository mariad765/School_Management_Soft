using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Input;
using System.Xml.Linq;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace School_Management_Soft
{
    public partial class School_Management : Form
    {
        public School_Management()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=test_database; Integrated Security=True");
            con.Open();
            int classesPerWeek = Convert.ToInt32(textBox_number_of_classes.Text); // Assuming you have an input field for classes per week
            int uniqueID = GenerateUniqueIntID($"{textBox_fn.Text}{textBox_ln.Text}");



            SqlCommand cmd = new SqlCommand("INSERT INTO Table_schedule ([User ID], [First Name], [Last Name], [Subject], [Classes/week], [Preferred Room], [Preferred Time]) VALUES (@ID, @FirstName, @LastName, @Subject, @number_of_classes, @room, @time)", con);
            cmd.Parameters.AddWithValue("@ID", uniqueID);
            cmd.Parameters.AddWithValue("@FirstName", textBox_fn.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox_ln.Text);
            cmd.Parameters.AddWithValue("@Subject", textBox_subj.Text);
            cmd.Parameters.AddWithValue("@number_of_classes", textBox_number_of_classes.Text);
            string selectedRoom = dropdown_room.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@room", selectedRoom);
            string selectedTimeString = dropdown_time.SelectedItem.ToString();
            TimeSpan selectedTime = TimeSpan.Parse(selectedTimeString);
            cmd.Parameters.AddWithValue("@time", selectedTime);


            cmd.ExecuteNonQuery();

            LoadDataIntoDataGridView();
            con.Close();

            MessageBox.Show("Successfully inserted");
        }

        private void LoadDataIntoDataGridView()
        {
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = test_database; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_schedule", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private int GenerateUniqueIntID(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                int uniqueIntID = BitConverter.ToInt32(hashBytes, 0); // Convert the first 4 bytes to an integer
                uniqueIntID = Math.Abs(uniqueIntID);
                return uniqueIntID;
            }
        }

        private void ClearForm()
        {
            textBox_fn.Text = ""; // Clear textboxes
            textBox_ln.Text = ""; // Clear textboxes
            textBox_subj.Text = ""; // Clear textboxes
            textBox_number_of_classes.Text = ""; // Clear textboxes
            dropdown_time.SelectedIndex = 0; // Reset combobox selection
            dropdown_room.SelectedIndex = 0;
            // Clear other controls as needed
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void textBox_number_of_classes_TextChanged(object sender, EventArgs e)
        {

        }
        private string firstName;
        private string lastName;
        private string subject;
        private string preferredRoom;
        private TimeSpan preferredTime;
        private int classesPerWeek;
        private int userId;
        static int zero = 0;
        private struct SuitableTimeSlot
        {
            public TimeSpan TimeSlot { get; set; }
            public string Room { get; set; }
            public int Index_day_of_week { get; set; }
            // Constructor with parameters
            public SuitableTimeSlot(TimeSpan timeSlot, string room, int dayOfWeek)
            {
                TimeSlot = timeSlot;
                Room = room;
                Index_day_of_week = dayOfWeek;
            }

            // Static method to return default value
            public static SuitableTimeSlot Default()
            {
                return new SuitableTimeSlot(TimeSpan.Zero, string.Empty, -1);
            }
        }

        private List<string> roomList = new List<string>
        {
             "Room A", "Room B", "Room C", "Room D", "Room E", "Room F","Room G", "Room H", "Room I", "Room J", "Room K"
        };

        private List<string> labList = new List<string>
        {
              "Lab A", "Lab B", "Lab C", "Lab D", "Lab E", "Lab F","Lab G", "Lab H", "Lab I", "Lab J", "Lab K"
        };
        private List<string> usedRooms = new List<string>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=test_database; Integrated Security=True");

            // int currentRowIndex = 0;
            int capacity = 10; // Set an initial capacity for the arrays
            string[] firstNames = new string[capacity];
            string[] lastNames = new string[capacity];
            string[] subjects = new string[capacity];
            string[] preferredRooms = new string[capacity];
            TimeSpan[] preferredTimes = new TimeSpan[capacity];
            int[] classesPerWeeks = new int[capacity];
            int[] userIds = new int[capacity];

            int currentIndex = 0;

            try
            {
                con.Open();

                SqlDataReader userReader = GetUsers(con);



                if (userReader.HasRows)
                {
                    while (userReader.Read())
                    {
                        if (!userReader.IsDBNull(0))
                        {
                            if (currentIndex >= capacity)
                            {
                                // If the current index exceeds the capacity, resize the arrays
                                capacity *= 2; // Double the capacity
                                Array.Resize(ref firstNames, capacity);
                                Array.Resize(ref lastNames, capacity);
                                Array.Resize(ref subjects, capacity);
                                Array.Resize(ref preferredRooms, capacity);
                                Array.Resize(ref preferredTimes, capacity);
                                Array.Resize(ref classesPerWeeks, capacity);
                                Array.Resize(ref userIds, capacity);
                            }

                            // Get user information
                            firstNames[currentIndex] = userReader.GetString(0);
                            lastNames[currentIndex] = userReader.GetString(1);
                            subjects[currentIndex] = userReader.GetString(2);
                            preferredRooms[currentIndex] = userReader.GetString(3);
                            preferredTimes[currentIndex] = userReader.GetTimeSpan(4);
                            classesPerWeeks[currentIndex] = userReader.GetInt32(5);
                            userIds[currentIndex] = userReader.GetInt32(6);

                            currentIndex++;
                        }
                        else
                        {
                            MessageBox.Show("First Name is NULL. Stopping processing.");


                        }

                    }
                }
                else
                {
                    MessageBox.Show("No data found.");


                }

                userReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                con.Close();
                //  continueProcessing = false;

            }
            for (int i = 0; i < currentIndex; i++)
            { 
                for (int j = 0; j < classesPerWeeks[i]; j++)
                {
                        roomList = new List<string>
                        {
                 "Room A", "Room B", "Room C", "Room D", "Room E", "Room F","Room G", "Room H", "Room I", "Room J", "Room K"
                        };

                        labList = new List<string>
                        {
                          "Lab A", "Lab B", "Lab C", "Lab D", "Lab E", "Lab F","Lab G", "Lab H", "Lab I", "Lab J", "Lab K"
                        };
                        usedRooms = new List<string>();
                    
                    // Taking into account the preferences, try 
                    SuitableTimeSlot suitableTimeSlot = RandomChoiceTimeSlot(preferredTimes[i], preferredRooms[i]);
                    bool successful = false;

                    TryInsertion(successful,suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);

  



                }
            }
            // trecem toate informatiile in noul tabel din baza de date


        }

        private void TryInsertion(bool insertedSuccessfully,SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {

            string connectionString = "Data Source=localhost;Initial Catalog=test_database;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Finished_shedule (User_ID, [First Name], [Last Name], Subject, Room, Time_Start, Time_End, Day_Of_Week) " +
                                  "VALUES (@UserID, @FirstName, @LastName, @Subject, @Room, @suitableTimeSlot, @TimeEnd, @DayOfWeek)";


                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    string[] daysOfWeek_strings = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
                    command.Parameters.AddWithValue("@UserID", userIds[i]);
                    command.Parameters.AddWithValue("@FirstName", firstNames[i]);
                    command.Parameters.AddWithValue("@LastName", lastNames[i]);
                    command.Parameters.AddWithValue("@Subject", subjects[i]);
                    command.Parameters.AddWithValue("@Room", suitableTimeSlot.Room);
                    command.Parameters.AddWithValue("@suitableTimeSlot", suitableTimeSlot.TimeSlot);
                    command.Parameters.AddWithValue("@TimeEnd", suitableTimeSlot.TimeSlot.Add(TimeSpan.FromHours(2)));
                    command.Parameters.AddWithValue("@DayOfWeek", daysOfWeek_strings[suitableTimeSlot.Index_day_of_week]);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();

                        insertedSuccessfully = true; // Mark the insert as successful
                    }
                    catch (SqlException ex)
                    {
                        // Check if the exception is due to a unique key violation
                        if (ex.Number == 2601 || ex.Number == 2627)
                        {
                            // Handle the unique key violation error here
                            // Generate new values for Room, Time_Start, or Day_Of_Week
                            // Update the command parameters with the new values

                            //Generate for day_of week first:
                            FindNewDay(insertedSuccessfully, ref zero, suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
                            zero = 0;
                            if (!insertedSuccessfully)
                            { 
                                FindNewRoom(insertedSuccessfully, ref zero, suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
                                zero = 0;
                            }
                            // zero = 0;
                            // ChangeTimeUp(suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
                            // ChangeTimeDown(suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);

                        }
                        else
                        {

                            throw;
                        }
                    }

                    if (!insertedSuccessfully)
                    {
                        MessageBox.Show("No Periods available");
                        // Handle the case when insert attempts were unsuccessful after retrying
                        // You can log an error or take appropriate action
                        // Depending on your application, you may want to throw an exception here
                    }

                   
                }

                connection.Close();
            }


        }
        static SqlDataReader GetUsers(SqlConnection connection)
        {
            string query = "SELECT  [First Name], [Last Name], Subject, [Preferred Room], [Preferred Time], [Classes/week], [User ID] FROM Table_schedule"; // Adjust the query according to your schema


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        private void FindNewDay(bool insertedSuccessfully, ref int counter, SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            if ((counter < 5)&&(insertedSuccessfully==false))
            {
                suitableTimeSlot.Index_day_of_week = GetNextDayOfWeek(suitableTimeSlot.Index_day_of_week);
                counter++;
                TryInsertion(insertedSuccessfully,suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
               
            }
            else
            {
                // If you've tried all possible days, don't make another recursive call
                return;
            }
        }
        private void FindNewRoom(bool insertedSuccessfully,ref int  zero, SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i) 
        {
            if ((zero<10)&&(insertedSuccessfully==false))
            {
                // The list is not empty
                suitableTimeSlot.Room=GetAvailableRoom(suitableTimeSlot.Room);
                zero++;
                TryInsertion(insertedSuccessfully, suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
             
            }
            else
            {
                // If you've tried all possible days, don't make another recursive call
                return;
            }

        }

        private void ChangeTimeUp(bool insertedSuccessfully, SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            TimeSpan timeSlot = suitableTimeSlot.TimeSlot;
            TimeSpan twoHours = TimeSpan.FromHours(2);
        
            TimeSpan targetTime = TimeSpan.FromHours(20); // 8:00pm as a TimeSpan
            if (timeSlot!= targetTime)
            {
             timeSlot = timeSlot.Add(twoHours);
             suitableTimeSlot.TimeSlot = timeSlot;
             TryInsertion(insertedSuccessfully,suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);

            }
            else
            {
                // If you've tried all possible days, don't make another recursive call
                return;
            }

        }
        private void ChangeTimeDown(bool insertedSuccessfully,SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            TimeSpan timeSlot = suitableTimeSlot.TimeSlot;
            TimeSpan twoHours = TimeSpan.FromHours(-2);
            timeSlot = timeSlot.Add(twoHours);
            TimeSpan targetTime = TimeSpan.FromHours(6); // 6:00am as a TimeSpan
            if (timeSlot != targetTime)
            {
                timeSlot = timeSlot.Add(twoHours);
                suitableTimeSlot.TimeSlot = timeSlot;
                TryInsertion(insertedSuccessfully,suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);

            }
            else
            {
                // If you've tried all possible days, don't make another recursive call
                return;
            }

        }


        private SuitableTimeSlot RandomChoiceTimeSlot(TimeSpan preferredTime, string preferredRoom)
         {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            SuitableTimeSlot randomGen = SuitableTimeSlot.Default();

            int daysCount = daysOfWeek.Length;
            randomGen.Room = preferredRoom;
            randomGen.TimeSlot= preferredTime;
            randomGen.Index_day_of_week= random.Next(daysOfWeek.Length);

            return randomGen;
         }
      
       
       
    

        static Random random = new Random();

        static int GetNextDayOfWeek(int randomIndex)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            int daysCount = daysOfWeek.Length;
            int nextIndex = (randomIndex + 1) % daysCount;

            return nextIndex;
        }

        string GetAvailableRoom(string inputRoom)
        {

            if (!usedRooms.Contains(inputRoom))
            {
                usedRooms.Add(inputRoom);

            }

            List<string> selectedList;
            roomList.Add(inputRoom);
            labList.Add(inputRoom);

            if (roomList.Contains(inputRoom))
            {
                selectedList = roomList; 
            }
            else if (labList.Contains(inputRoom))
            {
                selectedList = labList; 
            }
            else
            {
                selectedList = roomList;
                MessageBox.Show(inputRoom); // Handle the case when the input room is not in either list
            }
            roomList.Remove(inputRoom);
            labList.Remove(inputRoom);

            foreach (string room in selectedList)
            {
                if (!usedRooms.Contains(room))
                {
                  // usedRooms.Add(room); // Mark the room as used
                    return room;
                }
            }
            return "No Room";
        }

    }
}


