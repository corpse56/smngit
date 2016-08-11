using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    class DBRemarkWP :DB
    {
        IRole UVO;
        public DBRemarkWP()
        {
        }
        public DBRemarkWP(IRole UVO_)
        {
            this.UVO = UVO_;
        }

        public DataTable GetAll()
        {
            DA.SelectCommand.CommandText = "select A.ID,W.WPNAME+' '+W.DECNUM WP,IDWP,DOCUMENTNAME, REMARK,"+
                                           " case when DOCUMENTNAME = 'COMPOSITION' then 'Состав изделия' else " +
                                           " case when DOCUMENTNAME = 'DIMENSIONALDRAWING' then 'Габаритный чертёж' else " +
                                           " case when DOCUMENTNAME = 'CONFIGURATION' then 'Конфигурация' else " +
                                           " case when DOCUMENTNAME = 'WIRINGDIAGRAM' then 'Схема электрическая' else " +
                                           " case when DOCUMENTNAME = 'TECHREQ' then 'Технические требования' else " +
                                           " case when DOCUMENTNAME = 'SBORKA3D' then 'Сборка 3Д' else " +
                                           " case when DOCUMENTNAME = 'MECHPARTS' then 'Проект механических деталей' else " +
                                           " case when DOCUMENTNAME = 'SHILDS' then 'Шильды' else " +
                                           " case when DOCUMENTNAME = 'PACKAGING' then 'Упаковка' else " +
                                           " case when DOCUMENTNAME = 'SOFTWARE' then 'Программное обеспечение' else DOCUMENTNAME end end end end end end end end end end DOCUMENTNAME_RUS" +
                                           
                                           " ,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
                                           " case when CLOSED=1 then 'Отработано' else 'Открыто' end CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole "+
                                           " from " + Base.BaseName + "..REMARKWP A"+
                                           " left join " + Base.BaseName + "..USERS B on A.IDCREATOR = B.ID " +
                                           " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID "+
                                           " left join " + Base.BaseName + "..USERS D on A.IDCLOSER = D.ID " +
                                           " left join " + Base.BaseName + "..ROLES E on D.ROLE = E.ID "+
                                           " left join " + Base.BaseName + "..WPNAMELIST W on A.IDWP = W.ID";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void AddNew(WP_RVO RVO)
        {
            DA.InsertCommand.Parameters.AddWithValue("DATEREMARK", RVO.DATEREMARK);
            DA.InsertCommand.Parameters.AddWithValue("DOCUMENTNAME", RVO.DOCUMENTNAME);
            DA.InsertCommand.Parameters.AddWithValue("IDCREATOR", RVO.IDCREATOR);
            DA.InsertCommand.Parameters.AddWithValue("IDWP", RVO.IDWP);
            DA.InsertCommand.Parameters.AddWithValue("REMARK", RVO.REMARK);

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..REMARKWP (DATEREMARK,DOCUMENTNAME,IDCREATOR,IDWP,REMARK) "+
                                           " values (@DATEREMARK,@DOCUMENTNAME,@IDCREATOR,@IDWP,@REMARK)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal void Edit(WP_RVO RVO)
        {
            DA.UpdateCommand.Parameters.AddWithValue("ID", RVO.ID);
            DA.UpdateCommand.Parameters.AddWithValue("CLOSED", RVO.CLOSED);
            DA.UpdateCommand.Parameters.AddWithValue("CLOSINGCOMMENT", ((object)RVO.CLOSINGCOMMENT) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DATECLOSE", ((object)RVO.DATECLOSE) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DATEREMARK", RVO.DATEREMARK);
            DA.UpdateCommand.Parameters.AddWithValue("DOCUMENTNAME", RVO.DOCUMENTNAME);
            DA.UpdateCommand.Parameters.AddWithValue("IDCLOSER", ((object)RVO.IDCLOSER) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("IDCREATOR", RVO.IDCREATOR);
            DA.UpdateCommand.Parameters.AddWithValue("IDWP", RVO.IDWP);
            DA.UpdateCommand.Parameters.AddWithValue("REMARK", RVO.REMARK);


            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..REMARKWP set CLOSED  = @CLOSED, CLOSINGCOMMENT=@CLOSINGCOMMENT "+
                                           ", DATECLOSE=@DATECLOSE, DATEREMARK=@DATEREMARK, DOCUMENTNAME=@DOCUMENTNAME,IDCLOSER=@IDCLOSER "+ 
                                           ", IDCREATOR=@IDCREATOR, IDWP=@IDWP, REMARK = @REMARK "+
                                            " where ID = @ID" ;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    
        internal WP_RVO GetRemarkByID(string id)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..REMARKWP where ID = "+id;
            int i = DA.Fill(DS, "t");
            if (i==0) return null;
            WP_RVO RVO = new WP_RVO();
            RVO.ID = id;
            RVO.CLOSED = (bool)DS.Tables["t"].Rows[0]["CLOSED"];
            RVO.CLOSINGCOMMENT = DS.Tables["t"].Rows[0]["CLOSINGCOMMENT"].ToString();
             
            //Type ty = o.GetType();
            RVO.DATECLOSE = (DS.Tables["t"].Rows[0]["DATECLOSE"].GetType() == typeof(DBNull)) ? DateTime.Now : (DateTime)DS.Tables["t"].Rows[0]["DATECLOSE"];
            RVO.DATEREMARK = (DateTime)DS.Tables["t"].Rows[0]["DATEREMARK"];
            RVO.DOCUMENTNAME = DS.Tables["t"].Rows[0]["DOCUMENTNAME"].ToString();
            RVO.IDCLOSER = DS.Tables["t"].Rows[0]["IDCLOSER"].ToString();
            RVO.IDCREATOR = DS.Tables["t"].Rows[0]["IDCREATOR"].ToString();
            RVO.IDWP = DS.Tables["t"].Rows[0]["IDWP"].ToString();
            RVO.REMARK = DS.Tables["t"].Rows[0]["REMARK"].ToString();
            return RVO;
        }
        internal DataTable GetRemarksByIDWPDOC(string DOCUMENTNAME,string IDWP)
        {
            DA.SelectCommand.CommandText = "select A.ID,W.WPNAME+' '+W.DECNUM WP,IDWP,DOCUMENTNAME, REMARK," +
                                           " case when DOCUMENTNAME = 'COMPOSITION' then 'Состав изделия' else " +
                                           " case when DOCUMENTNAME = 'DIMENSIONALDRAWING' then 'Габаритный чертёж' else " +
                                           " case when DOCUMENTNAME = 'CONFIGURATION' then 'Конфигурация' else " +
                                           " case when DOCUMENTNAME = 'WIRINGDIAGRAM' then 'Схема электрическая' else " +
                                           " case when DOCUMENTNAME = 'TECHREQ' then 'Технические требования' else " +
                                           " case when DOCUMENTNAME = 'SBORKA3D' then 'Сборка 3Д' else " +
                                           " case when DOCUMENTNAME = 'MECHPARTS' then 'Проект механических деталей' else " +
                                           " case when DOCUMENTNAME = 'SHILDS' then 'Шильды' else " +
                                           " case when DOCUMENTNAME = 'PACKAGING' then 'Упаковка' else " +
                                           " case when DOCUMENTNAME = 'SOFTWARE' then 'Программное обеспечение' else DOCUMENTNAME end end end end end end end end end end DOCUMENTNAME_RUS" +

                                           " ,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
                                           " case when CLOSED=1 then 'Отработано' else 'Открыто' end CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
                                           " from " + Base.BaseName + "..REMARKWP A" +
                                           " left join " + Base.BaseName + "..USERS B on A.IDCREATOR = B.ID " +
                                           " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID " +
                                           " left join " + Base.BaseName + "..USERS D on A.IDCLOSER = D.ID " +
                                           " left join " + Base.BaseName + "..ROLES E on D.ROLE = E.ID " +
                                           " left join " + Base.BaseName + "..WPNAMELIST W on A.IDWP = W.ID" +
                                           " where IDWP = " + IDWP + " and DOCUMENTNAME='" + DOCUMENTNAME + "' and CLOSED = 0  ";
            int i = DA.Fill(DS, "t");
            //if (i==0) return null;
            /*WP_RVO RVO = new WP_RVO();                  
            RVO.ID = DS.Tables["t"].Rows[0]["ID"].ToString();
            RVO.CLOSED = (bool)DS.Tables["t"].Rows[0]["CLOSED"];
            RVO.CLOSINGCOMMENT = DS.Tables["t"].Rows[0]["CLOSINGCOMMENT"].ToString();
            RVO.DATECLOSE = (DS.Tables["t"].Rows[0]["DATECLOSE"].GetType() == typeof(DBNull)) ? DateTime.Now : (DateTime)DS.Tables["t"].Rows[0]["DATECLOSE"];
            RVO.DATEREMARK = (DateTime)DS.Tables["t"].Rows[0]["DATEREMARK"];
            RVO.DOCUMENTNAME = DS.Tables["t"].Rows[0]["DOCUMENTNAME"].ToString();
            RVO.IDCLOSER = DS.Tables["t"].Rows[0]["IDCLOSER"].ToString();
            RVO.IDCREATOR = DS.Tables["t"].Rows[0]["IDCREATOR"].ToString();
            RVO.IDWP = DS.Tables["t"].Rows[0]["IDWP"].ToString();
            RVO.REMARK = DS.Tables["t"].Rows[0]["REMARK"].ToString();
            return RVO;*/
            return DS.Tables["t"];
        }

        internal string RemarkExists(string idwp, string DOCUMENTNAME)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..REMARKWP where IDWP = " + idwp+" and DOCUMENTNAME = '"+DOCUMENTNAME+"' and CLOSED = 0";
            int i = DA.Fill(DS, "t");
            if (i != 0)
                return DS.Tables["t"].Rows[0]["ID"].ToString();
            else
                return "";

        }

        internal object GetMy()
        {

             
            DA.SelectCommand.CommandText = "select A.ID,W.WPNAME+' '+W.DECNUM WP,IDWP,DOCUMENTNAME, REMARK," +
                                           " case when DOCUMENTNAME = 'COMPOSITION' then 'Состав изделия' else " +
                                           " case when DOCUMENTNAME = 'DIMENSIONALDRAWING' then 'Габаритный чертёж' else " +
                                           " case when DOCUMENTNAME = 'CONFIGURATION' then 'Конфигурация' else " +
                                           " case when DOCUMENTNAME = 'WIRINGDIAGRAM' then 'Схема электрическая' else " +
                                           " case when DOCUMENTNAME = 'TECHREQ' then 'Технические требования' else " +
                                           " case when DOCUMENTNAME = 'SBORKA3D' then 'Сборка 3Д' else " +
                                           " case when DOCUMENTNAME = 'MECHPARTS' then 'Проект механических деталей' else " +
                                           " case when DOCUMENTNAME = 'SHILDS' then 'Шильды' else " +
                                           " case when DOCUMENTNAME = 'PACKAGING' then 'Упаковка' else " +
                                           " case when DOCUMENTNAME = 'SOFTWARE' then 'Программное обеспечение' else DOCUMENTNAME end end end end end end end end end end DOCUMENTNAME_RUS" +

                                           " ,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
                                           " case when CLOSED=1 then 'Отработано' else 'Открыто' end CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
                                           " from " + Base.BaseName + "..REMARKWP A" +
                                           " left join " + Base.BaseName + "..USERS B on A.IDCREATOR = B.ID " +
                                           " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID " +
                                           " left join " + Base.BaseName + "..USERS D on A.IDCLOSER = D.ID " +
                                           " left join " + Base.BaseName + "..ROLES E on D.ROLE = E.ID " +
                                           " left join " + Base.BaseName + "..WPNAMELIST W on A.IDWP = W.ID";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal object GetFinished()
        {
            DA.SelectCommand.CommandText = "select A.ID,W.WPNAME+' '+W.DECNUM WP,IDWP,DOCUMENTNAME, REMARK," +
                                           " case when DOCUMENTNAME = 'COMPOSITION' then 'Состав изделия' else " +
                                           " case when DOCUMENTNAME = 'DIMENSIONALDRAWING' then 'Габаритный чертёж' else " +
                                           " case when DOCUMENTNAME = 'CONFIGURATION' then 'Конфигурация' else " +
                                           " case when DOCUMENTNAME = 'WIRINGDIAGRAM' then 'Схема электрическая' else " +
                                           " case when DOCUMENTNAME = 'TECHREQ' then 'Технические требования' else " +
                                           " case when DOCUMENTNAME = 'SBORKA3D' then 'Сборка 3Д' else " +
                                           " case when DOCUMENTNAME = 'MECHPARTS' then 'Проект механических деталей' else " +
                                           " case when DOCUMENTNAME = 'SHILDS' then 'Шильды' else " +
                                           " case when DOCUMENTNAME = 'PACKAGING' then 'Упаковка' else " +
                                           " case when DOCUMENTNAME = 'SOFTWARE' then 'Программное обеспечение' else DOCUMENTNAME end end end end end end end end end end DOCUMENTNAME_RUS" +

                                           " ,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
                                           " case when CLOSED=1 then 'Отработано' else 'Открыто' end CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
                                           " from " + Base.BaseName + "..REMARKWP A" +
                                           " left join " + Base.BaseName + "..USERS B on A.IDCREATOR = B.ID " +
                                           " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID " +
                                           " left join " + Base.BaseName + "..USERS D on A.IDCLOSER = D.ID " +
                                           " left join " + Base.BaseName + "..ROLES E on D.ROLE = E.ID " +
                                           " left join " + Base.BaseName + "..WPNAMELIST W on A.IDWP = W.ID "+
                                           " where A.CLOSED = 1";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
    }
}
