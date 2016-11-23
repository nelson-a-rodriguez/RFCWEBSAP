using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroFactura
    {
        public int excode { get; set; }
        public string exdetail { get; set; }

        public string FACTURA { get; set; }
        public string VKORG { get; set; }
        public string VTWEG { get; set; }
        public string RIF { get; set; }
        public string NBE_AUTOMER { get; set; }
        public string DIRECCION { get; set; }
        public string TLF_AUTOMER { get; set; }
        public string TIENDA { get; set; }
        public string DIREC_TIENDA { get; set; }
        public string TLF_TIENDA { get; set; }
        public string WERKS { get; set; }
        public string NBE_CLIENTE { get; set; }
        public string DIREC_CLIENTE { get; set; }
        public string RIF_CLIENTE { get; set; }
        public string TLF_CLIENTE { get; set; }
        public string FECHA { get; set; }
        public string MONEDA { get; set; }
        public string SUB_TOTAL { get; set; }
        public string EXENTO { get; set; }
        public string IVA_8 { get; set; }
        public string IVA_12 { get; set; }
        public string TOTAL { get; set; }
        public string COD_TRANSP { get; set; }
        public string NBE_TRANSP { get; set; }
        public List<PosicionesFactura> POSICIONES_FACTURA { get; set; }

        public RegistroFactura()
        {
            excode = 0;
            exdetail = "";
        }

    }
}
