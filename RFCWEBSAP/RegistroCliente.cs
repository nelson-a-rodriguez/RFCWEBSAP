using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroCliente
    {
        //ZCLIENTE
        public string STCD1 { get; set; } //public string STCD1 { get; set; } //public string PI_STCD1 { get; set; }       
        public int FAMST { get; set; }
        public int TITLE_P { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public int PARGE { get; set; }
        public string STREET { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public string REGION { get; set; }
        public string KTOKD { get; set; }
        //Z_AREA_VTAS
        public string VKORG { get; set; } //public string PI_SALESORG { get; set; }
        public string VTWEG { get; set; } //public string PI_DISTR_CHAN { get; set; }
        public string SPART { get; set; } //public string PI_DIVISION { get; set; }
         
        public string GBDAT { get; set; }
        public string KUNNR { get; set; }

        public string TITLE_MEDI { get; set; }
        public string TITLE_ACA1 { get; set; }
        public string TEL_NUMBER { get; set; }
        public string MOB_NUMBER { get; set; }
        public string SMTP_ADDR { get; set; }

        public string NAME_FIRST { get; set; }
        public string NAMEMIDDLE { get; set; }
        public string NAME_LAST2 { get; set; }
        public string NAME_LAST { get; set; }
        public string NAME2_P { get; set; }
        public string NAMCOUNTRY { get; set; }
        public string STR_SUPPL1 { get; set; }
        public string STR_SUPPL2 { get; set; }
        public string STR_SUPPL3 { get; set; }
        public string LOCATION { get; set; }
        public string CITY2 { get; set; }
        public string HOME_CITY { get; set; }
        public string POST_CODE1 { get; set; }
        public string CITY1 { get; set; }
        public string REMARK { get; set; }

    }
}
