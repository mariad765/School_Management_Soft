USE [test_database]
GO
/****** Object:  Table [dbo].[Finished_shedule]    Script Date: 9/25/2023 9:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Finished_shedule](
	[User_ID] [int] NULL,
	[First Name] [varchar](50) NULL,
	[Last Name] [varchar](50) NULL,
	[Subject] [varchar](50) NULL,
	[Room] [varchar](50) NULL,
	[Time_Start] [time](7) NULL,
	[Time_End] [time](7) NULL,
	[Day_Of_Week] [nchar](10) NULL,
	[Unique_id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Unique_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Id_Time_Day] UNIQUE NONCLUSTERED 
(
	[User_ID] ASC,
	[Time_Start] ASC,
	[Day_Of_Week] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Room_Time_Start_Day] UNIQUE NONCLUSTERED 
(
	[Room] ASC,
	[Time_Start] ASC,
	[Time_End] ASC,
	[Day_Of_Week] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Room_Time_Start_Day_ID] UNIQUE NONCLUSTERED 
(
	[User_ID] ASC,
	[Room] ASC,
	[Time_Start] ASC,
	[Time_End] ASC,
	[Day_Of_Week] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_schedule]    Script Date: 9/25/2023 9:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_schedule](
	[First Name] [varchar](50) NULL,
	[Last Name] [varchar](50) NULL,
	[Subject] [varchar](50) NULL,
	[Preferred Room] [char](10) NULL,
	[Preferred Time] [time](7) NULL,
	[Classes/week] [int] NULL,
	[User ID] [int] NULL,
	[NewKeyColumn] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NewKeyColumn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
