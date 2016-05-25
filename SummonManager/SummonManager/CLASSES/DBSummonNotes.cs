using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBSummonNotes:DB
    {
        public DBSummonNotes() { }

        public DataTable GetAllNotesByIDSummon(string id)
        {
            DA.SelectCommand.CommandText = "select A.ID,A.IDSUMMON,A.CREATED,C.ROLENAME,B.FIO,A.NOTE from " + Base.BaseName + "..NOTES A "+
                                            " left join " + Base.BaseName + "..USERS B on A.IDUSER = B.ID " +
                                            " left join " + Base.BaseName + "..ROLES C on B.ROLE = C.ID " +
                                            "where A.IDSUMMON = " + id+
                                            " order by A.CREATED";
            int i = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        public void AddNote(string ID, string note, string IDUser)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..NOTES (IDSUMMON,CREATED,IDUSER,NOTE) values "+
                                           " (" + ID + ",getdate(),"+IDUser+",'"+note+"')";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();

        }

        internal void UpdateNote(string idnote, string note)
        {
            DA.UpdateCommand.Parameters.AddWithValue("note", note);
            DA.UpdateCommand.Parameters.AddWithValue("idnote", idnote);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..NOTES set NOTE = @note where ID = @idnote";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    }
}
