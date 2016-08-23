using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    class DBSummon :DB
    {

        internal string GetNextNumber()
        {
            string start = DateTime.Now.Year.ToString() + "0101";
            string end = DateTime.Now.Year.ToString() + "1231";
            DA.SelectCommand.CommandText = "select IDS from " + Base.BaseName + "..SUMMON where CREATED = "+
                                           "(select max(CREATED) from " + Base.BaseName + "..SUMMON where CREATED between '"+start+"' and '"+end+"')";
            DS = new DataSet();
            int i = DA.Fill(DS, "t");
            if (i==0) //если первое в году
                return "0001" + "-" + DateTime.Now.ToString("yy");
            string curIDS = DS.Tables["t"].Rows[0]["IDS"].ToString();
            string number = curIDS.Substring(0, 4);
            int next = int.Parse(number)+1;
            string nextIDS = next.ToString();
            if (nextIDS.Length == 1)
                nextIDS = "000" + nextIDS;
            else
            if (nextIDS.Length == 2)
                nextIDS = "00" + nextIDS;
            else
            if (nextIDS.Length == 3)
                nextIDS = "0" + nextIDS;


            return nextIDS + "-"+DateTime.Now.ToString("yy");
        }

        internal void AddNewSummon(SummonVO SVO, IRole UVO)
        {
            this.SaveSummon(SVO);
            DBCurStatus dbcs = new DBCurStatus();
            dbcs.AddNewCurstatus(SVO.IDS, UVO.id);
        }

        internal void SaveNewSummon(SummonVO SVO, IRole UVO)
        {
            this.SaveSummon(SVO);
            DBCurStatus dbcs = new DBCurStatus();
            dbcs.SaveNewCurstatus(SVO.IDS, UVO.id);
        }

        internal SummonVO GetSummonByIDS(string ids)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUMMON where IDS = '" + ids + "'";
            DA.Fill(DS, "t");

            SummonVO SVO = FillSVO(DS.Tables["t"].Rows[0]);
            return SVO;
        }
        internal SummonVO GetSummonByID(int id)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUMMON where ID = " + id;
            DA.Fill(DS, "t");

            SummonVO SVO = FillSVO(DS.Tables["t"].Rows[0]);
            return SVO;
        }
        internal SummonVO GetSummonByID(string id)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUMMON where ID = " + id;
            DA.Fill(DS, "t");

            SummonVO SVO = FillSVO(DS.Tables["t"].Rows[0]);
            return SVO;
        }

        private SummonVO FillSVO(DataRow dataRow)
        {
            SummonVO SVO = new SummonVO();
            SVO.ID = dataRow["ID"].ToString();
            SVO.ACCEPTANCE = dataRow["ACCEPTANCE"].ToString();
            SVO.CONTRACT = dataRow["CONTRACT"].ToString();
            SVO.CREATED = (DateTime)dataRow["CREATED"];
            SVO.DELIVERY = dataRow["DELIVERY"].ToString();
            //string tmp = dataRow["IDCURSTATUS"].ToString();
            //SVO.IDCURSTATUS = int.Parse(dataRow["IDCURSTATUS"].ToString());
            SVO.IDCUSTOMER = dataRow["IDCUSTOMER"].ToString();
            SVO.PAYSTATUS = dataRow["PAYSTATUS"].ToString();
            SVO.IDS = dataRow["IDS"].ToString();
            SVO.IDSTATUS = (int)(dataRow["IDSTATUS"]);
            SVO.NOTE = dataRow["NOTE"].ToString();
            SVO.PTIME = (DateTime)dataRow["PTIME"];
            SVO.QUANTITY = (int)dataRow["QUANTITY"];
            SVO.SHIPPING = dataRow["SHIPPING"].ToString();
            SVO.SISP = (bool)dataRow["SISP"];
            SVO.IDWPNAME = (int)dataRow["IDWP"];
            SVO.WPTYPE = dataRow["WPTYPE"].ToString();
            if (SVO.WPTYPE == "WPNAMELIST")
                SVO.WPTYPEENUM = WPTYPE.WPNAMELIST;
            if (SVO.WPTYPE == "ZHGUTLIST")
                SVO.WPTYPEENUM = WPTYPE.ZHGUTLIST;
            if (SVO.WPTYPE == "CABLELIST")
                SVO.WPTYPEENUM = WPTYPE.CABLELIST;

            SVO.ProductVO = ProductFactory.Create(SVO.IDWPNAME,SVO.WPTYPE);
            //SVO.WPNAME = SVO.ProductVO.GetName();
            SVO.IDACCEPT = (int)dataRow["IDACCEPT"];
            SVO.IDPACKING = (int)dataRow["IDPACKING"];
            //SVO.IDMOUNTINGKIT = (int)dataRow["IDMOUNTINGKIT"];
            SVO.IDCUSTOMERDEPT = (int)dataRow["IDCUSTOMERDEPT"];
            SVO.VIEWED = (bool)dataRow["VIEWED"];
            /*if (dataRow["PASSDATE"] == DBNull.Value)
            {
                SVO.PASSDATE = null;
                SVO.PASSDATETEXT = "Не определено";
            }
            else
            {
                SVO.PASSDATE = (DateTime)dataRow["PASSDATE"];
                SVO.PASSDATETEXT = ((DateTime)dataRow["PASSDATE"]).ToString("dd.MM.yyyy");
            }*/
            SVO.IDSUBST = (int)dataRow["IDSUBST"];
            SVO.BILLPAYED = (bool)dataRow["BILLPAYED"];
            SVO.DOCSREADY = (bool)dataRow["DOCSREADY"];
            SVO.STATUSNAME = new DBCurStatus().GetStatusNameByID(SVO.IDSTATUS);
            if (SVO.IDSUBST == 0)
            {
                SVO.SUBSTATUSNAME = "НЕ ПРИСВОЕНО";
            }
            else
            {
                SVO.SUBSTATUSNAME = new DBCurStatus().GetStatusNameByID(SVO.IDSUBST);
            }
            SVO.CONTRACTTYPE = dataRow["CONTRACTTYPE"].ToString();
            SVO.PLANKA = dataRow["PLANKA"].ToString();
            SVO.PLANKAREQ = (bool)dataRow["PLANKAREQ"];
            SVO.SERIAL = dataRow["SERIAL"].ToString();
            SVO.SERIALREQ = (bool)dataRow["SERIALREQ"];
            SVO.BILLNUMBER = dataRow["BILLNUMBER"].ToString();

            SVO.PASSPORT = dataRow["PASSPORT"].ToString();
            SVO.MANUAL = dataRow["MANUAL"].ToString();
            SVO.PACKINGLIST = dataRow["PACKINGLIST"].ToString();
            SVO.PASSPORTREQ = (bool)dataRow["PASSPORTREQ"];
            SVO.MANUALREQ = (bool)dataRow["MANUALREQ"];
            SVO.PACKINGLISTREQ = (bool)dataRow["PACKINGLISTREQ"];
            //SVO.LENGTH = dataRow["LENGTH"].ToString();
            //SVO.WIDTH = dataRow["WIDTH"].ToString();
            //SVO.HEIGHT = dataRow["HEIGHT"].ToString();
            //SVO.WEIGHT = dataRow["WEIGHT"].ToString();

            return SVO;
        }

        internal void SaveSummon(SummonVO SVO)
        {
            DA.UpdateCommand.Parameters.Add("ID", SqlDbType.Int);
            DA.UpdateCommand.Parameters["ID"].Value = SVO.ID;
            DA.UpdateCommand.Parameters.Add("ACCEPTANCE", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["ACCEPTANCE"].Value = SVO.ACCEPTANCE;
            DA.UpdateCommand.Parameters.Add("CONTRACT", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["CONTRACT"].Value = SVO.CONTRACT;
            DA.UpdateCommand.Parameters.Add("CREATED", SqlDbType.DateTime);
            DA.UpdateCommand.Parameters["CREATED"].Value = SVO.CREATED;
            DA.UpdateCommand.Parameters.Add("DELIVERY", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["DELIVERY"].Value = SVO.DELIVERY;
            //DA.UpdateCommand.Parameters.Add("IDCURSTATUS", SqlDbType.Int);
            //DA.UpdateCommand.Parameters["IDCURSTATUS"].Value = SVO.IDCURSTATUS;
            DA.UpdateCommand.Parameters.Add("IDCUSTOMER", SqlDbType.Int);
            DA.UpdateCommand.Parameters["IDCUSTOMER"].Value = SVO.IDCUSTOMER;
            DA.UpdateCommand.Parameters.Add("PAYSTATUS", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["PAYSTATUS"].Value = SVO.PAYSTATUS;
            DA.UpdateCommand.Parameters.Add("IDS", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["IDS"].Value = SVO.IDS;
            //DA.UpdateCommand.Parameters.Add("IDSTATUS", SqlDbType.Int);
            //DA.UpdateCommand.Parameters["IDSTATUS"].Value = SVO.IDSTATUS;
            DA.UpdateCommand.Parameters.Add("NOTE", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["NOTE"].Value = SVO.NOTE;
            DA.UpdateCommand.Parameters.Add("PTIME", SqlDbType.DateTime);
            DA.UpdateCommand.Parameters["PTIME"].Value = SVO.PTIME;
            DA.UpdateCommand.Parameters.Add("QUANTITY", SqlDbType.Int);
            DA.UpdateCommand.Parameters["QUANTITY"].Value = SVO.QUANTITY;
            DA.UpdateCommand.Parameters.Add("SHIPPING", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["SHIPPING"].Value = SVO.SHIPPING;
            DA.UpdateCommand.Parameters.Add("SISP", SqlDbType.Bit);
            DA.UpdateCommand.Parameters["SISP"].Value = SVO.SISP;
            DA.UpdateCommand.Parameters.Add("IDWP", SqlDbType.Int);
            DA.UpdateCommand.Parameters["IDWP"].Value = SVO.IDWPNAME;
            DA.UpdateCommand.Parameters.Add("WPTYPE", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["WPTYPE"].Value = SVO.WPTYPE;
            DA.UpdateCommand.Parameters.Add("IDACCEPT", SqlDbType.Int);
            DA.UpdateCommand.Parameters["IDACCEPT"].Value = SVO.IDACCEPT;
            DA.UpdateCommand.Parameters.Add("IDPACKING", SqlDbType.Int);
            DA.UpdateCommand.Parameters["IDPACKING"].Value = SVO.IDPACKING;
            //DA.UpdateCommand.Parameters.Add("IDMOUNTINGKIT", SqlDbType.Int);
            //DA.UpdateCommand.Parameters["IDMOUNTINGKIT"].Value = SVO.IDMOUNTINGKIT;
            DA.UpdateCommand.Parameters.Add("IDCUSTOMERDEPT", SqlDbType.Int);
            DA.UpdateCommand.Parameters["IDCUSTOMERDEPT"].Value = SVO.IDCUSTOMERDEPT;
            DA.UpdateCommand.Parameters.Add("VIEWED", SqlDbType.Bit);
            DA.UpdateCommand.Parameters["VIEWED"].Value = SVO.VIEWED;
            DA.UpdateCommand.Parameters.Add("CONTRACTTYPE", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["CONTRACTTYPE"].Value = SVO.CONTRACTTYPE;

            DA.UpdateCommand.Parameters.Add("PLANKA", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["PLANKA"].Value = (((object)SVO.PLANKA) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.Add("PLANKAREQ", SqlDbType.Bit);
            DA.UpdateCommand.Parameters["PLANKAREQ"].Value = SVO.PLANKAREQ;

            DA.UpdateCommand.Parameters.Add("SERIAL", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["SERIAL"].Value = (((object)SVO.SERIAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.Add("SERIALREQ", SqlDbType.Bit);
            DA.UpdateCommand.Parameters["SERIALREQ"].Value = SVO.SERIALREQ;


            //DA.UpdateCommand.Parameters.Add("PASSDATE", SqlDbType.DateTime);
            //if (SVO.PASSDATE == null)
            //    DA.UpdateCommand.Parameters["PASSDATE"].Value = SqlDateTime.Null;
            //else
            //    DA.UpdateCommand.Parameters["PASSDATE"].Value = SVO.PASSDATE;
            
            DA.UpdateCommand.Parameters.Add("IDSUBST", SqlDbType.Int);
            DA.UpdateCommand.Parameters["IDSUBST"].Value = SVO.IDSUBST;
            DA.UpdateCommand.Parameters.Add("BILLPAYED", SqlDbType.Bit);
            DA.UpdateCommand.Parameters["BILLPAYED"].Value = SVO.BILLPAYED;
            DA.UpdateCommand.Parameters.Add("DOCSREADY", SqlDbType.Bit);
            DA.UpdateCommand.Parameters["DOCSREADY"].Value = SVO.DOCSREADY;
            DA.UpdateCommand.Parameters.Add("BILLNUMBER", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["BILLNUMBER"].Value = SVO.BILLNUMBER;


            DA.UpdateCommand.Parameters.AddWithValue("PASSPORT", ((object)SVO.PASSPORT) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MANUAL", ((object)SVO.MANUAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLIST", ((object)SVO.PACKINGLIST) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORTREQ", SVO.PASSPORTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MANUALREQ", SVO.MANUALREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLISTREQ", SVO.PACKINGLISTREQ);

            //DA.UpdateCommand.Parameters.AddWithValue("LENGTH", SVO.LENGTH);
            //DA.UpdateCommand.Parameters.AddWithValue("WIDTH", SVO.WIDTH);
            //DA.UpdateCommand.Parameters.AddWithValue("HEIGHT", SVO.HEIGHT);
            //DA.UpdateCommand.Parameters.AddWithValue("WEIGHT", SVO.WEIGHT);



            //если что-то добавляешь сюда , то добавь и в функцию get summon by ids
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set ACCEPTANCE=@ACCEPTANCE,CONTRACT=@CONTRACT,DELIVERY=@DELIVERY,IDCUSTOMER=@IDCUSTOMER,PAYSTATUS=@PAYSTATUS, " +
            "NOTE=@NOTE,PTIME=@PTIME,QUANTITY=@QUANTITY,SHIPPING=@SHIPPING,SISP=@SISP,  " +
            " IDWP = @IDWP,IDACCEPT = @IDACCEPT,IDPACKING = @IDPACKING, CREATED = @CREATED " +
            " , IDCUSTOMERDEPT = @IDCUSTOMERDEPT, VIEWED = @VIEWED , IDS = @IDS " +
            " , IDSUBST = @IDSUBST,BILLPAYED=@BILLPAYED,DOCSREADY=@DOCSREADY, WPTYPE = @WPTYPE, CONTRACTTYPE=@CONTRACTTYPE " +
            " , PLANKA=@PLANKA, PLANKAREQ = @PLANKAREQ, SERIAL = @SERIAL, SERIALREQ=@SERIALREQ, BILLNUMBER = @BILLNUMBER "+
            " , PASSPORT=@PASSPORT, MANUAL=@MANUAL, PACKINGLIST=@PACKINGLIST, PASSPORTREQ=@PASSPORTREQ, MANUALREQ=@MANUALREQ, PACKINGLISTREQ=@PACKINGLISTREQ" +
            //" , LENGTH=@LENGTH WIDTH=@WIDTH, HEIGHT=@HEIGHT, WEIGHT=@WEIGHT" +
            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
       
        internal string GetCustomerName(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERS where ID = " + p;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CNAME"].ToString();
        }

        internal string GetCustomerContact(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERS where ID = " + p;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CONTACT"].ToString();
        }

        internal string GetStatusName(int p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..STATUSLIST where ID = " + p;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["SNAME"].ToString();
        }

        internal DataTable GetHistory(string ids)
        {
            //DA.SelectCommand.CommandText = "select A.IDS ids,B.SNAME sts, A.CAUSE cause, A.CHANGED chg, C.FIO fio " +
            //                               " from " + Base.BaseName + "..CURSTATUS A " +
            //                               " left join " + Base.BaseName + "..STATUSLIST B on A.STATID = B.ID " +
            //                               " left join " + Base.BaseName + "..USERS C on A.IDUSER = C.ID " +
            //                               " where A.IDS = '" + ids+"'";
            DA.SelectCommand.CommandText = "select A.IDS ids,B.SNAME sts, A.CAUSE cause, A.CHANGED chg, C.FIO fio, DATEDIFF(minute, A.CHANGED,N.CHANGED) ts " +
             "from " + Base.BaseName + "..CURSTATUS A  " +
             " left join " + Base.BaseName + "..STATUSLIST B on A.STATID = B.ID  " +
             " left join " + Base.BaseName + "..USERS C on A.IDUSER = C.ID  " +
             " left join " + Base.BaseName + "..CURSTATUS N on N.IDS = A.IDS  " +
             " where A.IDS = '" + ids + "'  " +
             " and N.ID = (select MIN(NN.ID) from " + Base.BaseName + "..CURSTATUS NN  " +
			 "             where NN.IDS = A.IDS and NN.ID > A.ID) "+
            "union all "+
            "select A.IDS ids,B.SNAME sts, A.CAUSE cause, A.CHANGED chg, C.FIO fio , DATEDIFF(minute,  A.CHANGED,GETDATE()) ts "+
            " from " + Base.BaseName + "..CURSTATUS A  " +
            "  left join " + Base.BaseName + "..STATUSLIST B on A.STATID = B.ID  " +
            "  left join " + Base.BaseName + "..USERS C on A.IDUSER = C.ID  " +
            "  where A.IDS = '" + ids + "' " +
            " and A.ID = (select MAX(ID) from  " + Base.BaseName + "..CURSTATUS AA where AA.IDS =  '" + ids + "')";
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        internal DataTable GetPieChart(DateTime dstart,DateTime dend)
        {
            //DA.SelectCommand.CommandText = "select A.IDS ids,B.SNAME sts, A.CAUSE cause, A.CHANGED chg, C.FIO fio " +
            //                               " from " + Base.BaseName + "..CURSTATUS A " +
            //                               " left join " + Base.BaseName + "..STATUSLIST B on A.STATID = B.ID " +
            //                               " left join " + Base.BaseName + "..USERS C on A.IDUSER = C.ID " +
            //                               " where A.IDS = '" + ids+"'";
            DA.SelectCommand.CommandText = "with F0 as (  " +
            "select distinct B.SNAME sts, DATEDIFF(minute, A.CHANGED,N.CHANGED) ts,B.ID id  " +
            "from " + Base.BaseName + "..STATUSLIST B  " +
            " join " + Base.BaseName + "..CURSTATUS A  on A.STATID = B.ID " +
            " left join " + Base.BaseName + "..CURSTATUS N on N.IDS = A.IDS   " +
            "left join " + Base.BaseName + "..SUMMON S on S.IDS = A.IDS   " +
            "where cast(cast(S.CREATED as varchar(11)) as datetime) between '" + dstart.ToString("yyyyMMdd") + "' and  '" + dend.ToString("yyyyMMdd") + "' " +
            "and B.ID != 13 and B.ID != 14 and N.ID = (select MIN(NN.ID) from " + Base.BaseName + "..CURSTATUS NN   " +
            "             where NN.IDS = A.IDS and NN.ID > A.ID)  " +
            "union all  " +
            "select distinct B.SNAME sts,  DATEDIFF(minute,  A.CHANGED,GETDATE()) ts,B.ID id " +
            "from " + Base.BaseName + "..STATUSLIST B  " +
            " join " + Base.BaseName + "..CURSTATUS A  on A.STATID = B.ID   " +
            " left join " + Base.BaseName + "..SUMMON S on S.IDS = A.IDS   " +
            "where cast(cast(S.CREATED as varchar(11)) as datetime) between '" + dstart.ToString("yyyyMMdd") + "' and  '" + dend.ToString("yyyyMMdd") + "' " +
            " and B.ID != 13 and B.ID != 14 and A.ID = (select MAX(ID) from  " + Base.BaseName + "..CURSTATUS AA where AA.IDS =  A.IDS) " +
            " ), " +
            " F1 as " +
            " ( " +
            " select sts sts,SUM(ts) ts, id id  from F0 " +
            "  group by sts,id " +
            " union all " +
            " select SNAME sts,SUM(0) ts, id id from  " +
            " " + Base.BaseName + "..STATUSLIST B  " +
            " where B.ID != 13 and B.ID != 14 " +
            " group by SNAME,id " +
            " ), " +
            " F2 as " +
            "( " +
            "select sts sts, SUM(ts) ts,id id from F1  " +
            "group by sts,id  " +
            "), F3 as( " +
            "select case when id = 16 then 'ОТК' else  " +
            "       case when id = 17 then 'ПДБ. В работе' else " +
            "       case when id = 15 or id = 18 then 'У монтажников' else sts end end end sts, " +
            "       SUM(ts) ts, " +
            "       case when id = 16 then 7 else  " +
            "       case when id = 17 then 3 else " +
            "       case when id = 15 or id = 18 then 15 else id end end end id " +
            "        from F2  " +
            "       group by sts,id) " +
            "select sts, SUM(ts) ts,id from F3 group by sts,id order by id";
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal string GetCustomerAddress(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERS where ID = " + p;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["ADDRESS"].ToString();
        }

        internal string GetCustomerContactExe(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERS where ID = " + p;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CONTACTEXE"].ToString();
        }

        internal string GetCustomerContactLog(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERS where ID = " + p;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CONTACTFINLOG"].ToString();
        }


        internal void DeleteSummon(string ids)
        {
            DA.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            DA.DeleteCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.DeleteCommand.Parameters.Add("ids", SqlDbType.NVarChar);
            DA.DeleteCommand.Parameters["ids"].Value = ids;
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..SUMMON where IDS = @ids";
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }
        internal void DeleteSummonByID(string id)
        {
            DA.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            DA.DeleteCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.DeleteCommand.Parameters.Add("id", SqlDbType.Int);
            DA.DeleteCommand.Parameters["id"].Value = id;
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..SUMMON where ID = @id";
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }
        internal void AddOTKComment(string id,string comment)
        {
            DA.UpdateCommand = new System.Data.SqlClient.SqlCommand();
            DA.UpdateCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.UpdateCommand.Parameters.Add("id", SqlDbType.Int);
            DA.UpdateCommand.Parameters["id"].Value = id;
            DA.UpdateCommand.Parameters.Add("comment", SqlDbType.NVarChar);
            DA.UpdateCommand.Parameters["comment"].Value = comment;
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set otkcomment = @comment where ID = @id";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
        internal int AddNIPSummon()
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..SUMMON (IDS,IDSTATUS,QUANTITY,WPTYPE,CONTRACTTYPE) " +
            " values ('',14,0,'NaWP','Стандартный');select SCOPE_IDENTITY()";
            DA.InsertCommand.Connection.Open();

            int idresult = Convert.ToInt32(DA.InsertCommand.ExecuteScalar());
            DA.InsertCommand.Connection.Close();
            return idresult;
        }
        internal void DeleteNIPSummons()
        {
            DA.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            DA.DeleteCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..SUMMON where IDSTATUS = 14";
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }

        internal void SetViewed(string id)
        {
            DA.UpdateCommand = new System.Data.SqlClient.SqlCommand();
            DA.UpdateCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set VIEWED = 1 where ID = "+id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();


        }

        internal string GetCustomerDeptName(int IDDEPT,string IDCUST)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERDEPTLIST where IDCUSTOMER = " + IDCUST+ 
                                            " and ID = " +IDDEPT;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["DEPTNAME"].ToString();
        }

        internal string GetDeptContactExe(int IDDEPT, string IDCUST)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERDEPTLIST where IDCUSTOMER = " + IDCUST +
                                            " and ID = " + IDDEPT;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CONTACTEXE"].ToString();
        }

        internal string GetDeptContactLog(int IDDEPT, string IDCUST)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERDEPTLIST where IDCUSTOMER = " + IDCUST +
                                            " and ID = " + IDDEPT;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CONTACTFINLOG"].ToString();
        }



        internal void PassDateChanged(string id)
        {
            DA.UpdateCommand = new System.Data.SqlClient.SqlCommand();
            DA.UpdateCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set PASSDATECHANGED = getdate() where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }



        internal void AddSummonView(SummonVO SVO, IRole UVO)
        {
            DA.InsertCommand = new System.Data.SqlClient.SqlCommand();
            DA.InsertCommand.Connection = new System.Data.SqlClient.SqlConnection(MainF.ConnectionString);
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..SUMMONVIEWS (IDSUMMON,DATEVIEWED,IDUSER) values " +
                "(" + SVO.ID + ",getdate()," + UVO.id + ") ";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal object GetSummonsOnProductID(string IDPRODUCT)
        {
            StringBuilder ct = new StringBuilder();
            ct.AppendFormat("select IDS,ID from {0}..SUMMON ", Base.BaseName);
            //ct.AppendFormat("left join A");
            ct.AppendFormat(" where IDWP = {0}", IDPRODUCT);
            //ct.AppendFormat();
            //ct.AppendFormat();
            DA.SelectCommand.CommandText = ct.ToString();//"select * from " + Base.BaseName + "..SUMMON where IDWP = " + IDPRODUCT;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
    }
}
