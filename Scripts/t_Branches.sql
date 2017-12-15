USE [ASKUE_StavropolEnergo]
GO

/****** Object:  Table [dbo].[t_Branches]    Script Date: 04.12.2017 10:22:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_Branches](
	[ID_Branch] [int] IDENTITY(1,1) NOT NULL,
	[ID_Company] [int] NOT NULL,
	[BranchName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_t_Branches] PRIMARY KEY CLUSTERED 
(
	[ID_Branch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

