using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SummonManager.CLASSES;

namespace SummonManager
{
    class DBWPName :DB
    {
        public DBWPName() { }

        public DataTable GetAllWPNames()
        {
            DA.SelectCommand.CommandText = "select A.ID,A.WPNAME WPNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО')  SUBCATNAME,A.DECNUM,A.TECHREQ,A.COMPOSITION,A.NOTE from "
                                            + Base.BaseName + "..WPNAMELIST A left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY "+
                                           " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                           " order by WPNAME";
            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public DataTable GetCategoryWPNames(int IDCAT, int IDSUBCAT)
        {
            if (IDCAT == 2) return this.GetAllWPNames();
            string sub = new DBSubCategory().GetNameByID(IDSUBCAT);
            if (sub.ToUpper() == "ВСЕ")
            {
                DA.SelectCommand.CommandText = "select A.ID,A.WPNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.TECHREQ,A.COMPOSITION,A.NOTE from "
                                                + Base.BaseName + "..WPNAMELIST A left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " order by WPNAME";
            }
            else if (sub.ToUpper() == "НЕ ПРИСВОЕНО")
            {
                DA.SelectCommand.CommandText = "select A.ID,A.WPNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.TECHREQ,A.COMPOSITION,A.NOTE from "
                                                + Base.BaseName + "..WPNAMELIST A left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " and ((A.IDSUBCAT is null) or (C.SUBCATNAME = 'НЕ ПРИСВОЕНО'))  order by WPNAME";
            }
            else
            {
                DA.SelectCommand.CommandText = "select A.ID,A.WPNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.TECHREQ,A.COMPOSITION,A.NOTE from "
                                                + Base.BaseName + "..WPNAMELIST A left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                               " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                               " where A.IDCATEGORY = " + IDCAT + " and (A.IDSUBCAT = " + IDSUBCAT + ")  order by WPNAME";
            }

            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }
        public DataTable GetCategoryWPNames(int IDCAT)
        {
            if (IDCAT == 2) return this.GetAllWPNames();
            DA.SelectCommand.CommandText = "select A.ID,A.WPNAME,B.CATEGORYNAME,isnull(C.SUBCATNAME,'НЕ ПРИСВОЕНО') SUBCATNAME,A.DECNUM,A.TECHREQ,A.COMPOSITION,A.NOTE from "
                                            + Base.BaseName + "..WPNAMELIST A left join " + Base.BaseName + "..CATEGORYLIST B on B.ID = IDCATEGORY " +
                                           " left join " + Base.BaseName + "..SUBCATEGORYLIST C on C.ID = A.IDSUBCAT " +
                                           " where A.IDCATEGORY = " + IDCAT + " order by WPNAME";
            DS = new DataSet();
            int h = DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal void AddNewWP(WPNameVO p)
        {
            int ID = new DBProduct().AddNewProduct(p);

            DA.InsertCommand.Parameters.Clear();
            DA.InsertCommand.Parameters.AddWithValue("ID", ID);
            DA.InsertCommand.Parameters.AddWithValue("WPNAME", p.WPName);
            DA.InsertCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.InsertCommand.Parameters.AddWithValue("IDSUBCAT", (p.IDSubCat == 0) ? 2 : p.IDSubCat);
            DA.InsertCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.InsertCommand.Parameters.AddWithValue("WIRINGDIAGRAM", ((object)p.WIRINGDIAGRAM) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("TECHREQ", ((object)p.TECHREQ) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("COMPOSITION", ((object)p.COMPOSITION) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("CONFIGURATION", ((object)p.CONFIGURATION) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("DIMENSIONALDRAWING", ((object)p.DIMENDRAWING) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("SBORKA3D", ((object)p.SBORKA3D) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("MECHPARTS", ((object)p.MECHPARTS) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("SHILDS", ((object)p.SHILDS) ?? DBNull.Value);
            //DA.InsertCommand.Parameters.AddWithValue("PLANKA", ((object)p.PLANKA) ?? DBNull.Value);
            //DA.InsertCommand.Parameters.AddWithValue("SERIAL", ((object)p.SERIAL) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("PACKAGING", ((object)p.PACKAGING) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("MANUAL", ((object)p.MANUAL) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("PASSPORT", ((object)p.PASSPORT) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("PACKINGLIST", ((object)p.PACKINGLIST) ?? DBNull.Value);
            DA.InsertCommand.Parameters.AddWithValue("POWERSUPPLY", p.PowerSupply);
            DA.InsertCommand.Parameters.AddWithValue("NOTE", p.Note);
            DA.InsertCommand.Parameters.AddWithValue("CREATED", DateTime.Now);
            DA.InsertCommand.Parameters.AddWithValue("COMPOSITIONREQ", p.COMPOSITIONREQ);
            DA.InsertCommand.Parameters.AddWithValue("DIMENSIONALDRAWINGREQ", p.DIMENSIONALDRAWINGREQ);
            DA.InsertCommand.Parameters.AddWithValue("CONFIGURATIONREQ", p.CONFIGURATIONREQ);
            DA.InsertCommand.Parameters.AddWithValue("WIRINGDIAGRAMREQ", p.WIRINGDIAGRAMREQ);
            DA.InsertCommand.Parameters.AddWithValue("TECHREQREQ", p.TECHREQREQ);
            DA.InsertCommand.Parameters.AddWithValue("SBORKA3DREQ", p.SBORKA3DREQ);
            DA.InsertCommand.Parameters.AddWithValue("MECHPARTSREQ", p.MECHPARTSREQ);
            DA.InsertCommand.Parameters.AddWithValue("SHILDSREQ", p.SHILDSREQ);
            //DA.InsertCommand.Parameters.AddWithValue("PLANKAREQ", p.PLANKAREQ);
            //DA.InsertCommand.Parameters.AddWithValue("SERIALREQ", p.SERIALREQ);
            DA.InsertCommand.Parameters.AddWithValue("PACKAGINGREQ", p.PACKAGINGREQ);
            DA.InsertCommand.Parameters.AddWithValue("PASSPORTREQ", p.PASSPORTREQ);
            DA.InsertCommand.Parameters.AddWithValue("MANUALREQ", p.MANUALREQ);
            DA.InsertCommand.Parameters.AddWithValue("PACKINGLISTREQ", p.PACKINGLISTREQ);
            DA.InsertCommand.Parameters.AddWithValue("SOFTWAREREQ", p.SOFTWAREREQ);
            DA.InsertCommand.Parameters.AddWithValue("CABLELISTREQ", p.CABLELISTREQ);
            DA.InsertCommand.Parameters.AddWithValue("ZHGUTLISTREQ", p.ZHGUTLISTREQ);
            DA.InsertCommand.Parameters.AddWithValue("RUNCARDLISTREQ", p.RUNCARDLISTREQ);
            DA.InsertCommand.Parameters.AddWithValue("CIRCUITBOARDLISTREQ", p.CIRCUITBOARDLISTREQ);
            DA.InsertCommand.Parameters.AddWithValue("LENGTH", p.LENGTH);
            DA.InsertCommand.Parameters.AddWithValue("WIDTH", p.WIDTH);
            DA.InsertCommand.Parameters.AddWithValue("HEIGHT", p.HEIGHT);
            DA.InsertCommand.Parameters.AddWithValue("WEIGHT", p.WEIGHT);


            //wp.ZHGUTS = new DBZhgutList().GetPackageForVO(wp.ID);
/////////////////////////////////////////////////////////////////////////////////    ЗАПРЕЩЕНО НАПОЛНЯТЬ ЖГУТЫ КОГДА СОЗДАЁШЬ ИЗДЕЛИЕ!!!!!!!!!!!!!!!!!
            //wp.CABLES = new DBCableList().GetPackageForVO(wp.ID);

            DA.InsertCommand.CommandText = "insert into " + Base.BaseName + "..WPNAMELIST "+
                                           " (ID,WPNAME,IDCATEGORY,IDSUBCAT,DECNUM,WIRINGDIAGRAM,TECHREQ,COMPOSITION,CONFIGURATION,DIMENSIONALDRAWING,SBORKA3D, " +
                                           " MECHPARTS,SHILDS,PACKAGING,MANUAL,PASSPORT,PACKINGLIST,POWERSUPPLY,NOTE,CREATED,      "+
                                           " COMPOSITIONREQ,DIMENSIONALDRAWINGREQ,CONFIGURATIONREQ,WIRINGDIAGRAMREQ," +
                                           " TECHREQREQ,SBORKA3DREQ,MECHPARTSREQ,SHILDSREQ,PACKAGINGREQ,PASSPORTREQ, "+
                                           " MANUALREQ,PACKINGLISTREQ,SOFTWAREREQ,CABLELISTREQ,ZHGUTLISTREQ,RUNCARDLISTREQ,CIRCUITBOARDLISTREQ "+
                                           " ,LENGTH,WIDTH,HEIGHT,WEIGHT) " +
                                           " values (@ID,@WPNAME,@IDCATEGORY,@IDSUBCAT,@DECNUM,@WIRINGDIAGRAM,@TECHREQ,@COMPOSITION,@CONFIGURATION,@DIMENSIONALDRAWING,@SBORKA3D, " +
                                           " @MECHPARTS,@SHILDS,@PACKAGING,@MANUAL, @PASSPORT,@PACKINGLIST,@POWERSUPPLY,@NOTE,@CREATED,      " +
                                           " @COMPOSITIONREQ,@DIMENSIONALDRAWINGREQ,@CONFIGURATIONREQ,@WIRINGDIAGRAMREQ," +
                                           " @TECHREQREQ,@SBORKA3DREQ,@MECHPARTSREQ,@SHILDSREQ,@PACKAGINGREQ,@PASSPORTREQ, " +
                                           " @MANUALREQ,@PACKINGLISTREQ,@SOFTWAREREQ,@CABLELISTREQ,@ZHGUTLISTREQ,@RUNCARDLISTREQ,@CIRCUITBOARDLISTREQ "+
                                           " ,@LENGTH,@WIDTH,@HEIGHT,@WEIGHT)";
            DA.InsertCommand.Connection.Open();
            DA.InsertCommand.ExecuteNonQuery();
            DA.InsertCommand.Connection.Close();
        }





        internal void DeleteByID(string p)
        {
            DA.DeleteCommand.CommandText = "delete from " + Base.BaseName + "..WPNAMELIST where ID = "+p;
            DA.DeleteCommand.Connection.Open();
            DA.DeleteCommand.ExecuteNonQuery();
            DA.DeleteCommand.Connection.Close();
        }

        internal bool Exists(string p)
        {
            DA.SelectCommand.CommandText = "select * from " + Base.BaseName + "..SUMMON where IDWP = " + p+ " and WPTYPE = 'WPNAMELIST'";
            int i = DA.Fill(DS, "t");
            return (i>0) ? true:false;
        }

        internal string GetCurrentComposition(string idwp)
        {
            DA.SelectCommand.CommandText = "select COMPOSITION from " + Base.BaseName + "..WPNAMELIST where ID = " + idwp;
            int i = DA.Fill(DS, "t");
            return DS.Tables["t"].Rows[0]["COMPOSITION"].ToString();
        }


        internal object GetPackage(int idwp)
        {
            DA.SelectCommand.Parameters.AddWithValue("IDWP", idwp);
            DA.SelectCommand.CommandText = " select A.ID id,A.ID nn,B.WPNAME,A.CNT " +
                                           " left join " + Base.BaseName + "..WPNAMELIST B ON B.ID = A.IDZHGUT " +
                                           " from " + Base.BaseName + "..WPNAMELIST A where IDWP = @IDWP ";
            DA.Fill(DS, "t");
            return DS.Tables["t"];
        }

        internal WPNameVO GetWPNameByID(int id)
        {
            WPNameVO wp = new WPNameVO();
            DA.SelectCommand.Parameters.AddWithValue("ID", id);
            DA.SelectCommand.CommandText = " select * from " + Base.BaseName + "..WPNAMELIST A where ID = @ID";
            DA.Fill(DS, "t");
            DataRow r = DS.Tables["t"].Rows[0];
            
            wp.WPType = WPTYPE.WPNAMELIST; 
            wp.ID = (int)r["ID"];
            wp.WPName = r["WPNAME"].ToString();
            wp.IDCat= (int)r["IDCATEGORY"];
            wp.IDSubCat = (r["IDSUBCAT"] == DBNull.Value) ? 2 : (int)r["IDSUBCAT"];
            wp.DecNum = r["DECNUM"].ToString();
            wp.WIRINGDIAGRAM = r["WIRINGDIAGRAM"].ToString();
            wp.TECHREQ = r["TECHREQ"].ToString();
            wp.COMPOSITION = r["COMPOSITION"].ToString();
            wp.CONFIGURATION = r["CONFIGURATION"].ToString();
            wp.DIMENDRAWING = r["DIMENSIONALDRAWING"].ToString();
            wp.SBORKA3D = r["SBORKA3D"].ToString();
            wp.MECHPARTS = r["MECHPARTS"].ToString();
            wp.ZHGUTS = new DBZhgutList().GetPackageForVO(wp.ID);
            wp.CABLES = new DBCableList().GetPackageForVO(wp.ID);
            wp.SHILDS = r["SHILDS"].ToString();
            //wp.PLANKA = r["PLANKA"].ToString();
            //wp.SERIAL = r["SERIAL"].ToString();
            wp.PACKAGING = r["PACKAGING"].ToString();
            wp.PASSPORT = r["PASSPORT"].ToString();
            wp.MANUAL = r["MANUAL"].ToString();
            wp.PACKINGLIST = r["PACKINGLIST"].ToString();
            wp.PowerSupply = r["POWERSUPPLY"].ToString();
            wp.Note = r["NOTE"].ToString();

            wp.COMPOSITIONREQ = (bool)r["COMPOSITIONREQ"];
            wp.DIMENSIONALDRAWINGREQ = (bool)r["DIMENSIONALDRAWINGREQ"];
            //wp.POWERSUPPLYREQ = (bool)r["POWERSUPPLYREQ"];
            wp.CONFIGURATIONREQ = (bool)r["CONFIGURATIONREQ"];
            wp.WIRINGDIAGRAMREQ = (bool)r["WIRINGDIAGRAMREQ"];
            wp.TECHREQREQ = (bool)r["TECHREQREQ"];
            wp.SBORKA3DREQ = (bool)r["SBORKA3DREQ"];
            wp.MECHPARTSREQ = (bool)r["MECHPARTSREQ"];
            wp.SHILDSREQ = (bool)r["SHILDSREQ"];
            //wp.PLANKAREQ = (bool)r["PLANKAREQ"];
            //wp.SERIALREQ = (bool)r["SERIALREQ"];
            wp.PACKAGINGREQ = (bool)r["PACKAGINGREQ"];
            wp.PASSPORTREQ = (bool)r["PASSPORTREQ"];
            wp.MANUALREQ = (bool)r["MANUALREQ"];
            wp.PACKINGLISTREQ = (bool)r["PACKINGLISTREQ"];
            wp.SOFTWAREREQ = (bool)r["SOFTWAREREQ"];
            wp.CABLELISTREQ = (bool)r["CABLELISTREQ"];
            wp.ZHGUTLISTREQ = (bool)r["ZHGUTLISTREQ"];
            wp.RUNCARDLISTREQ = (bool)r["RUNCARDLISTREQ"];
            wp.CIRCUITBOARDLISTREQ = (bool)r["CIRCUITBOARDLISTREQ"];

            wp.LENGTH = r["LENGTH"].ToString();
            wp.WIDTH = r["WIDTH"].ToString();
            wp.HEIGHT = r["HEIGHT"].ToString();
            wp.WEIGHT = r["WEIGHT"].ToString();

            return wp;
        }
        internal void EditWP(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("WPNAME", p.WPName);
            DA.UpdateCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.UpdateCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.UpdateCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.UpdateCommand.Parameters.AddWithValue("WIRINGDIAGRAM", ((object)p.WIRINGDIAGRAM) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("TECHREQ", ((object)p.TECHREQ) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("COMPOSITION", ((object)p.COMPOSITION) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("CONFIGURATION", ((object)p.CONFIGURATION) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWING", ((object)p.DIMENDRAWING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("SBORKA3D", ((object)p.SBORKA3D) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MECHPARTS", ((object)p.MECHPARTS) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("SHILDS", ((object)p.SHILDS) ?? DBNull.Value);
            //DA.UpdateCommand.Parameters.AddWithValue("PLANKA", ((object)p.PLANKA) ?? DBNull.Value);
            //DA.UpdateCommand.Parameters.AddWithValue("SERIAL", ((object)p.SERIAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKAGING", ((object)p.PACKAGING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORT", ((object)p.PASSPORT) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MANUAL", ((object)p.MANUAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLIST", ((object)p.PACKINGLIST) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("POWERSUPPLY", p.PowerSupply);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);
            DA.UpdateCommand.Parameters.AddWithValue("COMPOSITIONREQ", p.COMPOSITIONREQ);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWINGREQ", p.DIMENSIONALDRAWINGREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CONFIGURATIONREQ", p.CONFIGURATIONREQ);
            DA.UpdateCommand.Parameters.AddWithValue("WIRINGDIAGRAMREQ", p.WIRINGDIAGRAMREQ);
            DA.UpdateCommand.Parameters.AddWithValue("TECHREQREQ", p.TECHREQREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SBORKA3DREQ", p.SBORKA3DREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MECHPARTSREQ", p.MECHPARTSREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SHILDSREQ", p.SHILDSREQ);
            //DA.UpdateCommand.Parameters.AddWithValue("PLANKAREQ", p.PLANKAREQ);
            //DA.UpdateCommand.Parameters.AddWithValue("SERIALREQ", p.SERIALREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PACKAGINGREQ", p.PACKAGINGREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORTREQ", p.PASSPORTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MANUALREQ", p.MANUALREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLISTREQ", p.PACKINGLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SOFTWAREREQ", p.SOFTWAREREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CABLELISTREQ", p.CABLELISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("ZHGUTLISTREQ", p.ZHGUTLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("RUNCARDLISTREQ", p.RUNCARDLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CIRCUITBOARDLISTREQ", p.CIRCUITBOARDLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.Parameters.AddWithValue("LENGTH", p.LENGTH);
            DA.UpdateCommand.Parameters.AddWithValue("WIDTH", p.WIDTH);
            DA.UpdateCommand.Parameters.AddWithValue("HEIGHT", p.HEIGHT);
            DA.UpdateCommand.Parameters.AddWithValue("WEIGHT", p.WEIGHT);


            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set WPNAME  = @WPNAME,IDCATEGORY = @IDCATEGORY,IDSUBCAT = @IDSUBCAT,DECNUM = @DECNUM, " +
                                           " WIRINGDIAGRAM = @WIRINGDIAGRAM, TECHREQ=@TECHREQ,COMPOSITION = @COMPOSITION,CONFIGURATION=@CONFIGURATION, " +
                                           " DIMENSIONALDRAWING=@DIMENSIONALDRAWING,SBORKA3D=@SBORKA3D,MECHPARTS=@MECHPARTS,SHILDS=@SHILDS, " +
                                           " PACKAGING=@PACKAGING, PASSPORT=@PASSPORT, MANUAL=@MANUAL, PACKINGLIST=@PACKINGLIST,POWERSUPPLY=@POWERSUPPLY," +
                                           " NOTE = @NOTE,   COMPOSITIONREQ=@COMPOSITIONREQ, DIMENSIONALDRAWINGREQ=@DIMENSIONALDRAWINGREQ, CONFIGURATIONREQ=@CONFIGURATIONREQ, " +
                                           " WIRINGDIAGRAMREQ=@WIRINGDIAGRAMREQ, TECHREQREQ=@TECHREQREQ, SBORKA3DREQ=@SBORKA3DREQ, MECHPARTSREQ=@MECHPARTSREQ, " +
                                           " SHILDSREQ=@SHILDSREQ,  PACKAGINGREQ=@PACKAGINGREQ," +
                                           " PASSPORTREQ=@PASSPORTREQ, MANUALREQ=@MANUALREQ, PACKINGLISTREQ=@PACKINGLISTREQ, SOFTWAREREQ=@SOFTWAREREQ, " +
                                           " CABLELISTREQ=@CABLELISTREQ,ZHGUTLISTREQ=@ZHGUTLISTREQ, RUNCARDLISTREQ=@RUNCARDLISTREQ,CIRCUITBOARDLISTREQ=@CIRCUITBOARDLISTREQ " +
                                            " , LENGTH=@LENGTH, WIDTH=@WIDTH, HEIGHT=@HEIGHT, WEIGHT=@WEIGHT " +
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal void EditWP_Inzhener(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("WPNAME", p.WPName);
            DA.UpdateCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.UpdateCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.UpdateCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.UpdateCommand.Parameters.AddWithValue("WIRINGDIAGRAM", ((object)p.WIRINGDIAGRAM) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("TECHREQ", ((object)p.TECHREQ) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("COMPOSITION", ((object)p.COMPOSITION) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("CONFIGURATION", ((object)p.CONFIGURATION) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWING", ((object)p.DIMENDRAWING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("SBORKA3D", ((object)p.SBORKA3D) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MECHPARTS", ((object)p.MECHPARTS) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("SHILDS", ((object)p.SHILDS) ?? DBNull.Value);
            //DA.UpdateCommand.Parameters.AddWithValue("PLANKA", ((object)p.PLANKA) ?? DBNull.Value);
            //DA.UpdateCommand.Parameters.AddWithValue("SERIAL", ((object)p.SERIAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKAGING", ((object)p.PACKAGING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORT", ((object)p.PASSPORT) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MANUAL", ((object)p.MANUAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLIST", ((object)p.PACKINGLIST) ?? DBNull.Value);

            DA.UpdateCommand.Parameters.AddWithValue("POWERSUPPLY", p.PowerSupply);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);
            DA.UpdateCommand.Parameters.AddWithValue("COMPOSITIONREQ", p.COMPOSITIONREQ);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWINGREQ", p.DIMENSIONALDRAWINGREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CONFIGURATIONREQ", p.CONFIGURATIONREQ);
            DA.UpdateCommand.Parameters.AddWithValue("WIRINGDIAGRAMREQ", p.WIRINGDIAGRAMREQ);
            DA.UpdateCommand.Parameters.AddWithValue("TECHREQREQ", p.TECHREQREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SBORKA3DREQ", p.SBORKA3DREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MECHPARTSREQ", p.MECHPARTSREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SHILDSREQ", p.SHILDSREQ);
            //DA.UpdateCommand.Parameters.AddWithValue("PLANKAREQ", p.PLANKAREQ);
            //DA.UpdateCommand.Parameters.AddWithValue("SERIALREQ", p.SERIALREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PACKAGINGREQ", p.PACKAGINGREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORTREQ", p.PASSPORTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MANUALREQ", p.MANUALREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLISTREQ", p.PACKINGLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SOFTWAREREQ", p.SOFTWAREREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CABLELISTREQ", p.CABLELISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("ZHGUTLISTREQ", p.ZHGUTLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("RUNCARDLISTREQ", p.RUNCARDLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CIRCUITBOARDLISTREQ", p.CIRCUITBOARDLISTREQ);

            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);
            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set WPNAME  = @WPNAME,IDCATEGORY = @IDCATEGORY,IDSUBCAT = @IDSUBCAT,DECNUM = @DECNUM, " +
                                           " WIRINGDIAGRAM = @WIRINGDIAGRAM, TECHREQ=@TECHREQ,COMPOSITION = @COMPOSITION,CONFIGURATION=@CONFIGURATION, " +
                                           " DIMENSIONALDRAWING=@DIMENSIONALDRAWING,SBORKA3D=@SBORKA3D,MECHPARTS=@MECHPARTS,SHILDS=@SHILDS, " +
                                           " PACKAGING=@PACKAGING, PASSPORT=@PASSPORT, MANUAL=@MANUAL, PACKINGLIST=@PACKINGLIST,POWERSUPPLY=@POWERSUPPLY," +
                                           " NOTE = @NOTE,   COMPOSITIONREQ=@COMPOSITIONREQ, DIMENSIONALDRAWINGREQ=@DIMENSIONALDRAWINGREQ, CONFIGURATIONREQ=@CONFIGURATIONREQ, " +
                                           " WIRINGDIAGRAMREQ=@WIRINGDIAGRAMREQ, TECHREQREQ=@TECHREQREQ, SBORKA3DREQ=@SBORKA3DREQ, MECHPARTSREQ=@MECHPARTSREQ, " +
                                           " SHILDSREQ=@SHILDSREQ, PACKAGINGREQ=@PACKAGINGREQ," +
                                           " PASSPORTREQ=@PASSPORTREQ, MANUALREQ=@MANUALREQ, PACKINGLISTREQ=@PACKINGLISTREQ, SOFTWAREREQ=@SOFTWAREREQ, " +
                                           " CABLELISTREQ=@CABLELISTREQ,ZHGUTLISTREQ=@ZHGUTLISTREQ, RUNCARDLISTREQ=@RUNCARDLISTREQ,CIRCUITBOARDLISTREQ=@CIRCUITBOARDLISTREQ " +
                                            " where ID = @ID";

            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal void EditWP_Constructor(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("WPNAME", p.WPName);
            DA.UpdateCommand.Parameters.AddWithValue("IDCATEGORY", p.IDCat);
            DA.UpdateCommand.Parameters.AddWithValue("IDSUBCAT", p.IDSubCat);
            DA.UpdateCommand.Parameters.AddWithValue("DECNUM", p.DecNum);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWING", ((object)p.DIMENDRAWING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("DIMENSIONALDRAWINGREQ", p.DIMENSIONALDRAWINGREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SBORKA3D", ((object)p.SBORKA3D) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("SBORKA3DREQ", p.SBORKA3DREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MECHPARTS", ((object)p.MECHPARTS) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MECHPARTSREQ", p.MECHPARTSREQ);
            DA.UpdateCommand.Parameters.AddWithValue("SHILDS", ((object)p.SHILDS) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("SHILDSREQ", p.SHILDSREQ);
            //DA.UpdateCommand.Parameters.AddWithValue("PLANKA", ((object)p.PLANKA) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKAGING", ((object)p.PACKAGING) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKAGINGREQ", p.PACKAGINGREQ);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);
            DA.UpdateCommand.Parameters.AddWithValue("ZHGUTLISTREQ", p.ZHGUTLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("CABLELISTREQ", p.CABLELISTREQ);

            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set WPNAME  = @WPNAME,IDCATEGORY = @IDCATEGORY,IDSUBCAT = @IDSUBCAT,DECNUM = @DECNUM, " +
                                           " DIMENSIONALDRAWING=@DIMENSIONALDRAWING,SBORKA3D=@SBORKA3D,MECHPARTS=@MECHPARTS,SHILDS=@SHILDS,PACKAGING=@PACKAGING,NOTE=@NOTE, " +
                                           " SHILDSREQ=@SHILDSREQ, PACKAGINGREQ=@PACKAGINGREQ,DIMENSIONALDRAWINGREQ=@DIMENSIONALDRAWINGREQ,SBORKA3DREQ=@SBORKA3DREQ,MECHPARTSREQ=@MECHPARTSREQ " +
                                           " ,ZHGUTLISTREQ=@ZHGUTLISTREQ,CABLELISTREQ=@CABLELISTREQ " +
                                           " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal void EditWP_Tehnolog(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);

            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set  NOTE=@NOTE" +
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();

        }

        internal void EditWP_Shemotehnik(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("WIRINGDIAGRAM", ((object)p.WIRINGDIAGRAM) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("WIRINGDIAGRAMREQ", p.WIRINGDIAGRAMREQ);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);

            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set WIRINGDIAGRAM  = @WIRINGDIAGRAM,WIRINGDIAGRAMREQ=@WIRINGDIAGRAMREQ, NOTE=@NOTE" +
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }

        internal void EditWP_OTD(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORT", ((object)p.PASSPORT) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("MANUAL", ((object)p.MANUAL) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLIST", ((object)p.PACKINGLIST) ?? DBNull.Value);
            DA.UpdateCommand.Parameters.AddWithValue("PASSPORTREQ", p.PASSPORTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("MANUALREQ", p.MANUALREQ);
            DA.UpdateCommand.Parameters.AddWithValue("PACKINGLISTREQ", p.PACKINGLISTREQ);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);

            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set PASSPORT  = @PASSPORT,MANUAL=@MANUAL,PACKINGLIST=@PACKINGLIST,  NOTE=@NOTE" +
                                           ", PASSPORTREQ=@PASSPORTREQ,MANUALREQ=@MANUALREQ,PACKINGLISTREQ=@PACKINGLISTREQ " + 
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
        internal void EditWP_OTK(WPNameVO p)
        {
            DA.UpdateCommand.Parameters.Clear();
            DA.UpdateCommand.Parameters.AddWithValue("LENGTH", p.LENGTH);
            DA.UpdateCommand.Parameters.AddWithValue("WIDTH", p.WIDTH);
            DA.UpdateCommand.Parameters.AddWithValue("HEIGHT", p.HEIGHT);
            DA.UpdateCommand.Parameters.AddWithValue("WEIGHT", p.WEIGHT);
            DA.UpdateCommand.Parameters.AddWithValue("NOTE", p.Note);

            DA.UpdateCommand.Parameters.AddWithValue("ID", p.ID);

            DA.UpdateCommand.CommandText = "update " + Base.BaseName + "..WPNAMELIST set LENGTH=@LENGTH,WIDTH=@WIDTH,HEIGHT=@HEIGHT,WEIGHT=@WEIGHT,  NOTE=@NOTE" +
                                            " where ID = @ID";
            DA.UpdateCommand.Connection.Open();
            DA.UpdateCommand.ExecuteNonQuery();
            DA.UpdateCommand.Connection.Close();
        }
    }
}
