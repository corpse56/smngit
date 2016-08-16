alter table ALPHANEXT..WPNAMELIST add IDNEW int
update ALPHANEXT..WPNAMELIST set IDNEW = ID


--таблицы для которых надо удалить а потом добавить снова те же внешние ключи:
--remarkwp
--runcard
--cicuitboards


alter table ALPHANEXT..WPNAMELIST drop column ID

EXEC sp_RENAME 'ALPHANEXT..WPNAMELIST.IDNEW' , 'ID', 'COLUMN'

alter table ALPHANEXT..WPNAMELIST alter column ID int not null
alter table ALPHANEXT..WPNAMELIST add primary key (ID)
--добавить внештние ключи в !!!!
--remarkwp
--runcard
--cicuitboards




--создать FK в таблице NOTES!!!!
--создать FK в таблице NOTIFICATIONS!!!!