use ALPHA
go

alter table [WPNAMELIST] add WIRINGDIAGRAM	nvarchar(MAX)	
alter table [WPNAMELIST] add TECHREQ	nvarchar(MAX)	
alter table [WPNAMELIST] add SBORKA3D	nvarchar(MAX)	
alter table [WPNAMELIST] add MECHPARTS	nvarchar(MAX)	
alter table [WPNAMELIST] add SHILDS	nvarchar(MAX)	
alter table [WPNAMELIST] add PLANKA	nvarchar(MAX)	
alter table [WPNAMELIST] add SERIAL	nvarchar(MAX)	
alter table [WPNAMELIST] add PACKAGING	nvarchar(MAX)	
alter table [WPNAMELIST] add PASSPORT	nvarchar(MAX)	
alter table [WPNAMELIST] add [MANUAL]	nvarchar(MAX)	
alter table [WPNAMELIST] add PACKINGLIST	nvarchar(MAX)	
alter table [WPNAMELIST] add SOFTWARE	nvarchar(MAX)	
alter table [WPNAMELIST] alter column CONFIGURATION	nvarchar(MAX)	
--добавляем поля (require-field) для обозначения того нжно это поле или нет в данном изделии,
--а также эти поля будут указывать на то надо раскрашивать или нет.
--есть 4 таблицы внешних:
--RUNCARDLIST, CIRCUITBOARDLIST,CABLELIST,ZHGUTLIST
--две готовы, ещё две пришлют попозже
--в них отсылка на WPNAMELIST. для них тоже надо сделать require-field
alter table WPNAMELIST add COMPOSITIONREQ	bit default(0)
alter table WPNAMELIST add DIMENSIONALDRAWINGREQ	bit default(0)
alter table WPNAMELIST add POWERSUPPLYREQ		bit default(0)
alter table WPNAMELIST add CONFIGURATIONREQ		bit default(0)
alter table WPNAMELIST add WIRINGDIAGRAMREQ		bit default(0)
alter table WPNAMELIST add TECHREQREQ		bit default(0)
alter table WPNAMELIST add SBORKA3DREQ		bit default(0)
alter table WPNAMELIST add MECHPARTSREQ		bit default(0)
alter table WPNAMELIST add SHILDSREQ		bit default(0)
alter table WPNAMELIST add PLANKAREQ		bit default(0)
alter table WPNAMELIST add SERIALREQ		bit default(0)
alter table WPNAMELIST add PACKAGINGREQ		bit default(0)
alter table WPNAMELIST add PASSPORTREQ		bit default(0)
alter table WPNAMELIST add [MANUALREQ]		bit default(0)
alter table WPNAMELIST add PACKINGLISTREQ		bit default(0)
alter table WPNAMELIST add SOFTWAREREQ		bit default(0)
alter table WPNAMELIST add CABLELISTREQ bit default(0)
alter table WPNAMELIST add ZHGUTLISTREQ		bit default(0)
alter table WPNAMELIST add RUNCARDLISTREQ		bit default(0)
alter table WPNAMELIST add CIRCUITBOARDLISTREQ		bit default(0)


--Категории дроп и создать чтоб ID с единички начинались
USE [ALPHA]
GO

