using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    class DBUser : DB
    {
        public DBUser() { }

        public IRole Login(string login,string pass)
        {
            DA.SelectCommand.Parameters.Clear();
            DA.SelectCommand.Parameters.AddWithValue("login", login);
            DA.SelectCommand.Parameters.AddWithValue("pass", pass);
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..USERS where [LOGIN] = @login and [PASS] = @pass";
            if (DA.Fill(DS, "t") == 0)
                return null;

            int i = int.Parse(DS.Tables["t"].Rows[0]["ROLE"].ToString());
            IRole UVO;
            UVO = UserFactory.CreateUser((Roles)i);
            
            
            //UVO.Role = (Roles)i;
            UVO.id = DS.Tables["t"].Rows[0]["ID"].ToString();
            UVO.Fio = DS.Tables["t"].Rows[0]["FIO"].ToString();
            UVO.Login = DS.Tables["t"].Rows[0]["LOGIN"].ToString();
            UVO.Pass = DS.Tables["t"].Rows[0]["PASS"].ToString();
            DA.SelectCommand.Parameters.Clear();
            return UVO;
        }
        public DataTable GetAllUsers()
        {
            DA.SelectCommand.CommandText = "select USERS.ID,FIO,LOGIN,PASS,ROLENAME from " + Base.BaseName + "..USERS left join " + Base.BaseName + "..ROLES on ROLES.ID = ROLE";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal object GetAllRoles()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..ROLES";
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void AddNewUser(string fio, string login, string pass, int role)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..USERS (FIO,LOGIN,PASS,ROLE) values ('"
                + fio + "','" + login + "','"+pass+"',"+role.ToString()+")";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal int GetRoleID(string idu)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..USERS where ID = " + idu.ToString();
            DA.Fill(DS, "t");
            return (int)DS.Tables["t"].Rows[0]["ID"];
        }

        internal DataTable GetUser(string idu)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..USERS where ID = " + idu.ToString();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void EditUser(string fio, string login, string pass, string role, string id)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..USERS set FIO  = '" + fio + "', LOGIN = '" + login + "'" + ", PASS = '" + pass + "', ROLE = " + role + 
                                            " where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    }
}
