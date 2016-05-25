-------------------------------------------для  перевода на новую структуру
SET IDENTITY_INSERT ALPHA..WPNAMELIST on
insert into ALPHA..WPNAMELIST (ID,WPNAME) values (3000,'iden off')
alter table ALPHA..WPNAMELIST add IDNEW int 
update ALPHA..WPNAMELIST set IDNEW = ID
alter table ALPHA..WPNAMELIST alter column IDNEW int not null
alter table ALPHA..WPNAMELIST drop column ID


не доделано!


--------------------------текущие--------------------------------
SET IDENTITY_INSERT ALPHA..WPNAMELIST on
insert into ALPHA..WPNAMELIST (ID,WPNAME) values (3000,'iden off')
alter table ALPHA..WPNAMELIST add IDNEW int 
update ALPHA..WPNAMELIST set IDNEW = ID
alter table ALPHA..WPNAMELIST alter column IDNEW int not null
alter table ALPHA..WPNAMELIST drop column ID
