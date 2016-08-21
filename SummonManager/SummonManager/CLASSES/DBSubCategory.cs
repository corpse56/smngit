using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBSubCategory :DB
    {
        
        public DBSubCategory() { }

        public DataTable GetAll(int IDCat)
        {
            DA.SelectCommand.CommandText = "select ID,SUBCATNAME,IDCATEGORY,0 srt from " + Base.BaseName + "..SUBCATEGORYLIST where   SUBCATNAME = 'ВСЕ' and IDCATEGORY = " + IDCat+
                                           " union all" +
                                           " select ID,SUBCATNAME,IDCATEGORY,1 srt from " + Base.BaseName + "..SUBCATEGORYLIST where  IDCATEGORY = " + IDCat + "  and SUBCATNAME = 'НЕ ПРИСВОЕНО'" +
                                           " union all" +
                                           " select ID,SUBCATNAME,IDCATEGORY,2 srt from " + Base.BaseName + "..SUBCATEGORYLIST where  IDCATEGORY = " + IDCat + " and SUBCATNAME !='НЕ ПРИСВОЕНО' and SUBCATNAME != 'ВСЕ' order by srt,SUBCATNAME";

            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void AddNew(string p,int IDCat)
        {

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..SUBCATEGORYLIST (IDCATEGORY,SUBCATNAME) values (" + IDCat + ",'" + p + "')";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }
        //internal string Get(string p)
        //{
        //    DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUBCATEGORYLIST where ID = " + p;
        //    DA.Fill(DS, "t");
        //    return DS.Tables["t"].Rows[0]["SUBCATNAME"].ToString();
        //}
        internal void Edit(string name, string idsubcat)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..SUBCATEGORYLIST set SUBCATNAME  = '" + name + "'" +
                                            " where ID = " + idsubcat;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        //internal object GetAllExceptAll()
        //{
        //    DA.SelectCommand.CommandText = "select ID,CATEGORYNAME from " + Base.BaseName + "..CATEGORYLIST where ID != 2";
        //    DA.Fill(DS, "t");
        //    return DS.Tables["t"];
        //}

        internal void Delete(string ID)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..SUBCATEGORYLIST where ID = " + ID;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }

        internal string GetNameByID(int IDSUBCAT)
        {
            DA.SelectCommand.CommandText = "select ID,SUBCATNAME from " + Base.BaseName + "..SUBCATEGORYLIST where ID = " + IDSUBCAT;
            int i = DA.Fill(DS, "t");

            return (i>0) ? DS.Tables["t"].Rows[0]["SUBCATNAME"].ToString():"";
        }

        internal object GetAllExceptAll(int idCat)
        {
            DA.SelectCommand.CommandText = " select ID,SUBCATNAME,IDCATEGORY,1 srt from " + Base.BaseName + "..SUBCATEGORYLIST where  IDCATEGORY = " + idCat + "  and SUBCATNAME = 'НЕ ПРИСВОЕНО'" +
                                           " union all" +
                                           " select ID,SUBCATNAME,IDCATEGORY,2 srt from " + Base.BaseName + "..SUBCATEGORYLIST where  IDCATEGORY = " + idCat + " and SUBCATNAME !='НЕ ПРИСВОЕНО' and SUBCATNAME != 'ВСЕ' order by srt,SUBCATNAME";

            int i = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal string GetName(int ID)
        {
            if (ID == 0) return "НЕ ПРИСВОЕНО";
            
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUBCATEGORYLIST where ID = " + ID;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["SUBCATNAME"].ToString();
        }
    }
}
