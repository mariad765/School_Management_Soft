using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Soft
{
    public static class Globals
    {
        public static double GivenTime1 { get; set; } = 20.0; // Default value
        public static double GivenTime2 { get; set; } = 6.0;  // Default value

        public static  List<string> roomList = new List<string>
        {
             "Room A", "Room B", "Room C", "Room D", "Room E", "Room F","Room G", "Room H", "Room I", "Room J", "Room K"
        };

        public static List<string> labList = new List<string>
        {
              "Lab A", "Lab B", "Lab C", "Lab D", "Lab E", "Lab F","Lab G", "Lab H", "Lab I", "Lab J", "Lab K"
        };
        public static string connectionStringDefault = "Data Source=localhost; Initial Catalog=test_database; Integrated Security=True";
        public static string Finished_shedule = "Finished_shedule";
        public static string Table_schedule = "Table_Schedule";
    }
}
