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
using System.Reflection;
using System.CodeDom.Compiler;
using System.Security.Policy;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

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
            // Get the initial data table into the data grid
            LoadDataIntoDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_number_of_classes_TextChanged(object sender, EventArgs e)
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

        // Variables for managing the tables in database
        private string groupNameClass;
        private string firstTableName;
        private string seccondTableName;

        //............................................................................................,,,,,,,.....,,//
        //......................................Function for adding entries................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        private void bt_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=test_database; Integrated Security=True");
            con.Open();

            // Get the number of classes per week from the input field
            int classesPerWeek = Convert.ToInt32(textBox_number_of_classes.Text);

            // Generate a unique ID based on the first name and last name
            int uniqueID = GenerateUniqueIntID($"{textBox_fn.Text}{textBox_ln.Text}");

            SqlCommand cmd = new SqlCommand($"INSERT INTO {firstTableName} ([User ID], [First Name], [Last Name], [Subject], [Classes/week], [Preferred Room], [Preferred Time]) VALUES (@ID, @FirstName, @LastName, @Subject, @number_of_classes, @room, @time)", con);

            cmd.Parameters.AddWithValue("@ID", uniqueID);
            cmd.Parameters.AddWithValue("@FirstName", textBox_fn.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox_ln.Text);
            cmd.Parameters.AddWithValue("@Subject", textBox_subj.Text);
            cmd.Parameters.AddWithValue("@number_of_classes", textBox_number_of_classes.Text);

            // Get preferred room
            string selectedRoom = dropdown_room.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@room", selectedRoom);

            // Get preferred time start
            string selectedTimeString = dropdown_time.SelectedItem.ToString();
            TimeSpan selectedTime = TimeSpan.Parse(selectedTimeString);
            cmd.Parameters.AddWithValue("@time", selectedTime);

            cmd.ExecuteNonQuery();

            // For each entry refresh the data grid table
            LoadDataIntoDataGridView();

            con.Close();

            // Possible error messages
            MessageBox.Show("Successfully inserted");
        }
        //.................................................................................................,,,,,,,,,//


        //............................................................................................,,,,,,,.....,,//
        //..............................Function for loading data into grid................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//

        private void LoadDataIntoDataGridView()
        {
            if (!PanelCover.Visible) 
            { 
                using (SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = test_database; Integrated Security = True"))
                {
                    con.Open();
                    string sqlQuery = $"SELECT * FROM [{firstTableName}]"; 
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!PanelCover.Visible)
            { LoadDataIntoDataGridView(); }
        }
        //.................................................................................................,,,,,,,,,//


        //............................................................................................,,,,,,,.....,,//
        //................................Function for generating unique ID................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        // Description: the input is based on 'firstnamelastname' seccesion string..................................//
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
        //.................................................................................................,,,,,,,,,//


        //............................................................................................,,,,,,,.....,,//
        //.........................Function for Clearing the form when NEXT button is pressed..............,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        private void ClearForm()
        {
            textBox_fn.Text = ""; // Clear textboxes
            textBox_ln.Text = ""; 
            textBox_subj.Text = ""; 
            textBox_number_of_classes.Text = ""; 
            dropdown_time.SelectedIndex = 0; // Reset combobox selection
            dropdown_room.SelectedIndex = 0;
    
        }
        //.................................................................................................,,,,,,,,,//

        // Variables for extracting data from table
        private string firstName;
        private string lastName;
        private string subject;
        private string preferredRoom;
        private TimeSpan preferredTime;
        private int classesPerWeek;
        private int userId;

        // Variables for counters
        static int zero = 0;  // Used for counting days in a week
        static int counter1 = 0;  // counter for hours behind preffered time
        static int counter2 = 0;  // counter for hours after preffered time
     
        // Struct including time, room and day to keep all combos possible
        private struct SuitableTimeSlot
        {
            public TimeSpan TimeSlot { get; set; }
            public string Room { get; set; }
            public int Index_day_of_week { get; set; }
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

        //Predefined lists with rooms available and an additional empty list
        private List<string> roomList = new List<string>
        {
             "Room A", "Room B", "Room C", "Room D", "Room E", "Room F","Room G", "Room H", "Room I", "Room J", "Room K"
        };

        private List<string> labList = new List<string>
        {
              "Lab A", "Lab B", "Lab C", "Lab D", "Lab E", "Lab F","Lab G", "Lab H", "Lab I", "Lab J", "Lab K"
        };
        private List<string> usedRooms = new List<string>();

        //............................................................................................,,,,,,,.....,,//
        //...................Function for FINISH button to get all the data in the finished version...........,,,,,,//
        //.................................................................................................,,,,,,,,,//
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=test_database; Integrated Security=True");


            int capacity = 10; // Set an initial capacity for the arrays
            // Defined arrays for the data we'll get from the table completed in the data grid
            string[] firstNames = new string[capacity];
            string[] lastNames = new string[capacity];
            string[] subjects = new string[capacity];
            string[] preferredRooms = new string[capacity];
            TimeSpan[] preferredTimes = new TimeSpan[capacity];
            int[] classesPerWeeks = new int[capacity];
            int[] userIds = new int[capacity];
            int currentIndex = 0; // Number of Professors aka entries
            bool err = false;

            try
            {
                con.Open();

                // Read information from the table in data grid and put it into arrays

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
                            // Error handling messages
                            MessageBox.Show("First Name is NULL. Stopping processing.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                    err = true;
                }

                userReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                err = true;
            }
            finally
            {
                con.Close();
            }

            // For each Professor 
            for (int i = 0; i < currentIndex; i++)
            {
                // For each Class he has
                for (int j = 0; j < classesPerWeeks[i]; j++)
                {

                    // Reinit the lists for rooms available

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
                    bool successful = TryInsertion(suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);

                    // Save the initial variables to restatrt searches
                    TimeSpan init_time = suitableTimeSlot.TimeSlot;
                    string init_room = suitableTimeSlot.Room;

                    TimeSpan targetTime1 = TimeSpan.FromHours(20); // 8:00pm as a TimeSpan
                    TimeSpan targetTime2 = TimeSpan.FromHours(6); // 6:00am as a TimeSpan
                    counter2 = 0; // Init counters shall be 0
                    counter1 = 0;

                    /* Start searching a good time - room - day combo that doesnt involve colllisions
                     This code represents an algorithm for finding a suitable time slot, room, and day
                     to insert data for a scheduling application.It involves a multi - level loop structure
                     and various functions to achieve the following steps:
                     Outermost Loop:
                        -Continues until a successful insertion or until the suitableTimeSlot.TimeSlot is greater than targetTime2.
                     FineNewTimeDown:
                        -Attempts to find a suitable time slot before targetTime2.
                     Middle Loop:
                        -Continues until a successful insertion or until the suitableTimeSlot.TimeSlot is less than targetTime1.
                     FineNewTimeUp:
                        -Attempts to find a suitable time slot after targetTime1.
                     Inner Loop:
                        -Continues until a successful insertion or until a maximum number of used rooms(10) is reached.
                     FindNewRoom:
                        -Seeks an available room for the insertion.
                     Nested Loop:
                        -Continues until a successful insertion or until a maximum number of room - finding attempts(5) is reached.
                     FindNewDay:
                        -Searches for a suitable day for the insertion.
                     TryInsertion:
                        -Tries to insert data at the current time slot, room, and day.
                     If a successful insertion is achieved, the loops are broken, and the counter variables are reset.
                     If no suitable time slot, room, or day is found, usedRooms, roomList, and labList are reset.
                     If no suitable time slot is found within the outermost loop, a message is displayed indicating that no time is available.
                     This code is designed to handle scheduling scenarios by iteratively searching for available slots and making insertions
                     when a suitable slot is found.It relies on external functions and data structures to facilitate this scheduling process.
                     Care should be taken to ensure that the algorithm and data are properly initialized and handled.*/

                    while ((!successful) && (suitableTimeSlot.TimeSlot > targetTime2))
                    {
                        FineNewTimeDown(ref counter1, ref suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);


                        while ((!successful) && (suitableTimeSlot.TimeSlot < targetTime1))
                        {

                            FineNewTimeUp(ref counter2, ref suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);

                            while ((!successful) && (usedRooms.Count < 10))
                            {
                                FindNewRoom(ref zero, ref suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
                                while ((!successful) && (zero < 5))
                                {
                                    FindNewDay(ref zero, ref suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
                                    successful = TryInsertion(suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
                                    if (successful)
                                    {
                                        zero = 0;
                                        break;
                                    }
                                    if (zero == 5)
                                    {
                                        zero = 0;
                                        break;
                                    }

                                }
                                if (successful)
                                {
                                    break;
                                }
                                if (usedRooms.Count == 10)
                                {
                                    usedRooms.Clear();
                                    suitableTimeSlot.Room = init_room;
                                    break;
                                }

                            }
                            if (!successful)
                            {
                                usedRooms = new List<string>();
                                roomList = new List<string>
                                    {
                                      "Room A", "Room B", "Room C", "Room D", "Room E", "Room F","Room G", "Room H", "Room I", "Room J", "Room K"
                                    };

                                labList = new List<string>
                                    {
                                      "Lab A", "Lab B", "Lab C", "Lab D", "Lab E", "Lab F","Lab G", "Lab H", "Lab I", "Lab J", "Lab K"
                                    };

                            }
                            if (successful)
                            {
                                counter2 = 0;
                                break;
                            }
                            if (suitableTimeSlot.TimeSlot == targetTime1)
                            {
                                suitableTimeSlot.TimeSlot = init_time;
                                break;
                            }

                        }

                        if (successful)
                        {
                            counter2 = 0;
                            break;
                        }
                        if (suitableTimeSlot.TimeSlot == targetTime2)
                        {
                            counter2 = 0;
                            break;
                        }


                    }

                    if (!successful)
                    {
                        MessageBox.Show("No Time Available");
                        err = true;
                    }

                }
            }
            if (!err) { 
            // Assuming you have a string variable "dynamicTableName" that holds the table name
            string dynamicTableName = seccondTableName; // Replace with your dynamic table name

            // Retrieve data from the dynamic table
            DataTable dynamicTableData = RetrieveDataFromDynamicTable(dynamicTableName);

            if (dynamicTableData != null)
            {
                string filePath = $@"C:\Users\Maria\Downloads\{seccondTableName}.pdf"; // Specify the desired file path
                GeneratePDFFromTable(dynamicTableData, filePath);
                MessageBox.Show("PDF generated successfully.");
                PanelCover.Visible = true;
                AccessMain.Visible = true;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Error: Unable to retrieve data from the dynamic table.");
            }
        }
        }
        //.................................................................................................,,,,,,,,,//

        //............................................................................................,,,,,,,.....,,//
        //........................................Function for insertion......................................,,,,,,//
        //.................................................................................................,,,,,,,,,//

        private bool TryInsertion(SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            // This function will return a boolean if the insertion was successful or not
            bool insertedSuccessfully;
            string connectionString = "Data Source=localhost;Initial Catalog=test_database;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // The insertion will take place in 2 Tables. One is the table for each class and one is an additional table used to
                // avoid collisions
                string insertQuery = "INSERT INTO Finished_shedule (User_ID, [First Name], [Last Name], Subject, Room, Time_Start, Time_End, Day_Of_Week) " +
                                  "VALUES (@UserID, @FirstName, @LastName, @Subject, @Room, @suitableTimeSlot, @TimeEnd, @DayOfWeek)";
                string insertQuery2 = $"INSERT INTO {seccondTableName} (User_ID, [First Name], [Last Name], Subject, Room, Time_Start, Time_End, Day_Of_Week) " +
                                "VALUES (@UserID, @FirstName, @LastName, @Subject, @Room, @suitableTimeSlot, @TimeEnd, @DayOfWeek)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Insering into big gestion collision
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
                        insertedSuccessfully = true; // Mark the insert as successful
                       
                        using (SqlCommand secondTableCommand = new SqlCommand(insertQuery2, connection))
                        {
                            // Set parameters for the second table as needed
                            // This will take place only if no collisions were detectez 
                            secondTableCommand.Parameters.AddWithValue("@UserID", userIds[i]);
                            secondTableCommand.Parameters.AddWithValue("@FirstName", firstNames[i]);
                            secondTableCommand.Parameters.AddWithValue("@LastName", lastNames[i]);
                            secondTableCommand.Parameters.AddWithValue("@Subject", subjects[i]);
                            secondTableCommand.Parameters.AddWithValue("@Room", suitableTimeSlot.Room);
                            secondTableCommand.Parameters.AddWithValue("@suitableTimeSlot", suitableTimeSlot.TimeSlot);
                            secondTableCommand.Parameters.AddWithValue("@TimeEnd", suitableTimeSlot.TimeSlot.Add(TimeSpan.FromHours(2)));
                            secondTableCommand.Parameters.AddWithValue("@DayOfWeek", daysOfWeek_strings[suitableTimeSlot.Index_day_of_week]);

                            secondTableCommand.ExecuteNonQuery(); // Execute the query for the second table
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Check if the exception is due to a unique key violation
                        if (ex.Number == 2601 || ex.Number == 2627)
                        {
                            insertedSuccessfully = false;
                        }
                        else
                        {
                            MessageBox.Show("SQL Error: " + ex.Message);
                            insertedSuccessfully = false;
                        }
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
          return insertedSuccessfully;
        }
        //.................................................................................................,,,,,,,,,//

        /*To retrieve user information and manipulates scheduling parameters such as days of the week, rooms, and time slots 
        based on certain rules and input data. The key functions and their purposes are as follows:
           - `GetUsers`: Retrieves user data from a SQL database and returns it as a SqlDataReader.
           - `FindNewDay`: Finds a new day of the week for scheduling, updating the counter and SuitableTimeSlot accordingly.
           - `FindNewRoom`: Finds a new room for scheduling and updates the room property of SuitableTimeSlot.
           - `FineNewTimeUp`: Moves the scheduling time slot to a later time, incrementing counter2 and adjusting the time accordingly
           - `FineNewTimeDown`: Moves the scheduling time slot to an earlier time, incrementing counter1 and adjusting the time accordingly.
           - `ChangeTimeUp`: Adjusts the scheduling time by adding two hours based on the current counter.
           - `ChangeTimeDown`: Adjusts the scheduling time by subtracting two hours based on the current counter.
         It's important to note that this code is presented in isolation, and its role within a larger application is not entirely clear.*/
        

        private SqlDataReader GetUsers(SqlConnection connection)
        {
            string query = $"SELECT  [First Name], [Last Name], Subject, [Preferred Room], [Preferred Time], [Classes/week], [User ID] FROM {firstTableName}";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        private void FindNewDay(ref int counter, ref SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
                suitableTimeSlot.Index_day_of_week = GetNextDayOfWeek(suitableTimeSlot.Index_day_of_week);
                counter++;
        
                return;
         
        }
        private void FindNewRoom(ref int  zero, ref SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i) 
        {
          
                suitableTimeSlot.Room=GetAvailableRoom(suitableTimeSlot.Room);
          
            return;

        }
        private void FineNewTimeUp(ref int counter,ref SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        { 
            suitableTimeSlot.TimeSlot = ChangeTimeUp(ref  counter, suitableTimeSlot,  userIds, firstNames,  lastNames,  subjects,  i);
            counter2++;

            return;
        }
        private void FineNewTimeDown(ref int counter, ref SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            suitableTimeSlot.TimeSlot = ChangeTimeDown(ref counter, suitableTimeSlot, userIds, firstNames, lastNames, subjects, i);
            counter1++;

            return;
        }


        private TimeSpan ChangeTimeUp(ref int counter, SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            TimeSpan timeSlot = suitableTimeSlot.TimeSlot;
            TimeSpan twoHours = TimeSpan.FromHours(2);
            if (counter == 0)
                return timeSlot;
          
            timeSlot = timeSlot.Add(twoHours);

            return timeSlot;
            

        }
        private TimeSpan ChangeTimeDown(ref int counter, SuitableTimeSlot suitableTimeSlot, int[] userIds, string[] firstNames, string[] lastNames, string[] subjects, int i)
        {
            TimeSpan timeSlot = suitableTimeSlot.TimeSlot;
            TimeSpan twoHours = TimeSpan.FromHours(2);
            if (counter == 0)
                return timeSlot;

            timeSlot = timeSlot.Subtract(twoHours);

            return timeSlot;

        }

        //.................................................................................................,,,,,,,,,//
        /* The following function description:
          1. `RandomChoiceTimeSlot`:
      - This method generates a random SuitableTimeSlot based on a preferred time and room.
      - It initializes an array of days of the week.
      - Creates a new SuitableTimeSlot object using `SuitableTimeSlot.Default()`.
      - Sets the `Room` and `TimeSlot` properties of the generated SuitableTimeSlot based on provided `preferredTime` and `preferredRoom`.
      - Generates a random index to select a day of the week from the `daysOfWeek` array and assigns it to the `Index_day_of_week` property.
      - Returns the generated SuitableTimeSlot.

          2. `GetNextDayOfWeek`:
      - This method takes an integer `randomIndex` as input, presumably representing the current day of the week.
      - Initializes an array of days of the week.
      - Calculates the index of the next day of the week by adding 1 to `randomIndex` and taking the modulus of the total number of days in the week (5, in this case).
      - Returns the index of the next day of the week.*/


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
        //.................................................................................................,,,,,,,,,//
        /* Function description
           - It checks if the input room is not already in the list of used rooms.
           - If the input room is not in the list of used rooms, it marks it as used and returns it.
           - If the input room is already used, it proceeds with the following logic:
           - It adds the input room to two lists: `roomList` and `labList`.
           - It selects one of these lists based on whether the input room is in `roomList` or `labList`.
           - If the input room is not found in either list, it defaults to using `roomList` and displays a MessageBox.
           - It removes the input room from both `roomList` and `labList`.
           - It iterates through the selected list and returns the first room that is not marked as used.
           - If no available room is found, it returns "No Room."
        It's important to note that the behavior and correctness of this code depend on the context and how the `usedRooms`, 
        `roomList`, and `labList` collections are managed elsewhere in the code. The code may need to be integrated into
        a larger system, and the handling of MessageBox messages should be considered for user interaction. Additionally,
        proper synchronization mechanisms should be in place if this code is used in a multi-threaded environment.*/

        string GetAvailableRoom(string inputRoom)
        {

            if (!usedRooms.Contains(inputRoom))
            {
                usedRooms.Add(inputRoom);
                return inputRoom;

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
                    return room;
                }
            }
            return "No Room";
        }
        //.................................................................................................,,,,,,,,,//

        //............................................................................................,,,,,,,.....,,//
        //........................................Function for Accessing Main Form.............................,,,,,//
        //.................................................................................................,,,,,,,,,//
        private void AccessMain_Click(object sender, EventArgs e)
        {
            // Hide or remove the cover and button
            PanelCover.Visible = false;
            AccessMain.Visible = false;

            // Create new data tables in the database
            string groupName = GetSelectedGroupName(); 
            if (!TableExists(groupName))
            {
                CreateDataTablesFromExisting(groupName); 
            }
            else
            {
                /* - It checks if a table with the given group name exists in the database using the TableExists(groupName) method.
                - If the table does not exist, it creates new data tables in the database using the CreateDataTablesFromExisting(groupName) method. 
                This typically happens when a new group or project is accessed for the first time.
                - If the table already exists, it sets the names of two data tables (firstTableName and seccondTableName) based on the group name.
                These tables are used for subsequent data operations.*/

                string startTableName = $"{groupName}_StartTable";
                firstTableName = startTableName;
                string finishTableName = $"{groupName}_FinishTable";
                seccondTableName = finishTableName;
            }
            LoadDataIntoDataGridView();

        }
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//

        /* Function`TableExists(string tableNamePrefix)` description:
       - Checks if a table with a name starting with the provided prefix exists in the database.
       - It establishes a connection to the database using the specified connection string.
       - Executes an SQL query to count tables with names matching the given prefix.
       - Returns true if one or more matching tables exist, otherwise returns false.*/
        private bool TableExists(string tableNamePrefix)
        {
            // Replace with your database connection string
            string connectionString = "Data Source=localhost;Initial Catalog=test_database;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if a table with a name starting with the given prefix exists in the database
                string checkTableExistsSql = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME LIKE '{tableNamePrefix}%'";

                using (SqlCommand cmd = new SqlCommand(checkTableExistsSql, connection))
                {
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//

        /*Description of function `GetSelectedGroupName()`:
      - Retrieves the selected group name from a ComboBox control named "groupNameComboBox."
      - If a valid selection is made, it trims the group name by removing any characters after the first space.
      - Stores the selected group name in a class variable `groupNameClass` and returns it.
      - If no selection is made, it returns a default group name "DefaultGroupName."*/
        private string GetSelectedGroupName()
        {
           
            if (groupNameComboBox.SelectedIndex >= 0)
            {
                // Retrieve the selected group name from the ComboBox
                string selectedGroupName = groupNameComboBox.SelectedItem.ToString();
                int spaceIndex = selectedGroupName.IndexOf(' ');
                if (spaceIndex >= 0)
                {
                    selectedGroupName = selectedGroupName.Substring(0, spaceIndex);
                }
                groupNameClass = selectedGroupName;
                return selectedGroupName;
            }
            else
            {
                return "DefaultGroupName";
            }
        }
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
            /*Description of Function`CreateDataTablesFromExisting(string groupName)`:
          - Creates two new tables in the database based on the selected group name.
          - Constructs table names by appending "_StartTable" and "_FinishTable" to the provided group name.
          - Copies the structure (columns and constraints) of existing tables ("Finished_schedule" and "Table_schedule") into the new tables.
          - Uses SQL queries with `TOP 0` to copy the structure without copying any data.
          - Displays a success message if table creation is successful.
          - Handles any exceptions that may occur during table creation and shows an error message using a MessageBox.*/


        private void CreateDataTablesFromExisting(string groupName)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=test_database;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create table names based on the selected group name
                    string startTableName = $"{groupName}_StartTable";
                    firstTableName = startTableName;
                    string finishTableName = $"{groupName}_FinishTable";
                    seccondTableName = finishTableName;

                    // Get the table schema (structure) and constraints from an existing table
                    string getTableSchemaSql1 = $"SELECT TOP 0 * INTO [{finishTableName}] FROM Finished_shedule";
                    string getTableSchemaSql2 = $"SELECT TOP 0 * INTO [{startTableName}] FROM Table_schedule";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;

                        // Create the FinishTable by copying structure from the existing table
                        cmd.CommandText = getTableSchemaSql1;
                        cmd.ExecuteNonQuery();

                        // Create the StartTable by copying structure from the existing table
                        cmd.CommandText = getTableSchemaSql2;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Tables '{startTableName}' and '{finishTableName}' created successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during table creation
                MessageBox.Show("Error creating tables: " + ex.Message);
            }
        }
        //.................................................................................................,,,,,,,,,//

        //.................................................................................................,,,,,,,,,//
        //...........................Function to delete rows from the data grid table..........................,,,,,//
        //.................................................................................................,,,,,,,,,//

        private void delete_bt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // based on Primary Key
                int userID = Convert.ToInt32(selectedRow.Cells["NewKeyColumn"].Value);

                // Create a SQL connection and command to delete the row
                using (SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=test_database; Integrated Security=True"))
                {
                    con.Open();

                    string deleteQuery = $"DELETE FROM {firstTableName} WHERE [NewKeyColumn] = @UserID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }

                // Remove the row from the DataGridView
                dataGridView1.Rows.Remove(selectedRow);
            }
        }
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//
        //.................................................................................................,,,,,,,,,//



        // The following functions set some design GUI elements

        private void PanelCover_Paint(object sender, PaintEventArgs e)
        {
            PanelCover.BackColor = Color.FromArgb(47, 79, 79); // Dark Green
      
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            e.CellStyle.BackColor = Color.LightCyan;

        }
        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void ChooseClass_Click(object sender, EventArgs e)
        {

        }

        private void groupNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AccessMain_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void Title_Panel_Cover_Click(object sender, EventArgs e)
        {

        }

        private void GeneratePDFFromTable(DataTable table, string filePath)
        {
            // Create a new document
            Document document = new Document(); 
            string documentTitle =$"{seccondTableName}";
            int firstIndexOfUnderscore = documentTitle.IndexOf('_');
            int secondIndexOfUnderscore = documentTitle.IndexOf('_', firstIndexOfUnderscore + 1);
            int thirdIndexOfUnderscore = documentTitle.IndexOf('_', secondIndexOfUnderscore + 1);

            if (thirdIndexOfUnderscore != -1)
            {
                documentTitle = documentTitle.Substring(0, thirdIndexOfUnderscore);
            }

            try
            {
                // Create a PdfWriter instance to write to the file path
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

               
                // Open the document for writing
                document.Open();
                // Add the document title as a visible title
                if (!string.IsNullOrEmpty(documentTitle))
                {
                    Paragraph titleParagraph = new Paragraph(documentTitle);
                    titleParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(titleParagraph);
                }
                document.Add(new Paragraph(" ")); // Add an empty paragraph

                // Create a PdfPTable to represent the table in the PDF
                PdfPTable pdfTable = new PdfPTable(table.Columns.Count);

                // Add table headers
                foreach (DataColumn column in table.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    pdfTable.AddCell(cell);
                }

                // Add table data
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                        pdfTable.AddCell(cell);
                    }
                }

                // Add the table to the document
                document.Add(pdfTable);
            }
            catch (DocumentException de)
            {
                // Handle any document creation errors
                MessageBox.Show("Error creating PDF: " + de.Message);
            }
            catch (IOException ioe)
            {
                // Handle any IO errors
                MessageBox.Show("Error writing PDF: " + ioe.Message);
            }
            finally
            {
                // Close the document
                document.Close();
            }
        }
        private DataTable RetrieveDataFromDynamicTable(string tableName)
        {
            // Use the tableName to construct your SQL query to retrieve data from the dynamic table
            string connectionString = "Data Source=localhost; Initial Catalog=test_database; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {tableName}"; // Construct the query with the dynamic table name
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }


    }
}


