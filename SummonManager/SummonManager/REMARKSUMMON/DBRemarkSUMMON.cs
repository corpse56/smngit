using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBRemarkSUMMON :DB
    {
        public DBRemarkSUMMON() { }

        public DataTable GetAll()
        {
            DA.SelectCommand.CommandText = "select A.ID,S.IDS,IDSUMMON,DOCUMENTNAME,REMARK," +
                                           " case when DOCUMENTNAME = 'SERIAL' then 'Серийный номер' else " +
                                           " case when DOCUMENTNAME = 'PLANKA' then 'Планка фирменная' else " +
                                           " case when DOCUMENTNAME = 'PASSPORT' then 'Паспорт изделия' else " +
                                           " case when DOCUMENTNAME = 'MANUAL' then 'РЭ' else " +
                                           " case when DOCUMENTNAME = 'PACKINGLIST' then 'Лист упаковочный' else DOCUMENTNAME end end end end end DOCUMENTNAME_RUS" +

                                           " ,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
                                           " case when CLOSED=1 then 'Отработано' else 'Открыто' end CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
                                           " from " + Base.BaseName + "..REMARKSUMMON A" +
                                           " left join " + Base.BaseName + "..USERS B on A.IDCREATOR = B.ID " +
                                           " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID " +
                                           " left join " + Base.BaseName + "..USERS D on A.IDCLOSER = D.ID " +
                                           " left join " + Base.BaseName + "..ROLES E on D.ROLE = E.ID "+
                                           " left join " + Base.BaseName + "..SUMMON S on A.IDSUMMON = S.ID ";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void AddNew(SummonRVO RVO)
        {
            DA.InsertCommand.Parameters.AddWithValue("DATEREMARK", RVO.DATEREMARK);
            DA.InsertCommand.Parameters.AddWithValue("DOCUMENTNAME", RVO.DOCUMENTNAME);
            DA.InsertCommand.Parameters.AddWithValue("IDCREATOR", RVO.IDCREATOR);
            DA.InsertCommand.Parameters.AddWithValue("IDSUMMON", RVO.IDSUMMON);
            DA.InsertCommand.Parameters.AddWithValue("REMARK", RVO.REMARK);

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..REMARKSUMMON (DATEREMARK,DOCUMENTNAME,IDCREATOR,IDSUMMON,REMARK) " +
                                           " values (@DATEREMARK,@DOCUMENTNAME,@IDCREATOR,@IDSUMMON,@REMARK)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal void Edit(SummonRVO RVO)
        {
            DA.UpdateCommand.Parameters.AddWithValue("ID", RVO.ID);
            DA.UpdateCommand.Parameters.AddWithValue("CLOSED", RVO.CLOSED);
            DA.UpdateCommand.Parameters.AddWithValue("CLOSINGCOMMENT", ((object)RVO.CLOSINGCOMMENT) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DATECLOSE", ((object)RVO.DATECLOSE) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DATEREMARK", RVO.DATEREMARK);
            DA.UpdateCommand.Parameters.AddWithValue("DOCUMENTNAME", RVO.DOCUMENTNAME);
            DA.UpdateCommand.Parameters.AddWithValue("IDCLOSER", ((object)RVO.IDCLOSER) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("IDCREATOR", RVO.IDCREATOR);
            DA.UpdateCommand.Parameters.AddWithValue("IDSUMMON", RVO.IDSUMMON);
            DA.UpdateCommand.Parameters.AddWithValue("REMARK", RVO.REMARK);


            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..REMARKSUMMON set CLOSED  = @CLOSED, CLOSINGCOMMENT=@CLOSINGCOMMENT "+
                                           ", DATECLOSE=@DATECLOSE, DATEREMARK=@DATEREMARK, DOCUMENTNAME=@DOCUMENTNAME,IDCLOSER=@IDCLOSER "+
                                           ", IDCREATOR=@IDCREATOR, IDSUMMON=@IDSUMMON, REMARK = @REMARK " +
                                            " where ID = @ID" ;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal SummonRVO GetRemarkByID(string id)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..REMARKSUMMON where ID = "+id;
            int i = DA.Fill(DS, "t");
            if (i==0) return null;
            SummonRVO RVO = new SummonRVO();
            RVO.ID = id;
            RVO.CLOSED = (bool)DS.Tables["t"].Rows[0]["CLOSED"];
            RVO.CLOSINGCOMMENT = DS.Tables["t"].Rows[0]["CLOSINGCOMMENT"].ToString();
            RVO.DATECLOSE = (DS.Tables["t"].Rows[0]["DATECLOSE"].GetType() == typeof(DBNull)) ? DateTime.Now : (DateTime)DS.Tables["t"].Rows[0]["DATECLOSE"];
            RVO.DATEREMARK = (DateTime)DS.Tables["t"].Rows[0]["DATEREMARK"];
            RVO.DOCUMENTNAME = DS.Tables["t"].Rows[0]["DOCUMENTNAME"].ToString();
            RVO.IDCLOSER = DS.Tables["t"].Rows[0]["IDCLOSER"].ToString();
            RVO.IDCREATOR = DS.Tables["t"].Rows[0]["IDCREATOR"].ToString();
            RVO.IDSUMMON = DS.Tables["t"].Rows[0]["IDSUMMON"].ToString();
            RVO.REMARK = DS.Tables["t"].Rows[0]["REMARK"].ToString();
            return RVO;
        }
        internal DataTable GetRemarksByIDSDOC(string DOCUMENTNAME, string IDSUMMON)
        {
            DA.SelectCommand.CommandText = "select A.ID,S.IDS,IDSUMMON,DOCUMENTNAME,REMARK," +
                                           " case when DOCUMENTNAME = 'SERIAL' then 'Серийный номер' else " +
                                           " case when DOCUMENTNAME = 'PLANKA' then 'Планка фирменная' else " +
                                           " case when DOCUMENTNAME = 'PASSPORT' then 'Паспорт изделия' else " +
                                           " case when DOCUMENTNAME = 'MANUAL' then 'РЭ' else " +
                                           " case when DOCUMENTNAME = 'PACKINGLIST' then 'Лист упаковочный' else DOCUMENTNAME end end end end end DOCUMENTNAME_RUS" +

                                           " ,DATEREMARK,B.FIO creator,C.ROLENAME createrole, " +
                                           " case when CLOSED=1 then 'Отработано' else 'Открыто' end CLOSED,CLOSINGCOMMENT,DATECLOSE,D.FIO closer,E.ROLENAME closerole " +
                                           " from " + Base.BaseName + "..REMARKSUMMON A" +
                                           " left join " + Base.BaseName + "..USERS B on A.IDCREATOR = B.ID " +
                                           " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID " +
                                           " left join " + Base.BaseName + "..USERS D on A.IDCLOSER = D.ID " +
                                           " left join " + Base.BaseName + "..ROLES E on D.ROLE = E.ID "+
                                           " left join " + Base.BaseName + "..SUMMON S on A.IDSUMMON = S.ID "+
                                           " where IDSUMMON = " + IDSUMMON + " and DOCUMENTNAME='" + DOCUMENTNAME + "' and CLOSED = 0";
            int i = DA.Fill(DS, "t");
            //if (i==0) return null;
            /*SummonRVO RVO = new SummonRVO();
            RVO.ID = DS.Tables["t"].Rows[0]["ID"].ToString();
            RVO.CLOSED = (bool)DS.Tables["t"].Rows[0]["CLOSED"];
            RVO.CLOSINGCOMMENT = DS.Tables["t"].Rows[0]["CLOSINGCOMMENT"].ToString();
            RVO.DATECLOSE = (DS.Tables["t"].Rows[0]["DATECLOSE"].GetType() == typeof(DBNull)) ? DateTime.Now : (DateTime)DS.Tables["t"].Rows[0]["DATECLOSE"];
            RVO.DATEREMARK = (DateTime)DS.Tables["t"].Rows[0]["DATEREMARK"];
            RVO.DOCUMENTNAME = DS.Tables["t"].Rows[0]["DOCUMENTNAME"].ToString();
            RVO.IDCLOSER = DS.Tables["t"].Rows[0]["IDCLOSER"].ToString();
            RVO.IDCREATOR = DS.Tables["t"].Rows[0]["IDCREATOR"].ToString();
            RVO.IDSUMMON = DS.Tables["t"].Rows[0]["IDSUMMON"].ToString();
            RVO.REMARK = DS.Tables["t"].Rows[0]["REMARK"].ToString();
            return RVO;*/
            return DS.Tables["t"];
        }

        internal string RemarkExists(string idsumm, string DOCUMENTNAME)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..REMARKSUMMON where IDSUMMON = " + idsumm + " and DOCUMENTNAME = '" + DOCUMENTNAME + "' and CLOSED = 0";
            int i = DA.Fill(DS, "t");
            if (i != 0)
                return DS.Tables["t"].Rows[0]["ID"].ToString();
            else
                return "";
        }
    }
}
