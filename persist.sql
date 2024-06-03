USE [Persist]
GO

/****** Object:  Table [dbo].[persist]    Script Date: 02/06/2024 22:59:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[persist]') AND type in (N'U'))
DROP TABLE [dbo].[persist]
GO

/****** Object:  Table [dbo].[persist]    Script Date: 02/06/2024 22:59:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[persist](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[concessionaria] [varchar](100) NULL,
	[ano_do_pnv_snv] [int] NULL,
	[tipo_de_radar] [varchar](100) NULL,
	[rodovia] [varchar](100) NULL,
	[uf] [char](2) NULL,
	[km_m] [varchar](10) NULL,
	[municipio] [varchar](100) NULL,
	[tipo_pista] [varchar](100) NULL,
	[sentido] [varchar](100) NULL,
	[situacao] [varchar](100) NULL,
	[data_da_inativacao] [datetime] NULL,
	[latitude] [varchar](20) NULL,
	[longitude] [varchar](20) NULL,
	[velocidade_leve] [int] NULL
) ON [PRIMARY]
GO


