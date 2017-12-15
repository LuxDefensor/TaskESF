USE [ASKUE_StavropolEnergo]
GO

/****** Object:  Table [dbo].[t_Companies]    Script Date: 04.12.2017 10:22:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_Companies](
	[ID_Company] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_t_Companies] PRIMARY KEY CLUSTERED 
(
	[ID_Company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

