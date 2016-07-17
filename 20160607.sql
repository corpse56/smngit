
update ALPHA..SUMMON
set PASSPORTREQ = 0 where PASSPORTREQ = 1 and PASSPORT is null and IDSTATUS in (13,14)

update ALPHA..SUMMON
set SERIALREQ = 0 where SERIALREQ = 1 and SERIAL is null and IDSTATUS in (13,14)

update ALPHA..SUMMON
set PLANKAREQ = 0 where PLANKAREQ = 1 and PLANKA is null and IDSTATUS in (13,14)

update ALPHA..SUMMON
set MANUALREQ = 0 where MANUALREQ = 1 and [MANUAL] is null and IDSTATUS in (13,14)

update ALPHA..SUMMON
set PACKINGLISTREQ = 0 where PACKINGLISTREQ = 1 and PACKINGLIST is null and IDSTATUS in (13,14)
