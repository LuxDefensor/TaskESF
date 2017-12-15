USE [ASKUE_StavropolEnergo]
GO

/****** Object:  Table [dbo].[t_TaskSteps]    Script Date: 04.12.2017 10:23:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_TaskSteps](
	[ID_Step] [int] IDENTITY(1,1) NOT NULL,
	[ID_Task] [int] NOT NULL,
	[StepType] [int] NOT NULL,
	[StepDate] [datetime] NOT NULL,
	[ID_Employee] [int] NOT NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_t_TaskSteps] PRIMARY KEY CLUSTERED 
(
	[ID_Step] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