/****** Object:  Table [dbo].[CATEGORYLIST]    Script Date: 03/21/2016 14:24:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CATEGORYLIST]') AND type in (N'U'))
DROP TABLE [dbo].[CATEGORYLIST]
GO
USE [ALPHA]
GO
/****** Object:  Table [dbo].[CATEGORYLIST]    Script Date: 03/21/2016 14:24:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORYLIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORYNAME] [nvarchar](max) NOT NULL,
	[ENTITY] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_CATEGORYLIST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'НЕ ПРИСВОЕНО',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'ВСЕ',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'ИБП',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Кабели',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Видеомонитор',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Клавиатуры',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Кабели к УМН',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Рабочие станции',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Монохромный монитор',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Плоскопанельный вычислитель',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'Жгуты',	'WPNAMELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'НЕ ПРИСВОЕНО',	'CABLELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'ВСЕ',	'CABLELIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'НЕ ПРИСВОЕНО',	'ZHGUTLIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'ВСЕ',	'ZHGUTLIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'НЕ ПРИСВОЕНО',	'CIRCUITBOARDLIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'ВСЕ',	'CIRCUITBOARDLIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'НЕ ПРИСВОЕНО',	'RUNCARDLIST')
insert into CATEGORYLIST (	CATEGORYNAME,	ENTITY) values (	'ВСЕ',	'RUNCARDLIST')

update STATUSLIST set SNAME = 'Рекламация (цех)' where ID = 8

--новые таблицы:
--RUNCARD,CIRCUITBOARDS,ZHGUTS,CABLES
--CABLELIST,ZHGUTLIST
--RUNCARDLIST и CIRCUITBOARDLIST отложим пока что
USE [ALPHA]
GO

/****** Object:  Table [dbo].[CABLELIST]    Script Date: 03/20/2016 14:58:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CABLELIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CABLENAME] [nvarchar](max) NOT NULL,
	[IDCATEGORY] [int] NULL,
	[IDSUBCAT] [int] NULL,
	[DECNUM] [nvarchar](500) NULL,
	[DIMENSIONALDRAWING] [nvarchar](max) NULL,
	[CONNECTORS] [nvarchar](max) NULL,
	[CLENGTH] [nvarchar](1000) NULL,
	[NOTE] [nvarchar](max) NULL,
	[CREATED] [datetime] NULL,
 CONSTRAINT [PK_CABLELIST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


-----------------------------------------------------------------------------------------------

USE [ALPHA]
GO

/****** Object:  Table [dbo].[CABLES]    Script Date: 03/20/2016 15:07:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CABLES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDWP] [int] NOT NULL,
	[IDCABLE] [int] NOT NULL,
 CONSTRAINT [PK_CABLES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CABLES]  WITH CHECK ADD  CONSTRAINT [FK_CABLES_WPNAMELIST] FOREIGN KEY([IDWP])
REFERENCES [dbo].[WPNAMELIST] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[CABLES] CHECK CONSTRAINT [FK_CABLES_WPNAMELIST]
GO




--------------------------------------------------------------------------------------------------

USE [ALPHA]
GO

/****** Object:  Table [dbo].[CIRCUITBOARDS]    Script Date: 03/20/2016 15:00:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CIRCUITBOARDS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDWP] [int] NOT NULL,
	[CIRCUITBOARD] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CIRCUITBOARDS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[CIRCUITBOARDS]  WITH CHECK ADD  CONSTRAINT [FK_CIRCUITBOARDS_WPNAMELIST] FOREIGN KEY([IDWP])
REFERENCES [dbo].[WPNAMELIST] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[CIRCUITBOARDS] CHECK CONSTRAINT [FK_CIRCUITBOARDS_WPNAMELIST]
GO


-----------------------------------------------------------------------------------------
USE [ALPHA]
GO

/****** Object:  Table [dbo].[RUNCARDS]    Script Date: 03/20/2016 15:01:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RUNCARDS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDWP] [int] NOT NULL,
	[RUNCARD] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RUNCARDS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[RUNCARDS]  WITH CHECK ADD  CONSTRAINT [FK_RUNCARDS_WPNAMELIST] FOREIGN KEY([IDWP])
REFERENCES [dbo].[WPNAMELIST] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[RUNCARDS] CHECK CONSTRAINT [FK_RUNCARDS_WPNAMELIST]
GO


----------------------------------------------------------------------------------------------
USE [ALPHA]
GO

/****** Object:  Table [dbo].[ZHGUTLIST]    Script Date: 03/20/2016 15:02:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ZHGUTLIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ZHGUTNAME] [nvarchar](max) NOT NULL,
	[IDCATEGORY] [int] NULL,
	[IDSUBCAT] [int] NULL,
	[DECNUM] [nvarchar](500) NULL,
	[ZHGUTPATH] [nvarchar](max) NULL,
	[NOTE] [nvarchar](max) NULL,
	[CREATED] [datetime] NULL,
 CONSTRAINT [PK_ZHGUTLIST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


---------------------------------------------------------------------------------------------------
USE [ALPHA]
GO

/****** Object:  Table [dbo].[ZHGUTS]    Script Date: 03/20/2016 15:02:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ZHGUTS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDWP] [int] NOT NULL,
	[IDZHGUT] [int] NOT NULL,
 CONSTRAINT [PK_ZHGUTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ZHGUTS]  WITH CHECK ADD  CONSTRAINT [FK_ZHGUTS_WPNAMELIST] FOREIGN KEY([IDWP])
REFERENCES [dbo].[WPNAMELIST] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ZHGUTS] CHECK CONSTRAINT [FK_ZHGUTS_WPNAMELIST]
GO




update WPNAMELIST set
      [COMPOSITIONREQ] = 0
      ,[DIMENSIONALDRAWINGREQ] = 0
      ,[POWERSUPPLYREQ] = 0
      ,[CONFIGURATIONREQ] = 0
      ,[WIRINGDIAGRAMREQ] = 0
      ,[TECHREQREQ] = 0
      ,[SBORKA3DREQ] = 0
      ,[MECHPARTSREQ] = 0
      ,[SHILDSREQ] = 0
      ,[PLANKAREQ] = 0
      ,[SERIALREQ] = 0
      ,[PACKAGINGREQ] = 0
      ,[PASSPORTREQ] = 0
      ,[MANUALREQ] = 0
      ,[PACKINGLISTREQ] = 0
      ,[SOFTWAREREQ] = 0
      ,[CABLELISTREQ] = 0
      ,[ZHGUTLISTREQ] = 0
      ,[RUNCARDLISTREQ] = 0
      ,[CIRCUITBOARDLISTREQ] = 0
      
alter table WPNAMELIST alter column     [COMPOSITIONREQ] bit not null
alter table WPNAMELIST alter column          [DIMENSIONALDRAWINGREQ]  bit not null
      alter table WPNAMELIST alter column    [POWERSUPPLYREQ]  bit not null
      alter table WPNAMELIST alter column    [CONFIGURATIONREQ]  bit not null
      alter table WPNAMELIST alter column    [WIRINGDIAGRAMREQ]  bit not null
      alter table WPNAMELIST alter column    [TECHREQREQ]  bit not null
      alter table WPNAMELIST alter column    [SBORKA3DREQ]  bit not null
      alter table WPNAMELIST alter column    [MECHPARTSREQ]  bit not null
      alter table WPNAMELIST alter column    [SHILDSREQ]  bit not null
      alter table WPNAMELIST alter column    [PLANKAREQ]  bit not null
      alter table WPNAMELIST alter column    [SERIALREQ]  bit not null
      alter table WPNAMELIST alter column    [PACKAGINGREQ]  bit not null
      alter table WPNAMELIST alter column    [PASSPORTREQ]  bit not null
      alter table WPNAMELIST alter column    [MANUALREQ]  bit not null
      alter table WPNAMELIST alter column    [PACKINGLISTREQ]  bit not null
      alter table WPNAMELIST alter column    [SOFTWAREREQ]  bit not null
      alter table WPNAMELIST alter column    [CABLELISTREQ]  bit not null
      alter table WPNAMELIST alter column    [ZHGUTLISTREQ]  bit not null
      alter table WPNAMELIST alter column    [RUNCARDLISTREQ]  bit not null
      alter table WPNAMELIST alter column    [CIRCUITBOARDLISTREQ]  bit not null
      
      update [ALPHA].[dbo].[WPNAMELIST] set DIMENSIONALDRAWING = null 
  where DIMENSIONALDRAWING = '' or DIMENSIONALDRAWING = '<нет>'
  
    update [ALPHA].[dbo].[WPNAMELIST] set CONFIGURATION = null 
  where CONFIGURATION = '' or CONFIGURATION = '<нет>'
  
    update [ALPHA].[dbo].[WPNAMELIST] set COMPOSITION = null 
  where COMPOSITION = '' or COMPOSITION = '<нет>'  
   
       update [ALPHA].[dbo].SUMMON set SHILD = null 
  where SHILD = '' or SHILD = '<нет>'  
       update [ALPHA].[dbo].SUMMON set PLANKA = null 
  where PLANKA = '' or PLANKA = '<нет>'  
       update [ALPHA].[dbo].SUMMON set SBORKA3D = null 
  where SBORKA3D = '' or SBORKA3D = '<нет>'  
       update [ALPHA].[dbo].SUMMON set ZHGUT = null 
  where ZHGUT = '' or ZHGUT = '<нет>'  
       update [ALPHA].[dbo].SUMMON set SERIAL = null 
  where SERIAL = '' or SERIAL = '<нет>'  
       update [ALPHA].[dbo].SUMMON set COMPOSITION = null 
  where COMPOSITION = '' or COMPOSITION = '<нет>'  
       update [ALPHA].[dbo].SUMMON set METAL = null 
  where METAL = '' or METAL = '<нет>'  
   
   USE [ALPHA]
GO

/****** Object:  Trigger [dbo].[CATEGORY_DELETE]    Script Date: 03/20/2016 16:12:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------------------------------

USE [ALPHA]
GO
/****** Object:  Trigger [dbo].[CATEGORY_DELETE]    Script Date: 03/24/2016 21:34:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CATEGORY_DELETE] ON [dbo].[CATEGORYLIST] 
	AFTER DELETE
AS 
set nocount on;

DECLARE @delid int
DECLARE @entity nvarchar(max)
DECLARE @neprisvoeno int
set @delid = (select top 1 deleted.ID from deleted)
set @entity = (select deleted.ENTITY from deleted)

delete SUBCATEGORYLIST from SUBCATEGORYLIST sc where IDCATEGORY = @delid;

if @entity='WPNAMELIST'
begin
	update WPNAMELIST set IDSUBCAT = null 
	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted)
	
	
	set @neprisvoeno = (select top 1 CATEGORYLIST.ID from CATEGORYLIST 
						where CATEGORYLIST.CATEGORYNAME = 'НЕ ПРИСВОЕНО'  and CATEGORYLIST.ENTITY = 'WPNAMELIST')

	update WPNAMELIST set IDCATEGORY = @neprisvoeno 
	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted);
end
if @entity='CABLELIST'
begin
	update CABLELIST set IDSUBCAT = null 
	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted)
	
	set @neprisvoeno = (select top 1 ID from CATEGORYLIST 
						where CATEGORYLIST.CATEGORYNAME = 'НЕ ПРИСВОЕНО'  and CATEGORYLIST.ENTITY = 'CABLELIST')

	update CABLELIST set IDCATEGORY = @neprisvoeno 
	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted);
end
if @entity='ZHGUTLIST'
begin
	update ZHGUTLIST set IDSUBCAT = null 
	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted)
	
	set @neprisvoeno = (select top 1 CATEGORYLIST.ID from CATEGORYLIST 
						where CATEGORYLIST.CATEGORYNAME = 'НЕ ПРИСВОЕНО'  and CATEGORYLIST.ENTITY = 'ZHGUTLIST')

	update ZHGUTLIST set IDCATEGORY = @neprisvoeno 
	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted);
end
--if @entity='RUNCARDLIST'
--begin
--	update RUNCARDLIST set IDSUBCAT = null 
--	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted)
	
--	set @neprisvoeno = (select top 1 deleted.ID from deleted 
--						where deleted.CATEGORYNAME = 'Не присвоено'  and deleted.ENTITY = 'RUNCARDLIST')

--	update RUNCARDLIST set IDCATEGORY = @neprisvoeno 
--	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted);
--end
--if @entity='CIRCUITBOARDLIST'
--begin
--	update CIRCUITBOARDLIST set IDSUBCAT = null 
--	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted)
	
--	set @neprisvoeno = (select top 1 deleted.ID from deleted 
--						where deleted.CATEGORYNAME = 'Не присвоено'  and deleted.ENTITY = 'CIRCUITBOARDLIST')

--	update CIRCUITBOARDLIST set IDCATEGORY = @neprisvoeno 
--	where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted);
--end




--------------------------------------------------------------------------------

USE [ALPHA]
GO
/****** Object:  Trigger [dbo].[CATEGORY_INSERT]    Script Date: 03/23/2016 18:49:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER [dbo].[CATEGORY_INSERT] ON [dbo].[CATEGORYLIST] 
	AFTER INSERT
AS 
set nocount on;


insert into SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) 
select inserted.ID,'НЕ ПРИСВОЕНО' from inserted
where inserted.ENTITY != 'ВСЕ' and inserted.ENTITY != 'НЕ ПРИСВОЕНО'
--NOt exists (select 1 from CATEGORYLIST A where A.CATEGORYNAME = 'НЕ ПРИСВОЕНО' and A.ENTITY = inserted.ENTITY)

insert into SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) 
select inserted.ID,'ВСЕ' from inserted 
where inserted.ENTITY != 'ВСЕ' and inserted.ENTITY != 'НЕ ПРИСВОЕНО'
--NOt exists (select 1 from CATEGORYLIST A where A.CATEGORYNAME = 'ВСЕ' and A.ENTITY = inserted.ENTITY)





----------------------------------------------------------------------------------
USE [ALPHA]
GO
/****** Object:  Trigger [dbo].[SUBCATEGORY_DELETE]    Script Date: 03/21/2016 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER TRIGGER [dbo].[SUBCATEGORY_DELETE] ON [dbo].[SUBCATEGORYLIST] 
	AFTER DELETE
AS 
set nocount on;

DECLARE @delid int
DECLARE @delidcat int
DECLARE @entity nvarchar

set @delid = (select top 1 deleted.ID from deleted)
set @delidcat = (select top 1 deleted.IDCATEGORY from deleted)
set @entity = (select top 1 B.ENTITY from SUBCATEGORYLIST A join CATEGORYLIST B on A.IDCATEGORY = B.ID)
if @entity = 'WPNAMELIST'
begin
		update WPNAMELIST 
		set IDSUBCAT = (
			select ID 
			from SUBCATEGORYLIST 
			where IDCATEGORY = @delidcat and SUBCATNAME = 'НЕ ПРИСВОЕНО'
		) 
		where IDSUBCAT = @delid;--(select top 1 deleted.ID from deleted)
end
if @entity = 'CABLELIST'
begin
		update CABLELIST 
		set IDSUBCAT = (
			select ID 
			from SUBCATEGORYLIST 
			where IDCATEGORY = @delidcat and SUBCATNAME = 'НЕ ПРИСВОЕНО'
		) 
		where IDSUBCAT = @delid;--(select top 1 deleted.ID from deleted)
end
if @entity = 'ZHGUTLIST'
begin
		update ZHGUTLIST 
		set IDSUBCAT = (
			select ID 
			from SUBCATEGORYLIST 
			where IDCATEGORY = @delidcat and SUBCATNAME = 'НЕ ПРИСВОЕНО'
		) 
		where IDSUBCAT = @delid;--(select top 1 deleted.ID from deleted)
end
--также для всех справочников




------------------------------------------------------------------------------------------
--добавим поле для оперделения типа справочника
alter table SUMMON add WPTYPE NVARCHAR(50)
update SUMMON set WPTYPE = 'WPNAMELIST'
alter table SUMMON alter column WPTYPE NVARCHAR(50) not null
---------------------------------------------------------------------------------------------
--меняем в извещениях IDWP кабелей, поскольку справочник кабелей теперь отдельно
--
--удаляем подкатегории категории кабели
delete from SUBCATEGORYLIST where ID in (3,4)
--переносим подкатегории кабелей
update SUBCATEGORYLIST set IDCATEGORY = 12 where IDCATEGORY = 4
--удаляем категорию кабели
delete from CATEGORYLIST where ID = 4
--переносим текущие извещения по кабелям в таблицу, предназначенную для кабелей

insert into CABLELIST (CABLENAME,IDCATEGORY,IDSUBCAT,DECNUM,DIMENSIONALDRAWING,NOTE,CREATED)
select distinct WPNAME,12,31,DECNUM,COMPOSITION,NOTE,CREATED from WPNAMELIST where IDCATEGORY = 4

update SUMMON set WPTYPE = 'CABLELIST' 
where ID in (select A.ID from SUMMON A
			left join WPNAMELIST B on A.IDWP = B.ID
			where B.IDCATEGORY = 4)


with F0 as (
			select B.* from SUMMON A
			left join WPNAMELIST B on A.IDWP = B.ID
			where B.IDCATEGORY = 4),
F1 as (			
select distinct A.ID idwp,F0.ID id from F0
left join CABLELIST A on A.DECNUM = F0.DECNUM and A.CABLENAME = F0.WPNAME			
)
update SUMMON set IDWP = (select idwp from F1 where SUMMON.IDWP = F1.id)
where ID in (select A.ID from SUMMON A
			left join WPNAMELIST B on A.IDWP = B.ID
			where B.IDCATEGORY = 4)
--на случай ошибки держим базу perenos		
--update ALPHA..SUMMON set IDWP = (select IDWP from perenos..SUMMON A where SUMMON.ID = A.ID)



---------------------------------------------------------------------------------------------
--меняем в извещениях IDWP жгутов, поскольку справочник жгутов теперь отдельно
--
use ALPHA
go

--удаляем подкатегории категории жгуты
delete from ALPHA..SUBCATEGORYLIST where ID in (27,28)
--переносим подкатегории жгутов
update ALPHA..SUBCATEGORYLIST set IDCATEGORY = 14 where IDCATEGORY = 11
--удаляем категорию кабели
delete from ALPHA..CATEGORYLIST where ID = 11
--переносим текущие извещения по кабелям в таблицу, предназначенную для кабелей
insert into ALPHA..ZHGUTLIST (ZHGUTNAME,IDCATEGORY,IDSUBCAT,DECNUM,ZHGUTPATH,NOTE,CREATED)
select distinct WPNAME,12,31,DECNUM,COMPOSITION,NOTE,CREATED from ALPHA..WPNAMELIST where IDCATEGORY = 11

update SUMMON set WPTYPE = 'ZHGUTLIST' 
where ID in (select A.ID from SUMMON A
			left join WPNAMELIST B on A.IDWP = B.ID
			where B.IDCATEGORY = 11)


with F0 as (
			select B.* from SUMMON A
			left join WPNAMELIST B on A.IDWP = B.ID
			where B.IDCATEGORY = 11)
,F1 as (			
select distinct A.ID idwp,F0.ID id from F0
left join ZHGUTLIST A on A.DECNUM = F0.DECNUM and A.ZHGUTNAME = F0.WPNAME			
)
update ALPHA..SUMMON set IDWP = (select idwp from F1 where SUMMON.IDWP = F1.id)
where ID in (select A.ID from SUMMON A
			left join WPNAMELIST B on A.IDWP = B.ID
			where B.IDCATEGORY = 11)
--на случай ошибки держим базу perenos		
--update ALPHA..SUMMON set IDWP = (select IDWP from perenos..SUMMON A where SUMMON.ID = A.ID)
---------------------------------------------------------------------------------------------
--переносим кабеля с неприсвоенной категорией в справочник кабелей и удаляем их
insert into ALPHA..CABLELIST (CABLENAME,IDCATEGORY,IDSUBCAT,DECNUM,DIMENSIONALDRAWING,NOTE,CREATED)
select  WPNAME,12,31,DECNUM,COMPOSITION,NOTE,CREATED 
from ALPHA..WPNAMELIST 
where WPNAME like lower('%кабел%')
or WPNAME like lower('%удлини%')

delete from ALPHA..WPNAMELIST where  WPNAME like lower('%кабел%')
or WPNAME like lower('%удлини%')
--------------------------------------------------------------------------------------------
--переносим данные из сущности извещение в сущность изделие
--потом как нибудь поля надо удалить лишние из сущности извещение
update A
set A.COMPOSITION = (select COMPOSITION 
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
, A.SHILDS = (select  C.SHILD
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
, A.PLANKA = (select  C.PLANKA
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
, A.SBORKA3D = (select  C.SBORKA3D
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
--, A.ZHGUT = (select  
--					 from ALPHA..SUMMON C
--					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
--					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
--					 )
, A.SERIAL = (select  C.SERIAL
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
, A.MECHPARTS = (select  C.METAL
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
, A.TECHREQ = (select  C.TECHREQPATH
					 from ALPHA..SUMMON C
					 where C.IDWP = A.ID and C.WPTYPE = 'WPNAMELIST'
					 and C.CREATED = (select MAX(CREATED) from ALPHA..SUMMON D where D.IDWP = C.IDWP)
					 )
					 
from ALPHA..WPNAMELIST A
 join ALPHA..SUMMON B on A.ID = B.IDWP and B.WPTYPE = 'WPNAMELIST'
where A.ID = B.IDWP

update ALPHA..WPNAMELIST
set TECHREQ = null where TECHREQ = ''

update ALPHA..WPNAMELIST
set COMPOSITIONREQ = 1 where COMPOSITION is not null

update ALPHA..WPNAMELIST
set SHILDSREQ = 1 where SHILDS is not null

update ALPHA..WPNAMELIST
set PLANKAREQ = 1 where PLANKA is not null

update ALPHA..WPNAMELIST
set SBORKA3DREQ = 1 where SBORKA3D is not null

update ALPHA..WPNAMELIST
set SERIALREQ = 1 where SERIAL is not null

update ALPHA..WPNAMELIST
set MECHPARTSREQ = 1 where MECHPARTS is not null

update ALPHA..WPNAMELIST
set TECHREQREQ = 1 where TECHREQ is not null
---------------------------------------------------------------------------------------------
--добавляем новые роли
insert into ALPHA..ROLES (ROLENAME) values ('Инженер')
insert into ALPHA..ROLES (ROLENAME) values ('Схемотехник')
insert into ALPHA..ROLES (ROLENAME) values ('Технолог')
insert into ALPHA..ROLES (ROLENAME) values ('ОТД')
---------------------------------------------------------------------------------------------
alter table ALPHA..CABLES add CNT int not null
alter table ALPHA..ZHGUTS add CNT int not null
---------------------------------------------------------------------------------------------
--удалить из подкатегорий лишние подкатегории

---------------------------------------------------------------------------------------------

--удалить ненужные таблицы extcablepack 

--удалить ненужные таблицы COMPARCHIVE, PRIVATENOTES

----------------------------------------------------------------------------------------------
--апдейтим поле WPTYPE, так как уже присутствовали кабели в производстве

  update A
  set  A.IDWP = B.ID
  from [ALPHA].[dbo].[SUMMON] A
  left join ALPHA..CABLELIST B ON A.WPNAME = B.CABLENAME
  where A.WPNAME = B.CABLENAME
  
    update A
  set  A.IDWP = B.ID
  from [ALPHA].[dbo].[SUMMON] A
  left join ALPHA..CABLELIST B ON A.WPNAME = B.CABLENAME + ' ' +B.DECNUM
  where A.WPNAME = B.CABLENAME + ' ' +B.DECNUM
  
  update [ALPHA].[dbo].[SUMMON] 
  set IDWP = 105 where IDWP = 198
  update [ALPHA].[dbo].[SUMMON] 
  set IDWP = 107 where IDWP = 208
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
----------------------------------------------------------------------------------------------
USE ALPHA
GO
/****** Object:  UserDefinedFunction [dbo].[f_MAINVIEW]    Script Date: 03/30/2016 20:02:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[f_MAINVIEW] (@IDUSER INT)
RETURNS TABLE
AS
RETURN
   

select A.ID id, A.IDS ids,
 case when W.WPNAME IS not null then W.WPNAME + ' ' +ISNULL(W.DECNUM,'') else
 case when ZHG.ZHGUTNAME is not null then ZHG.ZHGUTNAME + ' ' + ISNULL(ZHG.DECNUM,'') else
 CAB.CABLENAME + ' ' +isnull(CAB.DECNUM,'') end  end wname,
 
  B.CNAME cust,
  D.SNAME sts, 
case when A.IDSUBST = 0 then 'Не присвоено' else SUB.SNAME end subst,

case when A.SISP = 0 then 'Нет' else 'Да' end sisp,W.TECHREQ techreq,

 N.NOTE note,
A.PTIME ptime,
case when A.PASSDATE is null then 'не определено' else  CONVERT(VARCHAR(11), A.PASSDATE, 104) end passd,

A.IDSTATUS idstatus,
A.IDSUBST idsubst,
cast(SUBSTRING(A.IDS,6,2)+SUBSTRING(A.IDS,1,4) as int) ids_srt,
A.VIEWED vw,
A.QUANTITY qty
,SV.DATEVIEWED dview,
 A.PASSDATECHANGED pdc,
 N.CREATED ncre,
case when (W.SHILDS is null and W.SHILDSREQ = 1
or W.PLANKA is null and W.PLANKAREQ =1
or W.SBORKA3D is null and W.SBORKA3DREQ =1
or W.MECHPARTS is null  and W.MECHPARTSREQ =1
or W.DIMENSIONALDRAWING is null  and W.DIMENSIONALDRAWINGREQ =1
or W.PACKAGING is null  and W.PACKAGINGREQ =1) and A.IDSTATUS not in (1,2,13,14)
then 1 else 0 end paint_constr,
case when (W.COMPOSITION is null and W.COMPOSITIONREQ=1 
or W.TECHREQ is null and W.TECHREQREQ =1
or W.CONFIGURATION is null and W.CONFIGURATIONREQ =1) and A.IDSTATUS not in (1,2,13,14) 
then 1 else 0 end paint_inzh,
case when W.SERIAL is null and W.SERIALREQ = 1 and A.IDSTATUS not in (1,2,13,14) then 1 else 0 end paint_otk,
case when PM.SHILDSFORORDER is null or PM.SHILDSFORORDER=0 and A.IDSTATUS not in (1,2,13,14) then 0 else PM.SHILDSFORORDER end shild_ordered,
case when (W.WIRINGDIAGRAM is null) and W.WIRINGDIAGRAMREQ=1 and A.IDSTATUS not in (1,2,13,14) then 1 else 0 end paint_shemotehnik,
case when (W.PASSPORT is null and W.PASSPORTREQ=1 
or  W.[MANUAL] is null and W.MANUALREQ=1 
or  W.PACKINGLIST is null and W.PACKINGLISTREQ=1 ) and A.IDSTATUS not in (1,2,13,14)
then 1 else 0 end paint_OTD
--case when (W.WIRINGDIAGRAM is null) and W.WIRINGDIAGRAMREQ=1 then 1 else 0 end paint_tehnolog,

from dbo.SUMMON A
left join dbo.CUSTOMERS B on A.IDCUSTOMER = B.ID
left join dbo.CURSTATUS C on A.IDS = C.IDS and 
		   C.ID = (select max(ID) from dbo.CURSTATUS SS where SS.IDS = A.IDS)
left join dbo.STATUSLIST D on C.STATID = D.ID
left join dbo.STATUSLIST SUB on A.IDSUBST = SUB.ID
left join dbo.WPNAMELIST W on A.IDWP = W.ID and A.WPTYPE = 'WPNAMELIST'
left join dbo.ZHGUTLIST ZHG on A.IDWP = ZHG.ID and A.WPTYPE = 'ZHGUTLIST'
left join dbo.CABLELIST CAB on A.IDWP = CAB.ID and A.WPTYPE = 'CABLELIST'
left join dbo.NOTES N on N.IDSUMMON = A.ID
left join dbo.SUMMONVIEWS SV on SV.IDSUMMON = A.ID and SV.IDUSER = @IDUSER
left join dbo.PURCHASEDMATERIALS PM on A.ID = PM.IDS
where (N.CREATED = (select top 1 MAX(CREATED) from dbo.NOTES NN where NN.IDSUMMON = A.ID )
 or N.CREATED is null)
and (SV.DATEVIEWED = 
(select MAX(SVV.DATEVIEWED) from dbo.SUMMONVIEWS SVV where SVV.IDSUMMON = A.ID and SVV.IDUSER = @IDUSER) or SV.DATEVIEWED is null)
   

   