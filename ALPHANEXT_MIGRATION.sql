alter table ALPHANEXT..WPNAMELIST add IDNEW int
update ALPHANEXT..WPNAMELIST set IDNEW = ID


--������� ��� ������� ���� ������� � ����� �������� ����� �� �� ������� �����:
--remarkwp
--runcard
--cicuitboards


alter table ALPHANEXT..WPNAMELIST drop column ID

EXEC sp_RENAME 'ALPHANEXT..WPNAMELIST.IDNEW' , 'ID', 'COLUMN'

alter table ALPHANEXT..WPNAMELIST alter column ID int not null
alter table ALPHANEXT..WPNAMELIST add primary key (ID)
--�������� �������� ����� � !!!!
--remarkwp
--runcard
--cicuitboards




--������� FK � ������� NOTES!!!!
--������� FK � ������� NOTIFICATIONS!!!!