using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SummonManager
{
    public class SummonVOForReport
    {
        public string IDS;
        public string WPNAME;
        public int IDPACKING;
        public int IDCUSTOMERDEPT;

        public string TECHREQPATH;
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
        //fields for report
        
        public string CUSTOMERNAME;
        public string CUSTOMERCONTACT;
        public string CUSTOMERADDRESS;
        public string DEPTNAME;
        public string DEPTCONTACTEXE;
        public string DEPTCONTACTLOG;

        public string STATUSNAME;
        public string SISPNAME;
        public int IDACCEPT;
        public int IDWPNAME;
        public string PASSDATETEXT;
        public string PACKINGNAME;
        public string EXTCABLENAMES;
        public string MOUNTINGKITNAME;


        public SummonVOForReport(SummonVO VO)
        {

            VO.FillReportFields();

            this.IDS = VO.IDS;
            //this.ACCEPTANCE = VO.ACCEPTANCE;
            this.CONTRACT = VO.CONTRACT;
            this.CREATED = VO.CREATED;
            this.CUSTOMERCONTACT = VO.CUSTOMERCONTACT;
            this.CUSTOMERNAME = VO.CUSTOMERNAME;
            this.CUSTOMERADDRESS = VO.CUSTOMERADDRESS;
            this.IDCUSTOMERDEPT = VO.IDCUSTOMERDEPT;
            //this.CUSTOMERCONTACTEXE = VO.CUSTOMERCONTACTEXE;
            //this.CUSTOMERCONTACTLOG = VO.CUSTOMERCONTACTLOG;
            this.DEPTCONTACTEXE = VO.DEPTCONTACTEXE;
            this.DEPTCONTACTLOG = VO.DEPTCONTACTLOG;
            this.DEPTNAME = VO.DEPTNAME;
            this.DELIVERY = VO.DELIVERY;
            this.IDACCEPT = VO.IDACCEPT;
            //this.IDCURSTATUS = VO.IDCURSTATUS;
            this.IDCUSTOMER = VO.IDCUSTOMER;
            this.PAYSTATUS = VO.PAYSTATUS;
            this.IDSTATUS = VO.IDSTATUS;
            this.IDWPNAME = VO.IDWPNAME;
            this.NOTE = VO.NOTE;
            this.NOTEPDB = VO.NOTEPDB;
            this.PASSDATETEXT = VO.PASSDATETEXT;
            this.PTIME = VO.PTIME;
            this.QUANTITY = VO.QUANTITY;
            this.SHIPPING = VO.SHIPPING;
            this.SISP = VO.SISP;
            this.SISPNAME = VO.SISPNAME;
            this.STATUSNAME = VO.STATUSNAME;
            this.TECHREQPATH = "NotImplemented";//VO.TECHREQPATH;
            this.WPNAME = VO.ProductVO.GetName();
            this.PACKINGNAME = VO.PACKINGNAME;
            this.EXTCABLENAMES = VO.EXTCABLENAMES;
            this.MOUNTINGKITNAME = VO.MOUNTINGKITNAME;


        }
    }
}
