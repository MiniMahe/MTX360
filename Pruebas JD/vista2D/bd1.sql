USE [MTX360JD]
GO
/****** Object:  Table [dbo].[imagen]    Script Date: 26/04/2023 0:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imagen](
	[id] [int] NOT NULL,
	[aula] [varchar](max) NULL,
	[imagen] [varchar](max) NULL,
	[piso] [int] NULL,
	[cordenadas] [varchar](max) NULL,
	[url] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
