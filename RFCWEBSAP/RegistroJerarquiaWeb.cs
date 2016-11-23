﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFCWEBSAP
{
    public class RegistroJerarquiaWeb
    {
        public int excode { get; set; }
        public string exdetail { get; set; }

        public int fila { get; set; }
        public string PRODH { get; set; }
        public string STUFE { get; set; }
        public string VTEXT { get; set; }

        public RegistroJerarquiaWeb()
        {
            excode = 0;
            exdetail = "";
        }
    }
}
