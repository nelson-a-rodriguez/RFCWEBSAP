using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RespuestaActualizarCliente
    {
        public int excode { get; set; }
        public string exdetail { get; set; }
        public string idSapClientePrincipal { get; set; }
        public string idSapClienteAlterno { get; set; }
    }
}
