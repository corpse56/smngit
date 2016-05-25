alter table ALPHA..SUMMON add PASSPORT nvarchar(max)
alter table ALPHA..SUMMON add MANUAL nvarchar(max)
alter table ALPHA..SUMMON add PACKINGLIST nvarchar(max)
alter table ALPHA..SUMMON add PASSPORTREQ bit
alter table ALPHA..SUMMON add MANUALREQ bit
alter table ALPHA..SUMMON add PACKINGLISTREQ bit
update ALPHA..SUMMON set PASSPORTREQ = 0, MANUALREQ = 0, PACKINGLISTREQ = 0

alter table ALPHA..WPNAMELIST add [LENGTH] nvarchar(100)
alter table ALPHA..WPNAMELIST add WIDTH nvarchar(100)
alter table ALPHA..WPNAMELIST add HEIGHT nvarchar(100)
alter table ALPHA..WPNAMELIST add [WEIGHT] nvarchar(100)



