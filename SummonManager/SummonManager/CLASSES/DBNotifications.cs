using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class Notification
    {
        public string ID;
        public string IDNTYPE;
        public string IDSUMMON;
        public string IDS;
        public DateTime CREATED;
    }
    class DBNotification :DB
    {
        public DBNotification() { }
        public DataTable GetAllNTYPES()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..NOTIFICATIONTYPE";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void AddNew(Notification n)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..NOTIFICATIONS (IDNTYPE,IDSUMMON) values ("
                                            + n.IDNTYPE + ","+n.IDSUMMON+")";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }
        internal List<Notification> GetNotByTYPE(string type)
        {
            DA.SelectCommand.CommandText = "select A.*,B.IDS from " + Base.BaseName + "..NOTIFICATIONS A "+
                                            " left join " + Base.BaseName + "..SUMMON B on A.IDSUMMON = B.ID where IDNTYPE = " + type;
            DA.Fill(DS, "t");
            List<Notification> ln = new List<Notification>();
            foreach (DataRow r in DS.Tables["t"].Rows)
            {
                Notification n = new Notification();
                //n.ID = r["ID"].ToString();
                n.IDSUMMON = r["IDSUMMON"].ToString();
                n.IDNTYPE = r["IDNTYPE"].ToString();
                n.IDS = r["IDS"].ToString();
                n.CREATED = (r["CREATED"] == DBNull.Value) ? DateTime.Now : (DateTime)r["CREATED"];
                ln.Add(n);
            }

            return ln;
        }
        internal void Delete(Notification n)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..NOTIFICATIONS " +
                                            " where IDNTYPE = " + n.IDNTYPE +" and IDSUMMON = "+n.IDSUMMON;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }

        //internal bool IsOTKRight(string id)
        //{
        //    DS.Clear();
        //    DA.SelectCommand.CommandText = "select cast(case when (SERIAL is null or SERIAL = '') and SERIALREQ = 1 then 1 else 0 end as bit) paint_otk "+
        //                                    " from " + Base.BaseName + "..SUMMON where ID = " + id + " and IDSTATUS not in (1,2,13,14) ";
        //    int i = DA.Fill(DS, "t");
        //    if (i == 0)
        //    {
        //        return false;
        //    }
        //    return (bool)DS.Tables["t"].Rows[0]["paint_otk"];
        //}

        internal void FillNotifications()
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..NOTIFICATIONS where IDNTYPE in (1,2,3,4)";
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();


            DA.InsertCommand.CommandText =  "  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON) " +
                          "select 1,A.ID from [ALPHA].[dbo].SUMMON A "+
                          " left join [ALPHA].[dbo].WPNAMELIST W on A.IDWP = W.ID and A.WPTYPE = 'WPNAMELIST'" +
                          "  where A.SERIAL is null and A.SERIALREQ = 1 " +
                          " and A.IDSTATUS not in (1,2,13,14) " +
                         " and NOT exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] B " +
					                      "  where B.IDNTYPE = 1 and B.IDSUMMON = A.ID)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();//вставляем оповещения для OTK (IDNTYPE = 1)
            //DA.InsertCommand.Connection.Close();

            DA.InsertCommand.CommandText = "  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON) " +
             " select 2,A.ID from [ALPHA].[dbo].SUMMON A "+
             " left join [ALPHA].[dbo].WPNAMELIST W on A.IDWP = W.ID and A.WPTYPE = 'WPNAMELIST'" +
             //" left join [ALPHA].[dbo].ZHGUTLIST ZH on A.IDWP = ZH.ID and A.WPTYPE = 'ZHGUTLIST'" + потом с андрюхой обсудить
             //" left join [ALPHA].[dbo].CABLELIST CA on A.IDWP = CA.ID and A.WPTYPE = 'CABLELIST'" +
             " where (W.SHILDS is null  and W.SHILDSREQ=1 or A.PLANKA is null and A.PLANKAREQ = 1 or W.SBORKA3D is null and W.SBORKA3DREQ =1 " +
             " or W.MECHPARTS is null  and W.MECHPARTSREQ =1 or W.DIMENSIONALDRAWING is null  and W.DIMENSIONALDRAWINGREQ =1 or W.PACKAGING is null  and W.PACKAGINGREQ =1) " +
             " and A.IDSTATUS not in (1,2,13,14) " +
            " and NOT exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] B " +
                             "  where B.IDNTYPE = 2 and B.IDSUMMON = A.ID) ";
            //DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();//вставляем оповещения для конструктора (IDNTYPE = 2)

            DA.InsertCommand.CommandText = "  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON) " +
             " select 3,A.ID from [ALPHA].[dbo].SUMMON A "+
             " left join [ALPHA].[dbo].PURCHASEDMATERIALS pm on A.ID = pm.IDS   " +
             " left join [ALPHA].[dbo].WPNAMELIST W on A.IDWP = W.ID and A.WPTYPE = 'WPNAMELIST'" +
             " where W.SHILDS is not null  and W.SHILDSREQ=1 and W.PLANKA is not null and W.PLANKAREQ = 1" +
             " and (pm.SHILDORDERED = 0 or pm.SHILDORDERED is null) " +
             " and A.IDSTATUS not in (1,2,13,14) " +
            "  and NOT exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] B " +
                             "  where B.IDNTYPE = 3 and B.IDSUMMON = A.ID)";
            //DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();//вставляем оповещения для ПДБ (IDNTYPE = 3 )

            DA.InsertCommand.CommandText = "  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON) " +
             "select 4,A.ID from [ALPHA].[dbo].SUMMON A where  " +
             " A.DOCSREADY = 0 " +
             " and A.IDSTATUS in (9,12) " +
            " and NOT exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] B " +
                             "  where B.IDNTYPE = 4 and B.IDSUMMON = A.ID)";
            //DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();//вставляем оповещения для Бухгалтера (IDNTYPE = 4)

            DA.InsertCommand.Connection.Close();
        }

        //internal bool IsCONSTRRight(string id)
        //{
        //    DS.Clear();
        //    DA.SelectCommand.CommandText = "select cast(case when (((SERIAL is not null and SERIAL != '') and SERIALREQ = 1)) and (((SHILD is null or SHILD = '')and SHILDREQ=1 or (PLANKA is null or PLANKA = '') and PLANKAREQ = 1)) then 1 else 0 end as bit) paint_constr " +
        //                                    " from " + Base.BaseName + "..SUMMON where ID = " + id + " and IDSTATUS not in (1,2,13,14) " ;
        //    int i = DA.Fill(DS, "t");
        //    if (i == 0)
        //    {
        //        return false;
        //    }
        //    return (bool)DS.Tables["t"].Rows[0]["paint_constr"];
        //}

        //internal bool IsPDBRight(string id)
        //{
        //    DS.Clear();
        //    DA.SelectCommand.CommandText = "select cast(case when (((SHILD is not null and SHILD != '') and SHILDREQ=1 "+
        //                                   " and (PLANKA is not null and PLANKA != '') and PLANKAREQ = 1) and (pm.SHILDORDERED = 0 or pm.SHILDORDERED is null) ) " +
        //                                   " then 1 else 0 end as bit) paint_pdb from [ALPHA].[dbo].SUMMON A " +
        //     "left join [ALPHA].[dbo].PURCHASEDMATERIALS pm on A.ID = pm.IDS " +
        //     " where A.IDSTATUS not in (1,2,13,14) and A.ID = "+id;
        //    int i = DA.Fill(DS, "t");
        //    if (i == 0)
        //    {
        //        return false;
        //    }
        //    return (bool)DS.Tables["t"].Rows[0]["paint_pdb"];
        //}

        internal void FillBillPayedNtf(string id)
        {
            DA.InsertCommand.CommandText = "  insert into [ALPHA].[dbo].[NOTIFICATIONS] (IDNTYPE,IDSUMMON,CREATED) " +
                          "select 5,ID,getdate() from [ALPHA].[dbo].SUMMON A where ID = " + id + 
                         " and NOT exists (select 1 from [ALPHA].[dbo].[NOTIFICATIONS] B " +
                                          "  where B.IDNTYPE = 5 and B.IDSUMMON = A.ID)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();//вставляем оповещения для менеджера (IDNTYPE = 5)
        }
    }
}
