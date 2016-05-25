with F0 as (  
select distinct B.SNAME sts, DATEDIFF(minute, A.CHANGED,N.CHANGED) ts,B.ID id  
 from ALPHA..STATUSLIST B  
 join ALPHA..CURSTATUS A  on A.STATID = B.ID 
  left join ALPHA..CURSTATUS N on N.IDS = A.IDS   
 left join ALPHA..SUMMON S on S.IDS = A.IDS   
where cast(cast(S.CREATED as varchar(11)) as datetime) between '20141001' and  '20151001' 
and B.ID != 13 and B.ID != 14 and N.ID = (select MIN(NN.ID) from ALPHA..CURSTATUS NN   
where NN.IDS = A.IDS and NN.ID > A.ID)  
union all  
select distinct B.SNAME sts,  DATEDIFF(minute,  A.CHANGED,GETDATE()) ts,B.ID id 
from ALPHA..STATUSLIST B  
join ALPHA..CURSTATUS A  on A.STATID = B.ID   
left join ALPHA..SUMMON S on S.IDS = A.IDS   
where cast(cast(S.CREATED as varchar(11)) as datetime) between '20141001' and  '20151001' 
and B.ID != 13 and B.ID != 14 and A.ID = (select MAX(ID) from  ALPHA..CURSTATUS AA where AA.IDS =  A.IDS) 
), 
F1 as 
( 
select sts sts,SUM(ts) ts, id id  from F0 
group by sts,id 
union all 
select SNAME sts,SUM(0) ts, id id from  
ALPHA..STATUSLIST B  
where B.ID != 13 and B.ID != 14 
group by SNAME,id 
) ,
F2 as
(
select sts sts, SUM(ts) ts,id id from F1 
group by sts,id 
), F3 as(
select case when id = 16 then 'ОТК' else 
	   case when id = 17 then 'ПДБ. В работе' else
	   case when id = 15 or id = 18 then 'У монтажников' else sts end end end sts,
	   SUM(ts) ts,
	   case when id = 16 then 7 else 
	   case when id = 17 then 3 else
	   case when id = 15 or id = 18 then 15 else id end end end id
	    from F2 
	   group by sts,id)
select sts, SUM(ts),id from F3 group by sts,id order by id