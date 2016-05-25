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
  [SHILD] = '<���>'
	where SHILD like '%������ �����������%' or SHILD like '%������ �������� �����������%'
	
	  update [ALPHA].[dbo].[SUMMON] set
  [PLANKA] = '<���>'
	where [PLANKA] like '%������ �����������%' or [PLANKA] like '%������ �������� �����������%'
	
  update [ALPHA].[dbo].[SUMMON] set
  [SBORKA3D] = '<���>'
	where [SBORKA3D] like '%������ �����������%' or [SBORKA3D] like '%������ �������� �����������%'
	
  update [ALPHA].[dbo].[SUMMON] set
  [ZHGUT] = '<���>'
	where [ZHGUT] like '%������ �����������%' or [ZHGUT] like '%������ �������� �����������%'
	
  update [ALPHA].[dbo].[SUMMON] set
  [SERIAL] = '<���>'
	where [SERIAL] like '%������ �����������%' or [SERIAL] like '%������ �������� �����������%'
  update [ALPHA].[dbo].[SUMMON] set
  [COMPOSITION] = '<���>'
	where [COMPOSITION] like '%������ �����������%' or [COMPOSITION] like '%������ �������� �����������%'
  update [ALPHA].[dbo].[SUMMON] set
  [METAL] = '<���>'
	where [METAL] like '%������ �����������%' or [METAL] like '%������ �������� �����������%'


