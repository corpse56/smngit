using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SummonManager
{
    class DBPreferences : DB
    {
        public int RefreshTime;
        public int NoteColor;

        public DBPreferences(int UID)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PREFERENCES where IDUSER = " + UID;
            if (DA.Fill(DS, "t") == 0)
            {

                int color = new ColorSelectControl().panel1.BackColor.ToArgb();
                int rtime = 10 * (60000);//10 minutes in miliseconds

                DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..PREFERENCES (IDUSER,REFRESHTIME,COLOR) " +
                                               " values (" + UID + "," + rtime + "," + color + ")";
                DA.InsertCommand.Connection.Open();
                DA.InsertCommand.ExecuteNonQuery();
                DA.InsertCommand.Connection.Close();

                this.RefreshTime = rtime;
                this.NoteColor = color;
            }
            else
            {
                this.RefreshTime = (int)DS.Tables["t"].Rows[0]["REFRESHTIME"];
                this.NoteColor = (int)DS.Tables["t"].Rows[0]["COLOR"];
            }
        }

        public void SaveRefreshTime(string UID, int rtime)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..PREFERENCES set REFRESHTIME  = " + rtime +
                                " where IDUSER = " + UID;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();

            this.RefreshTime = rtime;
        }
        public void SaveNoteColor(string UID, int color)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..PREFERENCES set COLOR  = " + color +
                                " where IDUSER = " + UID;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();

            this.RefreshTime = color;
        }

    }
}
