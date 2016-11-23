using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RespuestaInsUpdDelDireccion
    {
        public int excode { get; set; }
        public string exdetail { get; set; }

        public string idClienteSapPrincipal { get; set; }
        public string idClienteSapAlterno { get; set; }
    }
}
