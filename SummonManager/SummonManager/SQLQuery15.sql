/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [ID]
      ,[IDNTYPE]
      ,[IDSUMMON]
  FROM [ALPHA].[dbo].[NOTIFICATIONS]
  
  
  delete from [ALPHA].[dbo].[NOTIFICATIONS]
  
  if not exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] A where A.IDNTYPE = 1 and A.IDSUMMON in (
  select ID from [ALPHA].[dbo].SUMMON where (SERIAL is null or SERIAL = '') and SERIALREQ = 1
  )
  )
  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON)
  values (1,204)


  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON)
  select 1,ID from [ALPHA].[dbo].SUMMON A where (SERIAL is null or SERIAL = '') and SERIALREQ = 1
  and NOT exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] B 
					where B.IDNTYPE = 1 and B.IDSUMMON = A.ID)