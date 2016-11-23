using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroCrearCliente
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
        //ZCLIENTE
        public string ZCLIENTE_STCD1 { get; set; }
        public string ZCLIENTE_FIRSTNAME { get; set; }
        public string ZCLIENTE_LASTNAME { get; set; }
        public string ZCLIENTE_STREET { get; set; }
        public string ZCLIENTE_PO_BOX { get; set; }
        public string ZCLIENTE_REGION { get; set; }
        public string ZCLIENTE_CITY { get; set; }
        public string ZCLIENTE_COUNTRY { get; set; }
        public string ZCLIENTE_REMARK { get; set; }
        public string ZCLIENTE_TEL_NUMBER { get; set; }
        public string ZCLIENTE_MOB_NUMBER { get; set; }
        public string ZCLIENTE_CORREO { get; set; }
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
