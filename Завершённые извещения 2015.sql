select A.ID,
ISNULL(W.WPNAME,isnull(C.CABLENAME,Z.ZHGUTNAME)),
CU.CNAME,
convert(varchar,A.PTIME,104),
A.QUANTITY

--case  when W.WPNAME IS null then 
from ALPHA..SUMMON A
left join ALPHA..WPNAMELIST W on A.IDWP = W.ID and A.WPTYPE = 'WPNAMELIST'
left join ALPHA..CABLELIST C on A.IDWP = C.ID and A.WPTYPE = 'CABLELIST'
left join ALPHA..ZHGUTLIST Z on A.IDWP = Z.ID and A.WPTYPE = 'ZHGUTLIST'
left join ALPHA..CUSTOMERS CU on A.IDCUSTOMER = CU.ID
left join ALPHA..CUSTOMERDEPTLIST CUD on A.IDCUSTOMERDEPT = CUD.ID
where A.IDS like '%-15' and A.IDSTATUS = 13
order by A.PTIME
