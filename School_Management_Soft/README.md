# School Management Scheduling System 
The School Scheduling System is a specialized software solution focused on optimizing the scheduling processes within educational institutions.

Project made using SQL, C# and .NET in Visual Studio and Microsoft SQL Server Management Studio.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Introduction

This user-friendly system empowers administrators to efficiently manage class timetables, assignments, and classroom resources, ensuring a seamless and conflict-free educational environment

## Features

List the key features of your project.

- Streamlined Scheduling: Seamlessly create and manage class schedules, minimizing conflicts and maximizing resource utilization.
- Assignment: Professors can chooseto specific classes and subjects based on their expertise and availability.
- Classroom Allocation: Allocate classrooms and resources intelligently, avoiding double-bookings and overcrowding, also based on user's room preferrences.
- Customizable Constraints: Adapt the system to institution's unique scheduling constraints and requirements.
- Configuration Options: data base string and table names, room names and times available.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following prerequisites installed on your system:

- **.NET Framework 5.0 (Optional as you can do the setup in VS)s**: The system is built using .NET, so you need to have .NET Framework 5.0 or later installed. You can download it from [here](https://dotnet.microsoft.com/download).
- **SQL Server**: The system relies on a SQL Server database to store and manage school data. You can install SQL Server locally or connect to a remote SQL Server instance.
- **SQL Database**: You will also need your own database with the specified constraints.
- **Visual Studio**: While not mandatory, having Visual Studio installed can make development and testing more convenient. You can download Visual Studio from [here](https://visualstudio.microsoft.com/).
- **iTextSharp**: This library is used for PDF generation within the system. You can find more information and download it [here](https://www.nuget.org/packages/iTextSharp/).

### Installation

Step-by-step instructions on how to install and configure your project. Include any necessary code examples.


1. Clone the repository to your local machine:

   ```shell
   git clone https://github.com/mariad765/School_Management_Soft
   ```
 2. Open the project in Visual Studio.
 3. Build and run the project and access the settings to set up the database connection string and other specific variables like names of room, times.
 4. Make sure your database has the relevant constrains.

 ## Usage
 
### Logging In

1. Open your web browser and navigate to the system's URL, typically `http://localhost:5000` unless configured differently.

2. You will be presented with the login page. Log in using your administrator credentials. If you don't have an account, please contact your system administrator for access.

### Dashboard

Upon logging in, you will land on the system's dashboard. The dashboard provides an overview of the system's status and important notifications.

### Managing Classes and Schedules

#### 1. Creating a Class:

- Click on the "Classes" or "Courses" section in the navigation menu.
- Select "Create New Class" or "Create New Course."
- Fill in the class/course details, including the name, teacher, subject, and time slot.
- Click "Save" to create the class/course.

#### 2. Editing a Class:

- Navigate to the "Classes" or "Courses" section.
- Click on the class/course you want to edit.
- Make the necessary changes and click "Save."

#### 3. Scheduling Classes:

- Go to the "Schedule" section in the navigation menu.
- Select the desired day and time slot.
- Assign classes to available time slots by clicking on them and selecting the class/course to schedule.

#### 4. Managing Teacher Assignments:

- Access the "Teachers" section in the navigation menu.
- Assign teachers to specific classes or courses by editing their profiles.

### Attendance and Grade Management

#### 1. Recording Attendance:

- In the "Attendance" section, choose the class and date for which you want to record attendance.
- Mark students as "Present," "Absent," or "Late" and save the attendance record.

#### 2. Managing Grades:

- Navigate to the "Grades" or "Progress" section.
- Select the class/course and student for which you want to input grades.
- Enter the grades for assignments, tests, and assessments.

### Communication

#### 1. Sending Notifications:

- Use the "Messaging" or "Notifications" section to send important messages to teachers, students, or parents.
- Compose messages, select recipients, and send notifications.

### Reports and Analytics

#### 1. Generating Reports:

- Access the "Reports" or "Analytics" section to generate various reports, such as attendance reports, grade summaries, and class schedules.
- Customize report parameters and generate downloadable PDF reports.

### Logging Out

Remember to log out of the system when you are done to ensure the security of your account and data.

# Navigate to the project directory
cd your-repo

# Install dependencies (if applicable)
npm install
