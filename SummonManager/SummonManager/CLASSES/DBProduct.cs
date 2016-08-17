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
    }
}
