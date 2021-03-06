
  
  
  alter table PRDC..SUMMON alter column PAYSTATUS nvarchar(100)
  alter table PRDC..SUMMON add IDEXTCABLE int
  alter table PRDC..SUMMON add IDMOUNTINGKIT int
  --alter table PRDC..EXTCABLELIST alter column EXTCABLENAME nvarchar(max)
  --insert into PRDC..EXTCABLELIST (EXTCABLENAME) select WPNAME from PRDC..WPNAMELIST
  alter table PRDC..SUMMON add constraint def_mk default 1 for IDMOUNTINGKIT
  alter table PRDC..SUMMON add constraint def_ec default 173 for IDEXTCABLE
  
    update [PRDC].[dbo].[SUMMON] set IDEXTCABLE = 173, IDMOUNTINGKIT = 1
    
    
  insert into ALPHA..CUSTOMERDEPTLIST (IDCUSTOMER,DEPTNAME,CONTACTEXE,CONTACTFINLOG)
  select ID,'Единый отдел по-умолчанию',CONTACTEXE,CONTACTFINLOG from PRDC..CUSTOMERS
  
  insert into ALPHA..EXTCABLELIST (EXTCABLENAME)
  select WPNAME from PRDC..WPNAMELIST
  
  
  
  
  insert into ALPHA..SUMMON (
       
      [IDS]
      ,[WPNAME]
      ,[TECHREQPATH]
      ,[QUANTITY]
      ,[PTIME]
      ,[ACCEPTANCE]
      ,[IDCUSTOMER]
      ,[CONTRACT]
      ,[PAYSTATUS]
      ,[SHIPPING]
      ,[DELIVERY]
      ,[SISP]
      ,[NOTE]
      ,[IDSTATUS]
      ,[IDCURSTATUS]
      ,[CREATED]
      ,[IDWP]
      ,[IDACCEPT]
      ,[PASSDATE]
      ,[IDPACKING]
      ,[NOTEPDB]
      ,[IDEXTCABLE]
      ,[IDMOUNTINGKIT]
      ,[IDCUSTOMERDEPT]
      ,[VIEWED])
      
      select [IDS]
      ,[WPNAME]
      ,[TECHREQPATH]
      ,[QUANTITY]
      ,[PTIME]
      ,[ACCEPTANCE]
      ,A.[IDCUSTOMER]
      ,[CONTRACT]
      ,[PAYSTATUS]
      ,[SHIPPING]
      ,[DELIVERY]
      ,[SISP]
      ,[NOTE]
      ,[IDSTATUS]
      ,[IDCURSTATUS]
      ,[CREATED]
      ,[IDWP]
      ,[IDACCEPT]
      ,[PASSDATE]
      ,[IDPACKING]
      ,[NOTEPDB]
      ,0
      ,1
      ,B.ID
      ,1
      
 FROM PRDC.[dbo].[SUMMON] A
 left join ALPHA..CUSTOMERDEPTLIST B on A.IDCUSTOMER = B.IDCUSTOMER
  
  
  
  insert into ALPHA..CURSTATUS  (IDS,STATID,CAUSE,CHANGED,IDUSER)
  select IDS,STATID,CAUSE,CHANGED,IDUSER from PRDC..CURSTATUS