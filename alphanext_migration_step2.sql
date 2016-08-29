--------------делаем ФК на жгутлист а не на продуктс и добавляем каскадное удаление
USE [ALPHANEXT]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ZHGUTS_PRODUCTS]') AND parent_object_id = OBJECT_ID(N'[dbo].[ZHGUTS]'))
ALTER TABLE [dbo].[ZHGUTS] DROP CONSTRAINT [FK_ZHGUTS_PRODUCTS]
GO

USE [ALPHANEXT]
GO

ALTER TABLE [dbo].[ZHGUTS]  WITH CHECK ADD  CONSTRAINT [FK_ZHGUTS_WPNAMELIST] FOREIGN KEY([IDWP])
REFERENCES [dbo].[WPNAMELIST] ([ID]) on delete cascade
GO

ALTER TABLE [dbo].[ZHGUTS] CHECK CONSTRAINT [FK_ZHGUTS_WPNAMELIST]
GO

-----------------------------------------------------
--делаем удаление каскадным
USE [ALPHANEXT]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ZHGUTS_ZHGUTLIST]') AND parent_object_id = OBJECT_ID(N'[dbo].[ZHGUTS]'))
ALTER TABLE [dbo].[ZHGUTS] DROP CONSTRAINT [FK_ZHGUTS_ZHGUTLIST]
GO

USE [ALPHANEXT]
GO

ALTER TABLE [dbo].[ZHGUTS]  WITH CHECK ADD  CONSTRAINT [FK_ZHGUTS_ZHGUTLIST] FOREIGN KEY([IDZHGUT])
REFERENCES [dbo].[ZHGUTLIST] ([ID]) on delete cascade
GO

ALTER TABLE [dbo].[ZHGUTS] CHECK CONSTRAINT [FK_ZHGUTS_ZHGUTLIST]
GO
---------------------------------
---------------------------------
---------------------------------
--тоже саое для кабелей
USE [ALPHANEXT]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CABLELIST]') AND parent_object_id = OBJECT_ID(N'[dbo].[CABLES]'))
ALTER TABLE [dbo].[CABLES] DROP CONSTRAINT [FK_CABLELIST]
GO

USE [ALPHANEXT]
GO

ALTER TABLE [dbo].[CABLES]  WITH CHECK ADD  CONSTRAINT [FK_CABLES_CABLELIST] FOREIGN KEY([IDCABLE])
REFERENCES [dbo].[CABLELIST] ([ID]) on delete cascade
GO

ALTER TABLE [dbo].[CABLES] CHECK CONSTRAINT [FK_CABLES_CABLELIST]
GO
------------------------------