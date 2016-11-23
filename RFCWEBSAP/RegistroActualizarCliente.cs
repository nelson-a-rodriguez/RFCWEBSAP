using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroActualizarCliente
    {
        public string PI_CUSTOMERNO { get; set; }
        public string PI_SALESORG { get; set; }
        public string PI_DISTR_CHAN { get; set; }
        public string PI_DIVISION { get; set; }
        public string PI_STCD1 { get; set; }
        //Z_CLIENTE
        public string ZCLIENTE_NAME_FIRST { get; set; }
        public string ZCLIENTE_NAME_LAST { get; set; }
        public string ZCLIENTE_STREET { get; set; }
        public string ZCLIENTE_POST_CODE1 { get; set; }
        public string ZCLIENTE_REGION { get; set; }
        public string ZCLIENTE_CITY1 { get; set; }
        //public string ZCLIENTE_NAME_CO { get; set; }
        public string ZCLIENTE_COUNTRY { get; set; }
        //public string ZCLIENTE_TRANSPZONE { get; set; }
        public string ZCLIENTE_REMARK { get; set; }
        public string ZCLIENTE_TEL_NUMBER { get; set; }
        public string ZCLIENTE_MOB_NUMBER { get; set; }
        public string ZCLIENTE_CORREO { get; set; }        
        //Z_DIRECC
        public string Z_DIRECC_KUNNR { get; set; }
        public string Z_DIRECC_STCD1 { get; set; }
        public string Z_DIRECC_NAME_FIRST { get; set; }
        public string Z_DIRECC_NAME_LAST { get; set; }
        public string Z_DIRECC_STREET { get; set; }
        public string Z_DIRECC_POST_CODE1 { get; set; }
        public string Z_DIRECC_REGION { get; set; }
        public string Z_DIRECC_CITY1 { get; set; }
        //public string Z_DIRECC_NAME_CO { get; set; }
        public string Z_DIRECC_COUNTRY { get; set; }
        //public string Z_DIRECC_TRANSPZONE { get; set; }
        public string Z_DIRECC_REMARK { get; set; }
        public string Z_DIRECC_TEL_NUMBER { get; set; }
        public string Z_DIRECC_MOB_NUMBER { get; set; }
        public string Z_DIRECC_CORREO { get; set; }
        public string Z_DIRECC_ACCION { get; set; }
    }
}
