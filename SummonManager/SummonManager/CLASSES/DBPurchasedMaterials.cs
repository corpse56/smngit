using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SummonManager
{
    class DBPURCHASEDMATERIALS :DB
    {
        public DBPURCHASEDMATERIALS() { }
        public DataTable GetAll()
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PURCHASEDMATERIALS";
            DS = new DataSet();
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public void Save(PurchMaterials pm,string ids)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PURCHASEDMATERIALS where IDS = "+ids;
            DS = new DataSet();

            if (DA.Fill(DS, "t") > 0)
            {
                DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..PURCHASEDMATERIALS" +
                    " set SHILDORDERED = " + ((pm.SHILDORDERED == true) ? "1 " : "0 ") +
                    " , HARDWAREFORORDER = " + ((pm.HARDWAREFORORDER == true) ? "1 " : "0 ") +
                    " , HARDWAREINSTOCK = " + ((pm.HARDWAREINSTOCK == true) ? "1 " : "0 ") +
                    " , HARWAREFOREIGNFORORDER = " + ((pm.HARWAREFOREIGNFORORDER == true) ? "1 " : "0 ") +
                    " , HARWAREFOREIGNINSTOCK = " + ((pm.HARWAREFOREIGNINSTOCK == true) ? "1 " : "0 ") +
                    " , CONNECTORSFORORDER = " + ((pm.CONNECTORSFORORDER == true) ? "1 " : "0 ") +
                    " , CONNECTORSINSTOCK = " + ((pm.CONNECTORSINSTOCK == true) ? "1 " : "0 ") +
                    " , MATERIALSANDFASTENERSFORORDER = " + ((pm.MATERIALSANDFASTENERSFORORDER == true) ? "1 " : "0 ") +
                    " , MATERIALSANDFASTENERSINSTOCK = " + ((pm.MATERIALSANDFASTENERSINSTOCK == true) ? "1 " : "0 ") +
                    " , SHILDSFORORDER = " + ((pm.SHILDSFORORDER == true) ? "1 " : "0 ") +
                    " , SHILDSINSTOCK = " + ((pm.SHILDSINSTOCK == true) ? "1 " : "0 ") +
                    " , PACKINGFORORDER = " + ((pm.PACKINGFORORDER == true) ? "1 " : "0 ") +
                    " , PACKINGINSTOCK = " + ((pm.PACKINGINSTOCK == true) ? "1 " : "0 ") +
                                               " where IDS = " + ids;
                DA.UpdateCommand.Connection.Open();
                DA.UpdateCommand.ExecuteNonQuery();
                DA.UpdateCommand.Connection.Close();
            }
            else
            {

                DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..PURCHASEDMATERIALS (IDS,SHILDORDERED, HARDWAREFORORDER, "+
                    " HARDWAREINSTOCK,HARWAREFOREIGNFORORDER,HARWAREFOREIGNINSTOCK,CONNECTORSFORORDER,CONNECTORSINSTOCK, "+
                    " MATERIALSANDFASTENERSFORORDER,MATERIALSANDFASTENERSINSTOCK,SHILDSFORORDER,SHILDSINSTOCK, "+
                    " PACKINGFORORDER,PACKINGINSTOCK) values (" +ids+", "
                                                                + ((pm.SHILDORDERED == true) ? "1 " : "0 ") + "," 
                                                                + ((pm.HARDWAREFORORDER == true) ? "1 " : "0 ") + ","
                                                                + ((pm.HARDWAREINSTOCK == true) ? "1 " : "0 ") +
                                                            "," + ((pm.HARWAREFOREIGNFORORDER == true) ? "1 " : "0 ") +
                                                            "," + ((pm.HARWAREFOREIGNINSTOCK == true) ? "1 " : "0 ") +
                                                            "," + ((pm.CONNECTORSFORORDER == true) ? "1 " : "0 ") +
                                                            "," + ((pm.CONNECTORSINSTOCK == true) ? "1 " : "0 ") +
                                                            "," + ((pm.MATERIALSANDFASTENERSFORORDER == true) ? "1 " : "0 ") +
                                                            "," + ((pm.MATERIALSANDFASTENERSINSTOCK == true) ? "1 " : "0 ") +
                                                            "," + ((pm.SHILDSFORORDER == true) ? "1 " : "0 ") +
                                                            "," + ((pm.SHILDSINSTOCK == true) ? "1 " : "0 ") +
                                                            "," + ((pm.PACKINGFORORDER == true) ? "1 " : "0 ") +
                                                            "," + ((pm.PACKINGINSTOCK == true) ? "1 " : "0 ") + " )";
                DA.InsertCommand.Connection.Open();
                DA.InsertCommand.ExecuteNonQuery();
                DA.InsertCommand.Connection.Close();
            }
        }
        internal PurchMaterials Get(string ids)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..PURCHASEDMATERIALS where IDS = " + ids;
            DS = new DataSet();
            if (DA.Fill(DS, "t") == 0)
            {
                return new PurchMaterials();
            }
            PurchMaterials pm = new PurchMaterials();
            pm.SHILDORDERED = (bool)DS.Tables["t"].Rows[0]["SHILDORDERED"];
            pm.HARDWAREFORORDER = (bool)DS.Tables["t"].Rows[0]["HARDWAREFORORDER"];
            pm.HARDWAREINSTOCK = (bool)DS.Tables["t"].Rows[0]["HARDWAREINSTOCK"];
            pm.HARWAREFOREIGNFORORDER = (bool)DS.Tables["t"].Rows[0]["HARWAREFOREIGNFORORDER"];
            pm.HARWAREFOREIGNINSTOCK = (bool)DS.Tables["t"].Rows[0]["HARWAREFOREIGNINSTOCK"];
            pm.CONNECTORSFORORDER = (bool)DS.Tables["t"].Rows[0]["CONNECTORSFORORDER"];
            pm.CONNECTORSINSTOCK = (bool)DS.Tables["t"].Rows[0]["CONNECTORSINSTOCK"];
            pm.MATERIALSANDFASTENERSFORORDER = (bool)DS.Tables["t"].Rows[0]["MATERIALSANDFASTENERSFORORDER"];
            pm.MATERIALSANDFASTENERSINSTOCK = (bool)DS.Tables["t"].Rows[0]["MATERIALSANDFASTENERSINSTOCK"];
            pm.SHILDSFORORDER = (bool)DS.Tables["t"].Rows[0]["SHILDSFORORDER"];
            pm.SHILDSINSTOCK = (bool)DS.Tables["t"].Rows[0]["SHILDSINSTOCK"];
            pm.PACKINGFORORDER = (bool)DS.Tables["t"].Rows[0]["PACKINGFORORDER"];
            pm.PACKINGINSTOCK = (bool)DS.Tables["t"].Rows[0]["PACKINGINSTOCK"];

            return pm;
        }
        internal void Edit(string p, string id)
        {
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..CABLELIST set CNAME  = '" + p + "'" +
                                            " where ID = " + id;
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    }
    struct PurchMaterials
    {
        public bool SHILDORDERED;
        public bool HARDWAREFORORDER;
        public bool HARDWAREINSTOCK;
        public bool HARWAREFOREIGNFORORDER;
        public bool HARWAREFOREIGNINSTOCK;
        public bool CONNECTORSFORORDER;
        public bool CONNECTORSINSTOCK;
        public bool MATERIALSANDFASTENERSFORORDER;
        public bool MATERIALSANDFASTENERSINSTOCK;
        public bool SHILDSFORORDER;
        public bool SHILDSINSTOCK;
        public bool PACKINGFORORDER;
        public bool PACKINGINSTOCK;

    }
}
