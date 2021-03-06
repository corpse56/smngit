USE [ALPHA]
GO

/****** Object:  Table [dbo].[SUBCATEGORYLIST]    Script Date: 01/22/2016 17:48:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SUBCATEGORYLIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCATEGORY] [int] NOT NULL,
	[SUBCATNAME] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_SUBCATEGORYLIST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
--------------------------------------------------------------------------------------
alter table ALPHA..WPNAMELIST add IDSUBCAT int
-----------------------------------------------------------------------------------------
--====================================
--  Create database trigger template 
--====================================
USE ALPHA
GO

CREATE TRIGGER CATEGORY_INSERT ON CATEGORYLIST 
	AFTER INSERT
AS 
set nocount on;
insert into SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) 
select inserted.ID,'Все' from inserted

insert into SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) 
select inserted.ID,'Не присвоено' from inserted
GO
------------------------------------------------------------------------------------------
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (3,'Все')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (3,'Не присвоено')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (4,'Все')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (4,'Не присвоено')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (5,'Все')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (5,'Не присвоено')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (6,'Все')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (6,'Не присвоено')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (7,'Все')
insert into ALPHA..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (7,'Не присвоено')
--также посмотреть какие были добавлены и для них тоже вставить
--------------------------------------------------------------------------------------
USE [ALPHA]
GO
/****** Object:  Trigger [dbo].[CATEGORY_DELETE]    Script Date: 01/22/2016 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create TRIGGER [dbo].[CATEGORY_DELETE] ON [dbo].[CATEGORYLIST] 
	AFTER DELETE
AS 
set nocount on;

DECLARE @delid int
set @delid = (select top 1 deleted.ID from deleted)

delete SUBCATEGORYLIST from SUBCATEGORYLIST sc where IDCATEGORY = @delid;

update WPNAMELIST set IDSUBCAT = null 
where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted)

update WPNAMELIST set IDCATEGORY = 1 
where IDCATEGORY = @delid;--(select top 1 deleted.ID from deleted);

go
--------------------------------------------------------------------------------------
USE [ALPHA]
GO

/****** Object:  Trigger [dbo].[SUBCATEGORY_DELETE]    Script Date: 01/22/2016 19:31:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER TRIGGER [dbo].[SUBCATEGORY_DELETE] ON [dbo].[SUBCATEGORYLIST] 
	AFTER DELETE
AS 
set nocount on;

DECLARE @delid int
set @delid = (select top 1 deleted.ID from deleted)

update WPNAMELIST set IDSUBCAT = null 
where IDSUBCAT = @delid;--(select top 1 deleted.ID from deleted)
GO

--------------------