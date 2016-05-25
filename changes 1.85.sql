USE [ALPHA]
GO

/****** Object:  Table [dbo].[VERSIONINFO]    Script Date: 03/01/2016 18:45:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VERSIONINFO](
	[VERSIONNUMBER] [int] NULL
) ON [PRIMARY]

GO


SELECT  [ID]
      ,[IDS]
      ,[SHILD]
      ,[PLANKA]
      ,[SBORKA3D]
      ,[ZHGUT]
      ,[SERIAL]
      ,[COMPOSITION]
      ,[METAL]
  FROM [ALPHA].[dbo].[SUMMON]
  
  update [ALPHA].[dbo].[SUMMON] set
  [SHILD] = '<нет>'
	where SHILD like '%Данные отсутствуют%' or SHILD like '%Данные временно отсутствуют%'
	
	  update [ALPHA].[dbo].[SUMMON] set
  [PLANKA] = '<нет>'
	where [PLANKA] like '%Данные отсутствуют%' or [PLANKA] like '%Данные временно отсутствуют%'
	
  update [ALPHA].[dbo].[SUMMON] set
  [SBORKA3D] = '<нет>'
	where [SBORKA3D] like '%Данные отсутствуют%' or [SBORKA3D] like '%Данные временно отсутствуют%'
	
  update [ALPHA].[dbo].[SUMMON] set
  [ZHGUT] = '<нет>'
	where [ZHGUT] like '%Данные отсутствуют%' or [ZHGUT] like '%Данные временно отсутствуют%'
	
  update [ALPHA].[dbo].[SUMMON] set
  [SERIAL] = '<нет>'
	where [SERIAL] like '%Данные отсутствуют%' or [SERIAL] like '%Данные временно отсутствуют%'
  update [ALPHA].[dbo].[SUMMON] set
  [COMPOSITION] = '<нет>'
	where [COMPOSITION] like '%Данные отсутствуют%' or [COMPOSITION] like '%Данные временно отсутствуют%'
  update [ALPHA].[dbo].[SUMMON] set
  [METAL] = '<нет>'
	where [METAL] like '%Данные отсутствуют%' or [METAL] like '%Данные временно отсутствуют%'


