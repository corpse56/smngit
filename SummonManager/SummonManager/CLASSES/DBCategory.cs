using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBCategory :DB
    {
        string ENTITY;
        public DBCategory(string ENTITY_)
        {
            this.ENTITY = ENTITY_;
        }

        public DataTable GetAll()
        {
            DA.SelectCommand.Parameters.AddWithValue("Entity", this.ENTITY);
            DA.SelectCommand.CommandText = "select ID,CATEGORYNAME from " + Base.BaseName + "..CATEGORYLIST where ENTITY = @Entity";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void AddNew(string CatName)
        {
            DA.InsertCommand.Parameters.AddWithValue("CatName", CatName);
            DA.InsertCommand.Parameters.AddWithValue("Entity", this.ENTITY);
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CATEGORYLIST (CATEGORYNAME,ENTITY) values (@CatName,@Entity)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }
        internal string GetName(int ID)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CATEGORYLIST where ID = " + ID;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CATEGORYNAME"].ToString();
        }
        internal void Edit(string CatName, string id)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..CATEGORYLIST set CATEGORYNAME  = '" + CatName + "'" +
                                            " where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
        internal void Delete(string ID)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..CATEGORYLIST where ID = " + ID;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }
        internal object GetAllExceptAll()
        {
            DA.SelectCommand.Parameters.AddWithValue("Entity", this.ENTITY);
            DA.SelectCommand.CommandText = "select ID,CATEGORYNAME from " + Base.BaseName + "..CATEGORYLIST where CATEGORYNAME != 'ВСЕ' and ENTITY = @Entity";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal int GetSubCatNE_PRISVOENO()
        {
            DA.SelectCommand.Parameters.AddWithValue("Entity", this.ENTITY);
            DA.SelectCommand.CommandText = "select ID,CATEGORYNAME from " + Base.BaseName + "..CATEGORYLIST where CATEGORYNAME != 'ВСЕ' and ENTITY = @Entity";
            DA.Fill(DS, "t");
            return (int)DS.Tables["t"].Rows[0]["ID"];
        }
    }
}
