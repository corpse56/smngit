insert into ALPHA..NOTES (IDSUMMON,CREATED,IDUSER,NOTE)
select ID,'20150303',1,case when NOTE is null then '' else NOTE end from ALPHA..SUMMON

insert into ALPHA..NOTES (IDSUMMON,CREATED,IDUSER,NOTE)
select ID,'20150303',1,case when otkcomment is null then '' else otkcomment end from ALPHA..SUMMON

insert into ALPHA..NOTES (IDSUMMON,CREATED,IDUSER,NOTE)
select IDSUMMON,'20150303',1,case when PRIVATENOTE is null then '' else PRIVATENOTE end from ALPHA..PRIVATENOTES

delete from ALPHA..NOTES  where CREATED = '20150303' and NOTE = ''


alter table ALPHA..SUMMON add SHILD nvarchar(max)
alter table ALPHA..SUMMON add PLANKA nvarchar(max)
alter table ALPHA..SUMMON add SBORKA3D nvarchar(max)





DECLARE @CREATED datetime;

SET @CREATED = '20150303 03:00:00';
UPDATE ALPHA..NOTES
SET @CREATED = CREATED = DATEADD(s, 1, @CREATED)
where ID >=36


alter FUNCTION f_MAINVIEW (@IDUSER INT)
RETURNS TABLE
AS
RETURN
   

select A.ID id, A.IDS ids, W.WPNAME wname, B.CNAME cust,D.SNAME sts, C.CHANGED dt,C.CAUSE cause, N.NOTE note,
A.PTIME ptime,
case when A.PASSDATE is null then 'не определено' else  CONVERT(VARCHAR(11), A.PASSDATE, 104) end passd,
A.IDSTATUS idstatus,cast(SUBSTRING(A.IDS,6,2)+SUBSTRING(A.IDS,1,4) as int) ids_srt,A.VIEWED vw,A.QUANTITY qty
,SV.DATEVIEWED dview, A.PASSDATECHANGED pdc,N.CREATED ncre
from dbo.SUMMON A
left join dbo.CUSTOMERS B on A.IDCUSTOMER = B.ID
left join dbo.CURSTATUS C on A.IDS = C.IDS and 
		   C.ID = (select max(ID) from dbo.CURSTATUS SS where SS.IDS = A.IDS)
left join dbo.STATUSLIST D on C.STATID = D.ID
left join dbo.WPNAMELIST W on A.IDWP = W.ID
left join dbo.NOTES N on N.IDSUMMON = A.ID
left join dbo.SUMMONVIEWS SV on SV.IDSUMMON = A.ID and SV.IDUSER = @IDUSER
where (N.CREATED = (select top 1 MAX(CREATED) from dbo.NOTES NN where NN.IDSUMMON = A.ID ) or N.CREATED is null)
and (SV.DATEVIEWED = (select MAX(SVV.DATEVIEWED) from dbo.SUMMONVIEWS SVV where SVV.IDSUMMON = A.ID and SVV.IDUSER = @IDUSER) or SV.DATEVIEWED is null)
   
   



select * from f_MAINVIEW(1)
