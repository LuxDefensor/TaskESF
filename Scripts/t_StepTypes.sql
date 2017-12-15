USE [ASKUE_StavropolEnergo]
GO

/****** Object:  Table [dbo].[t_StepTypes]    Script Date: 04.12.2017 10:23:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_StepTypes](
	[ID_Type] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
	[AllowedToManager] [bit] NOT NULL,
	[AllowedToTechnician] [bit] NOT NULL,
	[OpensTask] [bit] NOT NULL,
	[ClosesTask] [bit] NOT NULL,
 CONSTRAINT [PK_t_StepTypes] PRIMARY KEY CLUSTERED 
(
	[ID_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[t_StepTypes] ADD  DEFAULT ((1)) FOR [AllowedToManager]
GO

ALTER TABLE [dbo].[t_StepTypes] ADD  DEFAULT ((1)) FOR [AllowedToTechnician]
GO

ALTER TABLE [dbo].[t_StepTypes] ADD  DEFAULT ((0)) FOR [OpensTask]
GO

ALTER TABLE [dbo].[t_StepTypes] ADD  DEFAULT ((0)) FOR [ClosesTask]
GO

