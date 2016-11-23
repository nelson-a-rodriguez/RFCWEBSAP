using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroOferta
    {
        public int excode {get;set;}
        public string exdetail { get; set; }

        public string statusOferta { get; set; }
        
        public RegistroOferta()
        {
            excode = 0;
            exdetail = "";
        }
    }
}
