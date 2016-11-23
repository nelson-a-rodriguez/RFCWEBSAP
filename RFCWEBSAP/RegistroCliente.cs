using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroCliente
    {
        public int excode {get;set;}
        public string exdetail { get; set; }

        public string CUSTOMERNO { get; set; }

        public RegistroCliente()
        {
            excode = 0;
            exdetail = "";
        }

        //public string PI_CUSTOMERNO { get; set; }
        //public string PI_SALESORG { get; set; }
        //public string PI_DISTR_CHAN { get; set; }
        //public string PI_DIVISION { get; set; }
        //public ZCLIENTE Cliente { get; set; }
        //public List<Z_DIRECC> Direcciones { get; set; }

        ////ESTRUCTURA ZCLIENTE
        //public class ZCLIENTE
        //{
        //    public string ZCLIENTE_NAME_FIRST { get; set; }
        //    public string ZCLIENTE_NAME_LAST { get; set; }
        //    public string ZCLIENTE_STREET { get; set; }
        //    public string ZCLIENTE_POST_CODE1 { get; set; }
        //    public string ZCLIENTE_REGION { get; set; }
        //    public string ZCLIENTE_CITY1 { get; set; }
        //    public string ZCLIENTE_NAME_CO { get; set; }
        //    public string ZCLIENTE_COUNTRY { get; set; }
        //    public string ZCLIENTE_TRANSPZONE { get; set; }
        //    public string ZCLIENTE_REMARK { get; set; }
        //    public string ZCLIENTE_TEL_NUMBER { get; set; }
        //    public string ZCLIENTE_MOB_NUMBER { get; set; }
        //    public string ZCLIENTE_CORREO { get; set; }
        //}

        ////TABLA Z_DIRECC
        //public class Z_DIRECC
        //{
        //    public int fila { get; set; }
        //    public string Z_DIRECC_KUNNR { get; set; }
        //    public string Z_DIRECC_STCD1 { get; set; }
        //    public string Z_DIRECC_NAME_FIRST { get; set; }
        //    public string Z_DIRECC_NAME_LAST { get; set; }
        //    public string Z_DIRECC_STREET { get; set; }
        //    public string Z_DIRECC_POST_CODE1 { get; set; }
        //    public string Z_DIRECC_REGION { get; set; }
        //    public string Z_DIRECC_CITY1 { get; set; }
        //    public string Z_DIRECC_NAME_CO { get; set; }
        //    public string Z_DIRECC_COUNTRY { get; set; }
        //    public string Z_DIRECC_TRANSPZONE { get; set; }
        //    public string Z_DIRECC_REMARK { get; set; }
        //    public string Z_DIRECC_TEL_NUMBER { get; set; }
        //    public string Z_DIRECC_MOB_NUMBER { get; set; }
        //    public string Z_DIRECC_CORREO { get; set; }
        //    public string Z_DIRECC_ACCION { get; set; }
        //}

        ////ZCLIENTE
        //public string STCD1 { get; set; } //public string STCD1 { get; set; } //public string PI_STCD1 { get; set; }       
        //public int FAMST { get; set; }
        //public int TITLE_P { get; set; }
        //public string FIRSTNAME { get; set; }
        //public string LASTNAME { get; set; }
        //public int PARGE { get; set; }
        //public string STREET { get; set; }
        //public string CITY { get; set; }
        //public string COUNTRY { get; set; }
        //public string REGION { get; set; }
        //public string KTOKD { get; set; }
        ////Z_AREA_VTAS
        //public string VKORG { get; set; } //public string PI_SALESORG { get; set; }
        //public string VTWEG { get; set; } //public string PI_DISTR_CHAN { get; set; }
        //public string SPART { get; set; } //public string PI_DIVISION { get; set; }

        //public string GBDAT { get; set; }
        //public string KUNNR { get; set; }

        //public string TITLE_MEDI { get; set; }
        //public string TITLE_ACA1 { get; set; }
        //public string TEL_NUMBER { get; set; }
        //public string MOB_NUMBER { get; set; }
        //public string SMTP_ADDR { get; set; }

        //public string NAME_FIRST { get; set; }
        //public string NAMEMIDDLE { get; set; }
        //public string NAME_LAST2 { get; set; }
        //public string NAME_LAST { get; set; }
        //public string NAME2_P { get; set; }
        //public string NAMCOUNTRY { get; set; }
        //public string STR_SUPPL1 { get; set; }
        //public string STR_SUPPL2 { get; set; }
        //public string STR_SUPPL3 { get; set; }
        //public string LOCATION { get; set; }
        //public string CITY2 { get; set; }
        //public string HOME_CITY { get; set; }
        //public string POST_CODE1 { get; set; }
        //public string CITY1 { get; set; }
        //public string REMARK { get; set; }

    }
}
