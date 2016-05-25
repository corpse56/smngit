using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SummonManager
{
    public class DBCustomer :DB
    {
        public DBCustomer() { }
        public DataTable GetAllCustomers()
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select ID,CNAME,CONTACT,ADDRESS from " + Base.BaseName + "..CUSTOMERS order by CNAME";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void AddCustomer(string name, string dir,string address)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..CUSTOMERS (CNAME,CONTACT,ADDRESS) values ('"
                + name + "','" + dir + "','" + address + "')";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal void EditCustomer(string name, string address, string id,string dir)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..CUSTOMERS set CNAME  = '" + name + "', CONTACT = '" + dir + "', ADDRESS = '" + address +"'"+
                                            " where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal DataTable GetCustomerByID(string id)
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select ID,CNAME,CONTACT,ADDRESS from " + Base.BaseName + "..CUSTOMERS where ID = " + id;
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal string GetContactByID(string id)
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select CONTACT from " + Base.BaseName + "..CUSTOMERS where ID = " + id;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["CONTACT"].ToString();
        }




        internal object GetDeptsByIDCustomer(string idc)
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select ID,DEPTNAME,CONTACTEXE,CONTACTFINLOG from "
                                            + Base.BaseName + "..CUSTOMERDEPTLIST where IDCUSTOMER = " + idc;
            DA.Fill(DS, "t");
            return DS.Tables["t"];

        }

        internal void AddDeptToCustomer(string idc,string dept, string exe, string finlog)
        {
            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + 
                "..CUSTOMERDEPTLIST (IDCUSTOMER,DEPTNAME,CONTACTEXE,CONTACTFINLOG) values "+
                "("+idc+",'" + dept + "','" + exe + "','" + finlog + "')";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }

        internal DataTable GetDeptByID(string IDD)
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..CUSTOMERDEPTLIST where ID = " + IDD;
            DA.Fill(DS, "t");
            return DS.Tables["t"];

        }

        internal void EditDept(string IDD, string dept, string exe, string finlog)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..CUSTOMERDEPTLIST set DEPTNAME  = '" + dept +
                "', CONTACTEXE = '" + exe + "', CONTACTFINLOG = '" + finlog + "'" + " where ID = " + IDD;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal string GetDeptNameByID(string IDD)
        {
            DS = new DataSet();
            DA.SelectCommand.CommandText = "select DEPTNAME from " + Base.BaseName + "..CUSTOMERDEPTLIST where ID = " + IDD;
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["DEPTNAME"].ToString();
        }
    }
}
