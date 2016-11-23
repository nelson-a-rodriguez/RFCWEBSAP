using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroCrearOferta
    {
        //datos de control
        public string DIRECT { set; get; }
        public string IDOCTYP { set; get; }
        public string MANDT { set; get; }
        public string MESTYP { set; get; }
        public string RCVPOR { set; get; }
        public string RCVPRN { set; get; }
        public string RCVPRT { set; get; }
        public string SNDPOR { set; get; }
        public string SNDPRN { set; get; }
        public string SNDPRT { set; get; }
        //ZSD_OFERTA1
        public string ZSD_OFERTA1_AUART { get; set; }
        public string ZSD_OFERTA1_VKORG { get; set; }
        public string ZSD_OFERTA1_VTWEG { get; set; }
        public string ZSD_OFERTA1_SPART { get; set; }
        public string ZSD_OFERTA1_KUNNR{ get; set; }
        public string ZSD_OFERTA1_KUNNR2 { get; set; }
        public string ZSD_OFERTA1_BSTKD { get; set; }
        public string ZSD_OFERTA1_BSTDK { get; set; }
        public string ZSD_OFERTA1_ANGDT { get; set; }
        public string ZSD_OFERTA1_BNDDT { get; set; }
        public string ZSD_OFERTA1_BNDDT2 { get; set; }
        public string ZSD_OFERTA1_TDLINE { get; set; }
        public string ZSD_OFERTA1_XFELD{ get; set; }
        public string ZSD_OFERTA1_WERKS_D { get; set; }
        //ZSD_OFERTA2
        public List<RegistroPosicionCrearOferta> POSICIONES_OFERTA { set; get; }  












        //ZAREA_VTAS
        public string ZAREA_VTAS_SALESORG { get; set; }
        public string ZAREA_VTAS_DISTR_CHAN { get; set; }
        public string ZAREA_VTAS_DIVISION { get; set; }
        public string ZAREA_VTAS_STCD1 { get; set; }

        //public string ZCLIENTE_POST_CODE1 { get; set; }
        //public string ZCLIENTE_NAME_CO { get; set; }
        //public string ZCLIENTE_COUNTRY { get; set; }
        //public string ZCLIENTE_TRANSPZONE { get; set; }
        //public string ZCLIENTE_TEL_NUMBER { get; set; }
        //public string ZCLIENTE_MOB_NUMBER { get; set; }
        //public string ZCLIENTE_CORREO { get; set; }
    }
}
