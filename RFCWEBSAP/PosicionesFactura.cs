using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class PosicionesFactura
    {
        public int fila { get; set; }
        public string FACTURA { get; set; }
        public string POSNR { get; set; }
        public string COD_ARTIC { get; set; }
        public string ARTICULO { get; set; }
        public string CANTIDAD { get; set; }
        public string UNIDAD_MEDIDA { get; set; }
        public string PRECIO { get; set; }
        public string ALICUOTA { get; set; }
        public string MONTO { get; set; }        
    }
}
