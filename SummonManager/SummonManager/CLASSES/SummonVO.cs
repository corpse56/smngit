using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SummonManager.CLASSES;

namespace SummonManager
{
    public class SummonVO
    {
        public string ID;
        public string IDS;
        //public string WPNAME;
        public int QUANTITY;
        public DateTime PTIME;
        //public string ACCEPTANCE;
        public string IDCUSTOMER;
        public string CONTRACT;
        public string PAYSTATUS;
        public string SHIPPING;
        public string DELIVERY;
        public bool SISP;
        public string NOTE;
        public string NOTEPDB;
        public int IDSTATUS;
        //public int IDCURSTATUS;
        public DateTime CREATED;
        public int IDPACKING;
        public int IDCUSTOMERDEPT;
        //fields for report
        public string CUSTOMERNAME;
        public string CUSTOMERCONTACT;
        public string CUSTOMERADDRESS;
        public string DEPTCONTACTEXE;
        public string DEPTCONTACTLOG;
        public string STATUSNAME;
        public string SISPNAME;
        public int IDACCEPT;
        //public DateTime? PASSDATE;
        public string PASSDATETEXT;
        public string PACKINGNAME;
        public string EXTCABLENAMES;
        public string MOUNTINGKITNAME;
        public string DEPTNAME;
        public bool VIEWED;

        public int IDWPNAME;
        public string WPTYPE;
        public WPTYPE WPTYPEENUM;
        public IProduct ProductVO;
        public int IDSUBST;
        public bool BILLPAYED;
        public bool DOCSREADY;
        public string SUBSTATUSNAME;

        public string CONTRACTTYPE;
        public string PLANKA;
        public string SERIAL;
        public bool PLANKAREQ;
        public bool SERIALREQ;

        public string BILLNUMBER;

        public string PASSPORT;
        public string MANUAL;
        public string PACKINGLIST;
        public bool PASSPORTREQ;
        public bool MANUALREQ;
        public bool PACKINGLISTREQ;

        //public string LENGTH;
        //public string WIDTH;
        //public string HEIGHT;
        //public string WEIGHT;

        public SummonVO()
        {

        }
        public static SummonVO SummonVOByIDS(string ids)
        {
            return new DBSummon().GetSummonByIDS(ids);
        }

        internal static SummonVO SummonVOByID(string id)
        {
            return new DBSummon().GetSummonByID(id);
        }

        internal static SummonVO SummonVOByID(int id)
        {
            return new DBSummon().GetSummonByID(id);
        }

        public SummonVO FillReportFields()
        {
            DBSummon dbs = new DBSummon();
            this.CUSTOMERNAME = dbs.GetCustomerName(this.IDCUSTOMER);
            this.CUSTOMERCONTACT = dbs.GetCustomerContact(this.IDCUSTOMER);
            this.CUSTOMERADDRESS = dbs.GetCustomerAddress(this.IDCUSTOMER);
            this.DEPTNAME = dbs.GetCustomerDeptName(this.IDCUSTOMERDEPT,this.IDCUSTOMER);
            this.DEPTCONTACTEXE = dbs.GetDeptContactExe(this.IDCUSTOMERDEPT, this.IDCUSTOMER);
            this.DEPTCONTACTLOG = dbs.GetDeptContactLog(this.IDCUSTOMERDEPT, this.IDCUSTOMER);
            this.STATUSNAME = dbs.GetStatusName(this.IDSTATUS);
            if (SISP)
                this.SISPNAME = "ДА";
            else
                this.SISPNAME = "НЕТ";
            this.PACKINGNAME = new DBPacking().Get(this.IDPACKING.ToString());
            //this.EXTCABLENAMES = new DBEXTCABLE().GetEXTCABLEsForPackReport(this.ID.ToString());
            this.MOUNTINGKITNAME = "Удалено";//new DBMountingKit().GetMOUNTINGKIT(this.IDMOUNTINGKIT.ToString());
            return this;
        }



    }
}
