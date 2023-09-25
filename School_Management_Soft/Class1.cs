using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   The 'Globals' class serves as a central repository for storing global configuration settings and shared data
   that are used throughout the School Management Software application. It is designed as a static class, making
   it easily accessible from any part of the application without the need for instantiation.

   Purpose and Rationale:
   
   1. **Configuration Settings**:
      - This class stores various configuration settings that are used across different components of the application.
        These settings include default time values, connection strings, and table names.

   2. **Shared Data**:
      - Lists of room names and lab names are included here, making them easily accessible for tasks such as
        populating dropdown lists or validating user inputs.

   3. **Centralization**:
      - By centralizing configuration and shared data in this class, it promotes consistency and ensures that
        changes to these values are reflected throughout the application without the need to update them in multiple places.

   4. **Ease of Maintenance**:
      - When application-wide settings or data need to be modified or extended, developers can make the necessary
        changes in this single class rather than hunting down every reference throughout the codebase.

   5. **Flexibility**:
      - The class can be extended with additional properties or values as the application evolves, ensuring that
        new global requirements can be easily accommodated.
*/


namespace School_Management_Soft
{
    public static class Globals
    {
        public static double GivenTime1 { get; set; } = 20.0; // Default values
        public static double GivenTime2 { get; set; } = 6.0;

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
