using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager.CLASSES
{
    class DBZhgutList :DB
    {
        public DataTable GetPackage(int IDWP)
        {
            DA.SelectCommand.Parameters.AddWithValue("IDWP", IDWP);
            DA.SelectCommand.CommandText = " select A.ID idz,A.ID nn,B.ZHGUTNAME name,A.CNT CNT" +
                                           " from " + Base.BaseName + "..ZHGUTS A " +
                                           " left join " + Base.BaseName + "..ZHGUTLIST B ON B.ID = A.IDZHGUT " +
                                           " where IDWP = @IDWP ";
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }


        internal ZhgutVO GetZhgutVOByID(int ID)
        {
            DA.SelectCommand.Parameters.AddWithValue("ID", ID);
            DA.SelectCommand.CommandText = " select * from " + Base.BaseName + "..ZHGUTLIST where ID = @ID ";
            DA.Fill(DS, "t");
            DataRow r = DS.Tables["t"].Rows[0];
            ZhgutVO ZVO = new ZhgutVO();
            ZVO.ID = (int)r["ID"];
            ZVO.WPName = r["ZHGUTNAME"].ToString();
            ZVO.IDCat = (int)r["IDCATEGORY"];
            ZVO.IDSubCat = (r["IDSUBCAT"] == DBNull.Value) ? 0 : (int)r["IDSUBCAT"];
            ZVO.DecNum = r["DECNUM"].ToString();
            ZVO.ZHGUTPATH = r["ZHGUTPATH"].ToString();
            ZVO.NOTE = r["NOTE"].ToString();
            ZVO.WPType = WPTYPE.ZHGUTLIST;
            return ZVO;
        }

        internal List<ZhgutVO> GetPackageForVO(int IDWP)
        {
            DA.SelectCommand.Parameters.AddWithValue("IDWP", IDWP);
            DA.SelectCommand.CommandText = " select A.IDZHGUT id,A.ID nn,B.ZHGUTNAME name,A.CNT " +
                                           " from " + Base.BaseName + "..ZHGUTS A" +
                                           " left join " + Base.BaseName + "..ZHGUTLIST B ON B.ID = A.IDZHGUT "+
                                           "  where IDWP = @IDWP ";
            DA.Fill(DS, "t");
            List<ZhgutVO> ret = new List<ZhgutVO>();
            foreach (DataRow r in DS.Tables["t"].Rows)
            {
                ret.Add(ZhgutVO.GetZhgutVOByID((int)r["id"]));
            }

            return ret;
        }
        public DataTable GetAllZhguts()
        {
            DA.SelectCommand.CommandText = "select A.ID,A.ZHGUTNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.ZHGUTPATH,A.NOTE from "
                                            + Base.BaseName + "..ZHGUTLIST A "+
                                           " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                           " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                           " order by ZHGUTNAME";
            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public DataTable GetCategoryZhgutList(int IDCAT, int IDSUBCAT)
        {
            if (IDCAT == 15) return this.GetAllZhguts();
            string sub = new DBSubCategory().GetNameByID(IDSUBCAT);
            if (sub.ToUpper() == "ВСЕ")
            {
                DA.SelectCommand.CommandText = "select A.ID,A.ZHGUTNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.ZHGUTPATH,A.NOTE from " +
                                                 Base.BaseName + "..ZHGUTLIST A "+
                                               " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " order by ZHGUTNAME";
            }
            else if (sub.ToUpper() == "НЕ ПРИСВОЕНО")
            {
                DA.SelectCommand.CommandText = "select A.ID,A.ZHGUTNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.ZHGUTPATH,A.NOTE from " +
                                                Base.BaseName + "..ZHGUTLIST A " +
                                               " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " and ((A.IDSUBCAT is null) or (C.SUBCATNAME = 'НЕ ПРИСВОЕНО'))  order by ZHGUTNAME";
            }
            else
            {
                DA.SelectCommand.CommandText = "select A.ID,A.ZHGUTNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.ZHGUTPATH,A.NOTE from " +
                                                 Base.BaseName + "..ZHGUTLIST A " +
                                               " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " and (A.IDSUBCAT = " + IDSUBCAT + ")  order by ZHGUTNAME";
            }

            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public DataTable GetCategoryZhgutList(int IDCAT)
        {
            if (IDCAT == 15) return this.GetAllZhguts();
            DA.SelectCommand.CommandText = "select A.ID,A.ZHGUTNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.ZHGUTPATH,A.NOTE from " +
                                            Base.BaseName + "..ZHGUTLIST A " +
                                           " left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                           " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                           " where A.IDCATEGORY = " + IDCAT + " order by ZHGUTNAME";
            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void EditZhgut(ZhgutVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("ZHGUTNAME", p.WPName);
            DA.UpdateCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.UpdateCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.UpdateCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.UpdateCommand.Parameters.AddWithValue("ZHGUTPATH", ((object)p.ZHGUTPATH) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.NOTE);
            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..ZHGUTLIST set ZHGUTNAME  = @ZHGUTNAME,IDCATEGORY = @IDCATEGORY,IDSUBCAT = @IDSUBCAT,DECNUM = @DECNUM, " +
                                           " ZHGUTPATH=@ZHGUTPATH, " +
                                           " NOTE = @NOTE   " +
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal void AddNewZhgut(ZhgutVO p)
        {
            int ID = new DBProduct().AddNewProduct(p);
            DA.InsertCommand.Parameters.Clear();
            DA.InsertCommand.Parameters.AddWithValue("ID", ID);
            DA.InsertCommand.Parameters.AddWithValue("ZHGUTNAME", p.WPName);
            DA.InsertCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.InsertCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.InsertCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.InsertCommand.Parameters.AddWithValue("ZHGUTPATH", ((object)p.ZHGUTPATH) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("NOTE", p.NOTE);
            DA.InsertCommand.Parameters.AddWithValue("CREATED", DateTime.Now);

            //wp.ZHGUTS = new DBZhgutList().GetPackageForVO(wp.ID);
            /////////////////////////////////////////////////////////////////////////////////    ЗАПРЕЩЕНО НАПОЛНЯТЬ ЖГУТЫ КОГДА СОЗДАЁШЬ ИЗДЕЛИЕ!!!!!!!!!!!!!!!!!
            //wp.CABLES = new DBCableList().GetPackageForVO(wp.ID);

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..ZHGUTLIST " +
                                           " (ID,ZHGUTNAME,IDCATEGORY,IDSUBCAT,DECNUM,ZHGUTPATH, " +
                                           " NOTE,CREATED)      " +
                                           " values (@ID,@ZHGUTNAME,@IDCATEGORY,@IDSUBCAT,@DECNUM,@ZHGUTPATH, " +
                                           " @NOTE,@CREATED)      ";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }
        internal bool Exists(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUMMON where IDWP = " + p + " and WPTYPE = 'ZHGUTLIST'";
            int i = DA.Fill(DS, "t");
            return (i > 0) ? true : false;
        }

        
        internal void DeleteByID(string p)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..ZHGUTLIST where ID = "+p;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }


        internal void RemoveFromPackage(int p)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..ZHGUTS where ID = " + p;
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

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..ZHGUTS " +
                                           " (IDWP,IDZHGUT,CNT)      " +
                                           " values (@IDWP,@IDCABLE,@CNT)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }        
    }
}
