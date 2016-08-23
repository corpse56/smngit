using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SummonManager.CLASSES;

namespace SummonManager
{
    class DBProduct :DB
    {
        public DBProduct() { }

        
        internal int AddNewProduct(IProduct p)
        {
            DA.InsertCommand.Parameters.Clear();
            DA.InsertCommand.Parameters.AddWithValue("PRODUCTTYPE", p.GetProductType().ToString());

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..PRODUCTS "+
                                           " (PRODUCTTYPE) " +
                                           " values (@PRODUCTTYPE);SELECT SCOPE_IDENTITY()";
            DA.InsertCommand.Connection.Open();
            object ID = DA.InsertCommand.ExecuteScalar();
            DA.InsertCommand.Connection.Close();
            return Convert.ToInt32(ID);
        }

        internal void DeleteByID(string p)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..PRODUCTS where ID = " + p;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }

        internal string GetProductName(string IDPRODUCT)
        {
            StringBuilder ct = new StringBuilder();
            ct.AppendFormat(" select ISNULL(B.WPNAME,ISNULL(C.CABLENAME,ISNULL(D.ZHGUTNAME,'<нет имени. это странно>'))) pname from {0}..PRODUCTS A", Base.BaseName);
            ct.AppendFormat(" left join WPNAMELIST B on A.ID = B.ID");
            ct.AppendFormat(" left join CABLELIST C on A.ID = C.ID");
            ct.AppendFormat(" left join ZHGUTLIST D on A.ID = D.ID");
            ct.AppendFormat(" where A.ID = {0}", IDPRODUCT);
            //ct.AppendFormat();
            //ct.AppendFormat();
            DA.SelectCommand.CommandText = ct.ToString();//"select * from " + Base.BaseName + "..SUMMON where IDWP = " + IDPRODUCT;
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["pname"].ToString();
        }
    }
}
