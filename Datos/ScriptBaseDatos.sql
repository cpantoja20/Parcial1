CREATE DATABASE [covid19];
USE  [covid19]

CREATE TABLE [dbo].[Estampilla](
	[nContrato] [numeric](5) NOT NULL PRIMARY KEY,
	[oContrato] [nvarchar](50) NULL,
	[vrContrato] [numeric](10) NULL,
	[apoyaEmergenciaCovid19] [nvarchar](2) NULL,
	[vrEstampilla] [numeric](18, 0) NULL,
) 
GO

COMMIT