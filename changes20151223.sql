  
  alter table ALPHA..WPNAMELIST add IDCATEGORY int
  alter table ALPHA..WPNAMELIST add DECNUM nvarchar(500)
  alter table ALPHA..WPNAMELIST add COMPOSITION nvarchar(max)
  alter table ALPHA..WPNAMELIST add DIMENSIONALDRAWING nvarchar(max)
  alter table ALPHA..WPNAMELIST add POWERSUPPLY nvarchar(500)
  alter table ALPHA..WPNAMELIST add CONFIGURATION nvarchar(1000)
  alter table ALPHA..WPNAMELIST add NOTE nvarchar(max)
  update ALPHA..WPNAMELIST set IDCATEGORY = 1
  -----------------------------------------------------------------------------------------------
  USE [ALPHA]
GO

/****** Object:  Table [dbo].[CATEGORYLIST]    Script Date: 12/25/2015 15:41:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CATEGORYLIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORYNAME] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CATEGORYLIST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
-------------------------------------------------------------------------------------------------------
USE [ALPHA]
GO

/****** Object:  Table [dbo].[CURSTATUS]    Script Date: 01/08/2016 03:22:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CURSUBSTATUS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDS] [nvarchar](50) NULL,
	[STATID] [int] NOT NULL,
	[CAUSE] [nvarchar](max) NULL,
	[CHANGED] [datetime] NOT NULL,
	[IDUSER] [int] NULL,
 CONSTRAINT [PK_SUBSTATUS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-------------------------------------------------------------------------------------------------------
alter table [ALPHA].[dbo].[SUMMON] add IDSUBST int default(0)
go
update [ALPHA].[dbo].[SUMMON] set IDSUBST = 0
insert into STATUSLIST (SNAME) values ('СИ и СП (ОТК - Произ-во)')
update STATUSLIST set SNAME = 'Производство' where ID = 4
insert into STATUSLIST (SNAME) values ('СИ и СП (ОТК - Цех)')
insert into STATUSLIST (SNAME) values ('Производство после СИ и СП')
insert into STATUSLIST (SNAME) values ('Цех после СИ и СП')
update STATUSLIST set SNAME = 'Цех' where ID = 5
update STATUSLIST set SNAME = 'Подготовка (к производству) -=DELETED=- 3' where ID = 2
update STATUSLIST set SNAME = 'Возвращено из цеха -=DELETED=- 4' where ID = 6
update STATUSLIST set SNAME = 'Готово к отгрузке -=DELETED=- 12' where ID = 11
update STATUSLIST set SNAME = 'Рекламация -=DELETED=- 5' where ID = 8
update STATUSLIST set SNAME = 'Субстатус закрыт' where ID = 17
alter table ALPHA..SUMMON add BILLPAYED bit default(0)
alter table ALPHA..SUMMON add DOCSREADY bit default(0)
go
update ALPHA..SUMMON set BILLPAYED = 0,DOCSREADY = 0
insert into ALPHA..ROLES (ROLENAME) values ('Бухгалтер')
--------------------------------------------------------------
USE [ALPHA]
GO

/****** Object:  Table [dbo].[WPCOMPOSITIONARCHIVE]    Script Date: 01/14/2016 22:57:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WPCOMPOSITIONARCHIVE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDWP] [int] NOT NULL,
	[ARCPATH] [nvarchar](max) NOT NULL,
	[DATEARC] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--------------------------------------------------------------------------------
alter table ALPHA..WPNAMELIST add CREATED datetime null
update ALPHA..WPNAMELIST set CREATED = '20100101'
alter table ALPHA..WPCOMPOSITIONARCHIVE add FROMDATE datetime null



  