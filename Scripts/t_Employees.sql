USE [ASKUE_StavropolEnergo]
GO

/****** Object:  Table [dbo].[t_Employees]    Script Date: 04.12.2017 10:23:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[t_Employees](
	[ID_Employee] [int] IDENTITY(1,1) NOT NULL,
	[ID_User] [int] NOT NULL,
	[FullName] [varchar](255) NOT NULL,
	[Administrator] [bit] NOT NULL,
	[Manager] [bit] NOT NULL,
	[ID_Department] [int] NOT NULL,
	[Phone1] [varchar](30) NULL,
	[Phone2] [varchar](30) NULL,
	[CellPhone] [varchar](30) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_t_Employees] PRIMARY KEY CLUSTERED 
(
	[ID_Employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[t_Employees] ADD  DEFAULT ((0)) FOR [Administrator]
GO

ALTER TABLE [dbo].[t_Employees] ADD  DEFAULT ((0)) FOR [Manager]
GO

