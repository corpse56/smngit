using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager.CLASSES
{
    class DBCableList :DB
    {
        public DataTable GetPackage(int IDWP)
        {
            DA.SelectCommand.Parameters.AddWithValue("IDWP", IDWP);
            DA.SelectCommand.CommandText = " select A.ID idc,A.ID nn,B.CABLENAME name,A.CNT " +
                                           " from " + Base.BaseName + "..CABLES A " +
                                           " left join " + Base.BaseName + "..CABLELIST B ON B.ID = A.IDCABLE " +
                                           "  where IDWP = @IDWP ";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public List<CableVO> GetPackageForVO(int IDWP)
        {
            DA.SelectCommand.Parameters.AddWithValue("IDWP", IDWP);
            DA.SelectCommand.CommandText = " select A.IDCABLE id,A.ID nn,B.CABLENAME name,A.CNT " +
                                           " from " + Base.BaseName + "..CABLES A "+
                                           " left join " + Base.BaseName + "..CABLELIST B ON B.ID = A.IDCABLE " +
                                           "  where IDWP = @IDWP ";
            DA.Fill(DS, "t");
            List<CableVO> ret = new List<CableVO>();
            foreach (DataRow r in DS.Tables["t"].Rows)
            {
                ret.Add(CableVO.GetCableVOByID((int)r["id"]));
            }

            return ret;
        }

        internal CableVO GetCableVOByID(int ID)
        {
            DA.SelectCommand.Parameters.AddWithValue("ID", ID);
            DA.SelectCommand.CommandText = " select * from " + Base.BaseName + "..CABLELIST where ID = @ID ";
            DA.Fill(DS, "t");
            DataRow r = DS.Tables["t"].Rows[0];
            CableVO CVO = new CableVO();
            CVO.ID = (int)r["ID"];
            CVO.WPName = r["CABLENAME"].ToString();
            CVO.IDCat = (int)r["IDCATEGORY"];
            CVO.IDSubCat = (r["IDSUBCAT"] == DBNull.Value) ? 0 : (int)r["IDSUBCAT"];
            CVO.DecNum = r["DECNUM"].ToString();
            CVO.DIMENDRAWING = r["DIMENSIONALDRAWING"].ToString();
            CVO.CONECTORS = r["CONNECTORS"].ToString();
            CVO.CLENGTH = r["CLENGTH"].ToString();
            CVO.NOTE = r["NOTE"].ToString();
            CVO.WPType = WPTYPE.CABLELIST;
            return CVO;
        }
        public DataTable GetAllCables()
        {
            DA.SelectCommand.CommandText = "select A.ID,A.CABLENAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.DIMENSIONALDRAWING,A.CONNECTORS,A.CLENGTH,A.NOTE from " +
                                            Base.BaseName + "..CABLELIST A " +
                                           " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                           " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                           " order by CABLENAME";
            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public DataTable GetCategoryCableList(int IDCAT, int IDSUBCAT)
        {
            if (IDCAT == 13) return this.GetAllCables();
            string sub = new DBSubCategory().GetNameByID(IDSUBCAT);
            if (sub.ToUpper() == "ВСЕ")
            {
                DA.SelectCommand.CommandText = "select A.ID,A.CABLENAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.DIMENSIONALDRAWING,A.CONNECTORS,A.CLENGTH,A.NOTE from " +
                                                 Base.BaseName + "..CABLELIST A " +
                                               " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " order by CABLENAME";
            }
            else if (sub.ToUpper() == "НЕ ПРИСВОЕНО")
            {
                DA.SelectCommand.CommandText = "select A.ID,A.CABLENAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.DIMENSIONALDRAWING,A.CONNECTORS,A.CLENGTH,A.NOTE from " +
                                                Base.BaseName + "..CABLELIST A " +
                                               " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " and ((A.IDSUBCAT is null) or (C.SUBCATNAME = 'НЕ ПРИСВОЕНО'))  order by CABLENAME";
            }
            else
            {
                DA.SelectCommand.CommandText = "select A.ID,A.CABLENAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.DIMENSIONALDRAWING,A.CONNECTORS,A.CLENGTH,A.NOTE from " +
                                                 Base.BaseName + "..CABLELIST A " +
                                               " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " and (A.IDSUBCAT = " + IDSUBCAT + ")  order by CABLENAME";
            }

            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public DataTable GetCategoryCableList(int IDCAT)
        {
            if (IDCAT == 13) return this.GetAllCables();//13 это категория ВСЕ у CABLELIST
            DA.SelectCommand.CommandText = "select A.ID,A.CABLENAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.DIMENSIONALDRAWING,A.CONNECTORS,A.CLENGTH,A.NOTE from " +
                                            Base.BaseName + "..CABLELIST A " +
                                           " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                           " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                           " where A.IDCATEGORY = " + IDCAT + " order by CABLENAME";
            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void EditCable(CableVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("CABLENAME", p.WPName);
            DA.UpdateCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.UpdateCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.UpdateCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWING", ((object)p.DIMENDRAWING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("CLENGTH", p.CLENGTH);
            DA.UpdateCommand.Parameters.AddWithValue("CONNECTORS", p.CONECTORS);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.NOTE);
            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..CABLELIST set CABLENAME  = @CABLENAME,IDCATEGORY = @IDCATEGORY,IDSUBCAT = @IDSUBCAT,DECNUM = @DECNUM, " +
                                           " DIMENSIONALDRAWING=@DIMENSIONALDRAWING, " +
                                           " CLENGTH=@CLENGTH, CONNECTORS=@CONNECTORS," +
                                           " NOTE = @NOTE   "+
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal void AddNewCable(CableVO p)
        {
            int ID = new DBProduct().AddNewProduct(p);
            DA.InsertCommand.Parameters.Clear();
            DA.InsertCommand.Parameters.AddWithValue("ID", ID);
            DA.InsertCommand.Parameters.AddWithValue("CABLENAME", p.WPName);
            DA.InsertCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.InsertCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.InsertCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.InsertCommand.Parameters.AddWithValue("DIMENSIONALDRAWING", ((object)p.DIMENDRAWING) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("CLENGTH", p.CLENGTH);
            DA.InsertCommand.Parameters.AddWithValue("CONNECTORS", p.CONECTORS);
            DA.InsertCommand.Parameters.AddWithValue("NOTE", p.NOTE);
            DA.InsertCommand.Parameters.AddWithValue("CREATED", DateTime.Now);

            //wp.ZHGUTS = new DBZhgutList().GetPackageForVO(wp.ID);
            /////////////////////////////////////////////////////////////////////////////////    ЗАПРЕЩЕНО НАПОЛНЯТЬ ЖГУТЫ КОГДА СОЗДАЁШЬ ИЗДЕЛИЕ!!!!!!!!!!!!!!!!!
            //wp.CABLES = new DBCableList().GetPackageForVO(wp.ID);

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CABLELIST " +
                                           " (ID,CABLENAME,IDCATEGORY,IDSUBCAT,DECNUM,DIMENSIONALDRAWING,CLENGTH,CONNECTORS, " +
                                           " NOTE,CREATED)      " +
                                           " values (@ID,@CABLENAME,@IDCATEGORY,@IDSUBCAT,@DECNUM,@DIMENSIONALDRAWING,@CLENGTH,@CONNECTORS, " +
                                           " @NOTE,@CREATED)      ";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }
        internal bool Exists(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUMMON where IDWP = " + p + " and WPTYPE = 'CABLELIST'";
            int i = DA.Fill(DS, "t");
            return (i > 0) ? true : false;
        }

        internal void DeleteByID(string p)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..CABLELIST where ID = " + p;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }

        internal void AddToPackage(int IDWP, int IDCABLE,int CNT)
        {
            DA.InsertCommand.Parameters.Clear();
            DA.InsertCommand.Parameters.AddWithValue("IDWP", IDWP);
            DA.InsertCommand.Parameters.AddWithValue("IDCABLE", IDCABLE);
            DA.InsertCommand.Parameters.AddWithValue("CNT", CNT);

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CABLES " +
                                           " (IDWP,IDCABLE,CNT)      " +
                                           " values (@IDWP,@IDCABLE,@CNT)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal void RemoveFromPackage(int p)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..CABLES where ID = " + p;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }
    }
}
