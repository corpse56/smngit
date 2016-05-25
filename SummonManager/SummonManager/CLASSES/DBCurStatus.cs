using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SummonManager.CLASSES;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    class DBCurStatus :DB
    {
        public DBCurStatus() { }

        public void AddNewCurstatus(string IDS,string iduser)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CURSTATUS (IDS,STATID,CAUSE,CHANGED,IDUSER) " +
                                           " values ('"+IDS+"',1,'Новое','" + DateTime.Now.ToString("yyyyMMdd HH:mm") + "'," + iduser + ")";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CURSTATUS (IDS,STATID,CAUSE,CHANGED,IDUSER) " +
                                           " values ('" + IDS + "',3,'-','" + DateTime.Now.ToString("yyyyMMdd HH:mm") + "'," + iduser + ")";
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set IDSTATUS = 3 where IDS = '" + IDS + "'";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();

        }

        internal void SaveNewCurstatus(string IDS, string iduser)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CURSTATUS (IDS,STATID,CAUSE,CHANGED,IDUSER) " +
                                           " values ('" + IDS + "',1,'Новое','" + DateTime.Now.ToString("yyyyMMdd HH:mm") + "'," + iduser + ")";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set IDSTATUS = 1 where IDS = '" + IDS + "'";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();

        }

        internal void ChangeStatus(SummonVO SVO, int idstatus, string cause, string iduser)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CURSTATUS (IDS,STATID,CAUSE,CHANGED,IDUSER) " +
                      " values ('" + SVO.IDS + "'," + idstatus.ToString() + ",@cause,'" + DateTime.Now.ToString("yyyyMMdd HH:mm") + "'," + iduser + ")";
            DA.InsertCommand.Parameters.Add("cause", System.Data.SqlDbType.NVarChar);
            DA.InsertCommand.Parameters["cause"].Value = cause;
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
            DA.InsertCommand.Parameters.Remove(DA.InsertCommand.Parameters["cause"]);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set VIEWED = 0,IDSTATUS = " + idstatus.ToString() + " where IDS = '" + SVO.IDS + "'";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
        internal void ChangeStatus(SummonVO SVO, int idstatus, string iduser)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CURSTATUS (IDS,STATID,CAUSE,CHANGED,IDUSER) " +
                      " values ('" + SVO.IDS + "'," + idstatus.ToString() + ",@cause,'" + DateTime.Now.ToString("yyyyMMdd HH:mm") + "'," + iduser + ")";
            DA.InsertCommand.Parameters.Add("cause", System.Data.SqlDbType.NVarChar);
            DA.InsertCommand.Parameters["cause"].Value = "";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
            DA.InsertCommand.Parameters.Remove(DA.InsertCommand.Parameters["cause"]);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set VIEWED = 0,IDSTATUS = " + idstatus.ToString() + " where IDS = '" + SVO.IDS + "'";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        public DataTable GetAllStatuses()
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..STATUSLIST where ID != 14,2,6,8,11";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        
        //public DataTable GetAllStatuses(Roles role)
        //{
        //    DS = new DataSet();
        //    switch (role)
        //    {
        //        case Roles.Logist:
        //            DA.SelectCommand.CommandText = "select ID,'Закрыть извещение' SNAME from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and (ID = 13)";
        //            break;
        //        case Roles.Manager:
        //            DA.SelectCommand.CommandText = "select ID,'ПДБ' SNAME from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (3)";
        //            break;
        //        case Roles.Montage:
        //            DA.SelectCommand.CommandText = "select ID,case when ID = 16 then 'ОТК' else 'Цех' end SNAME from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (16,5)";
        //            break;
        //        case Roles.OTK:
        //            //DA.SelectCommand.CommandText = "select ID,case when ID = 2 then 'Менеджер' else 'Коммерческий отдел' end SNAME from " + Base.BaseName +
        //            DA.SelectCommand.CommandText = "select ID,case when ID = 2 then 'Менеджер' else " +
        //                                                    " case when ID = 9 then 'Коммерческий отдел' else" +
        //                                                    " case when ID = 8 then 'Цех (на рекламацию)' else" +
        //                                                    " case when ID = 3 then 'ПДБ' else" +
        //                                                    " case when ID = 4 then 'Производство' else" +
        //                                                    " 'Монтажники' end end end end end SNAME" +
        //                                                    " from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (9,2,8,18,3,4)--,8,17,18)";
        //            break;
        //        case Roles.Ozis:
        //            //DA.SelectCommand.CommandText = "select ID,case when ID = 4 then 'Производство' else 'Монтажники' end SNAME from " + Base.BaseName +
        //            DA.SelectCommand.CommandText = "select ID,case when ID = 4 then 'Производство' else " +
        //                                                    " case when ID = 15 then 'Монтажники' else" +
        //                                                    " case when ID = 2 then 'Менеджер' else" +
        //                                                    " 'Монтажники' end end end SNAME" +
        //                                                    " from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (4,15,2)";
        //            break;
        //        case Roles.Prod:
        //            DA.SelectCommand.CommandText = "select ID,case when ID = 5 then 'Цех' else " +
        //                                                    " case when ID = 3 then 'ПДБ' else" +
        //                                                    " case when ID = 7 then 'ОТК' else" +
        //                                                    " 'Монтажники' end end end SNAME" +
        //                                                    " from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (5,3,7,15)";
        //            break;
        //        case Roles.Ware:
        //            DA.SelectCommand.CommandText = "select ID,'Отдел логистики' SNAME from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (11)";
        //            break;
        //        case Roles.Wsh:
        //            DA.SelectCommand.CommandText = "select ID,case when ID = 7 then 'ОТК' else " +
        //                                                    " case when ID = 6 then 'Производство' else" +
        //                                                    " case when ID = 3 then 'ПДБ' else" +
        //                                                    " 'Монтажники' end end end SNAME" +
        //                                                    " from " + Base.BaseName +
        //                "..STATUSLIST where ID != 14 and ID in (7,6,3,15)";
        //            break;
        //    }
        //    //DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..STATUSLIST where ID != 14";
        //    DA.Fill(DS, "t");
        //    return DS.Tables["t"];
        //}
        public int DefaultStatus = 0;
        public int DefaultSubStatus = 0;
        internal object GetAllStatuses(IRole UVO, SummonVO SVO)
        {
            DS = new DataSet();
            switch (UVO.Role)
            {
                case Roles.Admin: case Roles.Director:
                    DA.SelectCommand.CommandText = "select ID,SNAME from " + Base.BaseName +
                        "..STATUSLIST where  ID not in (2,6,11,14,15,16,17,18)";
                    DefaultStatus = 2;
                    break;
                case Roles.Logist:
                    DA.SelectCommand.CommandText = "select ID,'Закрыть извещение' SNAME from " + Base.BaseName +
                        "..STATUSLIST where  (ID = 13)";
                    DefaultStatus = 13;
                    break;
                case Roles.Manager:
                    DA.SelectCommand.CommandText = "select ID,'ПДБ' SNAME from " + Base.BaseName +
                        "..STATUSLIST where  ID in (3)";
                    DefaultStatus = 3;
                    break;
                case Roles.Montage: case Roles.MainMontage:
                    DA.SelectCommand.CommandText = "select ID,'В ОТК от монтажников' SNAME from " + Base.BaseName +
                    "..STATUSLIST where ID in (16)";
                    DefaultStatus = 16;
                    break;
                case Roles.OTK:
                    if ((SVO.ProductVO.GetProductType() == WPTYPE.CABLELIST) || (SVO.ProductVO.GetProductType() == WPTYPE.ZHGUTLIST))
                    {
                        DA.SelectCommand.CommandText = "select ID, SNAME from " + Base.BaseName +
                        "..STATUSLIST where ID in (8,9,18)";
                        DefaultStatus = 9;
                    }
                    else
                    {
                        if (SVO.SISP)
                        {
                            if (SVO.IDSTATUS == 19)
                            {
                                DA.SelectCommand.CommandText = "select ID,'Производство после СИ и СП' SNAME from " + Base.BaseName +
                                "..STATUSLIST where ID in (21)";
                                DefaultStatus = 21;
                            }
                            else if (SVO.IDSTATUS == 20)
                            {
                                DA.SelectCommand.CommandText = "select ID,'Цех после СИ и СП' SNAME from " + Base.BaseName +
                                "..STATUSLIST where ID in (22)";
                                DefaultStatus = 22;
                            }
                            else
                            {
                                DA.SelectCommand.CommandText = "select ID,'Коммерческий отдел' SNAME from " + Base.BaseName +
                                                                "..STATUSLIST where ID in (9)";
                                DefaultStatus = 9;
                            }

                        }
                        else
                        {
                            DA.SelectCommand.CommandText = "select ID, SNAME from " + Base.BaseName +
                            "..STATUSLIST where ID in (8,9)";
                            DefaultStatus = 9;
                        }
                    }
                    break;
                case Roles.Ozis:
                    if ((SVO.ProductVO.GetProductType() == WPTYPE.CABLELIST) || (SVO.ProductVO.GetProductType() == WPTYPE.ZHGUTLIST))
                    {
                        DA.SelectCommand.CommandText = "select ID, 'Монтажники' SNAME " +
                                                                " from " + Base.BaseName +
                            "..STATUSLIST where  ID in (15)";
                        DefaultStatus = 15;
                    }
                    else
                    {
                        DA.SelectCommand.CommandText = "select ID, 'Производство' SNAME " +
                                                                " from " + Base.BaseName +
                            "..STATUSLIST where ID in (4)";
                        DefaultStatus = 4;

                    }

                    break;
                case Roles.Prod:
                    if (SVO.SISP)
                    {
                        if (SVO.IDSTATUS == 21)
                        {
                            DA.SelectCommand.CommandText = "select ID, 'Цех' SNAME" +
                                                                    " from " + Base.BaseName +
                                "..STATUSLIST where ID in (5)";
                            DefaultStatus = 5;
                        }
                        else
                        {
                            DA.SelectCommand.CommandText = "select ID, 'СИ и СП (ОТК - Произ-во)' SNAME" +
                                                                    " from " + Base.BaseName +
                                "..STATUSLIST where ID in (19)";
                            DefaultStatus = 19;
                        }
                    }
                    else
                    {
                        DA.SelectCommand.CommandText = "select ID, 'Цех' SNAME" +
                                        " from " + Base.BaseName +
                        "..STATUSLIST where ID in (5)";
                        DefaultStatus = 5;
                    }
                    break;
                case Roles.Ware:
                    DA.SelectCommand.CommandText = "select ID,'Отгружается' SNAME from " + Base.BaseName +
                        "..STATUSLIST where ID in (12)";
                    DefaultStatus = 12;
                    break;
                case Roles.Wsh:
                    if (SVO.SISP)
                    {
                        if (SVO.IDSTATUS == 22)
                        {
                            DA.SelectCommand.CommandText = "select ID, 'OTK' SNAME" +
                                                                    " from " + Base.BaseName +
                                "..STATUSLIST where  ID in (7)";
                            DefaultStatus = 7;
                        }
                        else
                        {
                            DA.SelectCommand.CommandText = "select ID, 'СИ и СП (ОТК - Цех)' SNAME" +
                                                                    " from " + Base.BaseName +
                                "..STATUSLIST where  ID in (20)";
                            DefaultStatus = 20;
                        }
                    }
                    else
                    {
                        DA.SelectCommand.CommandText = "select ID, 'ОТК' SNAME" +
                                        " from " + Base.BaseName +
                        "..STATUSLIST where ID in (7)";
                        DefaultStatus = 7;
                    }
                    break;
                default:
                    DA.SelectCommand.CommandText = "select ID, 'ОТК' SNAME" +
                                    " from " + Base.BaseName +
                    "..STATUSLIST where ID in (7777)";
                    DefaultStatus = 0;

                    break;
            }
            //DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..STATUSLIST where ID != 14";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }


        internal object GetAllSubStatuses(IRole UVO, SummonVO SVO)
        {
            DS = new DataSet();
            switch (UVO.Role)
            {
                case Roles.OTK:
                    DA.SelectCommand.CommandText = "select ID,case when ID = 17 then 'Субстатус закрыт' else " +
                                                            " 'Возвращено монтажникам из ОТК'  end SNAME" +
                                                            " from " + Base.BaseName +
                                                    "..STATUSLIST where ID in (17,18)";
                    DefaultSubStatus = 17;
                    break;
                case Roles.Ozis:
                    DA.SelectCommand.CommandText = "select ID, 'Монтажники' SNAME " +
                                                            " from " + Base.BaseName +
                                                    "..STATUSLIST where ID in (15)";
                    DefaultSubStatus = 15;
                    break;
                case Roles.Montage: case Roles.MainMontage:
                    DA.SelectCommand.CommandText = "select ID, 'ОТК' SNAME from " + Base.BaseName +
                        "..STATUSLIST where ID in (16)";
                    DefaultSubStatus = 16;
                    break;
                case Roles.Admin:
                    DA.SelectCommand.CommandText = "select ID, SNAME from " + Base.BaseName +
                        "..STATUSLIST where ID in (15,16,17,18)";
                    DefaultSubStatus = 18;
                    break;

            }
            DA.Fill(DS, "t");
            return DS.Tables["t"];

        }

        internal void ChangeSubStatus(SummonVO SVO, int idstatus, string iduser)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CURSUBSTATUS (IDS,STATID,CAUSE,CHANGED,IDUSER) " +
                      " values ('" + SVO.IDS + "'," + idstatus.ToString() + ",@cause,'" + DateTime.Now.ToString("yyyyMMdd HH:mm") + "'," + iduser + ")";
            DA.InsertCommand.Parameters.Add("cause", System.Data.SqlDbType.NVarChar);
            DA.InsertCommand.Parameters["cause"].Value = "";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
            DA.InsertCommand.Parameters.Remove(DA.InsertCommand.Parameters["cause"]);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUMMON set VIEWED = 0,IDSUBST = " + idstatus.ToString() + " where IDS = '" + SVO.IDS + "'";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal string GetStatusNameByID(int p)
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..STATUSLIST where ID ="+p;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["SNAME"].ToString();

        }

        internal string GetSubStatusNameByID(int p)
        {
            throw new NotImplementedException();
        }
    }
}
