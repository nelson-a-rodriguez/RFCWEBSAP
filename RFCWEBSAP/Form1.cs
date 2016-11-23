using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace RFCWEBSAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnconsultarInventario_Click(object sender, EventArgs e)
        {
            //string EntornoSAP = System.Configuration.ConfigurationManager.AppSettings["EntornoSAP"];
            RepositorioSAP.SapParametros parametros = new RepositorioSAP.SapParametros()
            {
                Name = "DV1",
                User = "webplz",
                Password = "webplz.2015",
                Client = "300",
                Language = "S",
                AppServerHost = "172.20.3.200",
                SystemNumber = "00",
                PoolSize = "10",
                ConnectionIdleTimeout = "10"
            };
            RepositorioSAP rep = new RepositorioSAP(parametros);
            List<RegistroInventario> resultado = rep.ConsultarInventario(txtCentro.Text, txtJerarquiaWeb.Text);
            dataGridView1.DataSource = resultado;
            btnconsultarJerarquiaWeb.Visible = false;
            btnconsultarInventario.Visible = false;
            label2.Visible = false;
            txtCentro.Visible = false;
            label1.Visible = false;
            txtJerarquiaWeb.Visible = false;
        }

        private void btnconsultarJerarquiaWeb_Click(object sender, EventArgs e)
        {
            //string EntornoSAP = System.Configuration.ConfigurationManager.AppSettings["EntornoSAP"];
            RepositorioSAP.SapParametros parametros = new RepositorioSAP.SapParametros()
            {
                //Name = "DV1",
                //User = "webplz",
                //Password = "webplz.2015",
                //Client = "300",
                //Language = "S",
                //AppServerHost = "172.20.3.200",
                //SystemNumber = "00",
                //PoolSize = "10",
                //ConnectionIdleTimeout = "10"

                //Name = "DV1",
                //User = "rfgen",
                //Password = "plazas01",
                //Client = "300",
                //Language = "S",
                //AppServerHost = "172.20.3.200",
                //SystemNumber = "00",
                //PoolSize = "10",
                //ConnectionIdleTimeout = "10"

                Name = "QA1",
                User = "rfgen",
                Password = "caracas01",
                Client = "100",
                Language = "S",
                AppServerHost = "172.20.3.202",
                SystemNumber = "00",
                PoolSize = "10",
                ConnectionIdleTimeout = "10"
            };
            RepositorioSAP rep = new RepositorioSAP(parametros);
            List<RegistroJerarquiaWeb> resultado = rep.ConsultarJerarquiaWeb();
            dataGridView1.DataSource = resultado;
            btnconsultarJerarquiaWeb.Visible = false;
            btnconsultarInventario.Visible = false;
            label2.Visible = false;
            txtCentro.Visible = false;
            label1.Visible = false;
            txtJerarquiaWeb.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string EntornoSAP = System.Configuration.ConfigurationManager.AppSettings["EntornoSAP"];
            RepositorioSAP.SapParametros parametros = new RepositorioSAP.SapParametros()
            {
                Name = "DV1",
                User = "webplz",
                Password = "webplz.2015",
                Client = "300",
                Language = "S",
                AppServerHost = "172.20.3.200",
                SystemNumber = "00",
                PoolSize = "10",
                ConnectionIdleTimeout = "10"
            };
            RepositorioSAP rep = new RepositorioSAP(parametros);

            RegistroCrearOferta registrocrearoferta = new RegistroCrearOferta()
            {
                DIRECT = "2",
                IDOCTYP = "Z_OFERTA",
                MANDT = "300",
                MESTYP = "ZOFERTA",
                RCVPOR = "SAPDV1",
                RCVPRN = "SAP",
                RCVPRT = "LS",
                SNDPOR = "WEBX",
                SNDPRN = "WEBPLZ",
                SNDPRT = "LS",
                //ZCLIENTE
                ZSD_OFERTA1_AUART = "ZCE0",
                ZSD_OFERTA1_VKORG = "0100",
                ZSD_OFERTA1_VTWEG = "02",
                ZSD_OFERTA1_SPART = "01",
                ZSD_OFERTA1_KUNNR = "0000300271",
                ZSD_OFERTA1_KUNNR2 = "0000300271",
                ZSD_OFERTA1_BSTKD = "20001",
                ZSD_OFERTA1_BSTDK = "20160704",
                ZSD_OFERTA1_ANGDT = "20160707",
                ZSD_OFERTA1_BNDDT = "20160707",
                ZSD_OFERTA1_BNDDT2 = "20160707",
                ZSD_OFERTA1_TDLINE = "CUALQUIER COSA DE LA ORDEN 20000",
                ZSD_OFERTA1_XFELD = "X",
                ZSD_OFERTA1_WERKS_D = "1017",
            };
            registrocrearoferta.POSICIONES_OFERTA = new List<RegistroPosicionCrearOferta>();
            //foreach (PosicionOferta p in datosoferta.POSICIONES_OFERTA)
            //{
            RegistroPosicionCrearOferta p2 = new RegistroPosicionCrearOferta()
            {
                ZSD_OFERTA2_POSNR_VA = "000010",
                ZSD_OFERTA2_MATNR = "7702277016786",
                ZSD_OFERTA2_KWMENG = "2",
                ZSD_OFERTA2_VRKME = "PCE",//ZSD_OFERTA2_VRKME = "ST",
                ZSD_OFERTA2_WERKS_EXT = "1017"
            };
            registrocrearoferta.POSICIONES_OFERTA.Add(p2);

            RegistroPosicionCrearOferta p3 = new RegistroPosicionCrearOferta()
            {
                ZSD_OFERTA2_POSNR_VA = "000020",
                ZSD_OFERTA2_MATNR = "7896018700642",
                ZSD_OFERTA2_KWMENG = "2",
                ZSD_OFERTA2_VRKME = "PCE",//ZSD_OFERTA2_VRKME = "ST",
                ZSD_OFERTA2_WERKS_EXT = "1017"
            };
            registrocrearoferta.POSICIONES_OFERTA.Add(p3);
            //}
            RespuestaCrearOferta r = rep.CrearOfertaSap(registrocrearoferta);
            MessageBox.Show("Estado Oferta: " + registrocrearoferta.ZSD_OFERTA1_BSTKD + ": " + r.statusOferta + "[" + r.excode + "(" + r.exdetail + ")]");
            MessageBox.Show("Estado Oferta: " + rep.ConsultarOfertaSap("20000").statusOferta);//19184
            MessageBox.Show("Estado Oferta: " + rep.ConsultarOfertaSap(registrocrearoferta.ZSD_OFERTA1_BSTKD).statusOferta);//19184
           


            rep.ConsultarClienteSap("V-02896298-0");
            RegistroCrearCliente clientenuevo = new RegistroCrearCliente()
            {
                DIRECT = "2",
                IDOCTYP = "ZCLIENTE",
                MANDT = "300",
                MESTYP = "ZKNA1",
                RCVPOR = "SAPDV1",
                RCVPRN = "SAP",
                RCVPRT = "LS",
                SNDPOR = "WEBX",
                SNDPRN = "WEBPLZ",
                SNDPRT = "LS",
                //ZCLIENTE
                ZCLIENTE_STCD1 = "V-02896298-0",
                ZCLIENTE_FIRSTNAME = "NELSON ARTURO",
                ZCLIENTE_LASTNAME = "RODRIGUEZ RODRIGUEZ",
                ZCLIENTE_STREET = "AV SOUBLETTE",
                ZCLIENTE_CITY = "MAIQUETIA",
                ZCLIENTE_COUNTRY = "VE",
                ZCLIENTE_REGION = "VAR",
                ZCLIENTE_PO_BOX = "1070",
                //ZCLIENTE_TRANSPZONE = "Z000001003",
                ZCLIENTE_REMARK = "FRENTE A ESCUELA MIGUEL SUNIAGA",
                ZCLIENTE_TEL_NUMBER = "02123320903",
                ZCLIENTE_MOB_NUMBER = "04144796531",
                ZCLIENTE_CORREO = "rodriguezrnelson@hotmail.com",
                //ZAREA_VTAS
                ZAREA_VTAS_SALESORG = "0100",
                ZAREA_VTAS_DISTR_CHAN = "02",
                ZAREA_VTAS_DIVISION = "01",
                ZAREA_VTAS_STCD1 = "V-02896298-0",
            };
            RespuestaCrearCliente respuesta = rep.CrearClienteSap(clientenuevo);
            MessageBox.Show("Respuesta: " + respuesta.excode + " : " + respuesta.exdetail + " : " + respuesta.idSapCliente);

            RegistroActualizarCliente clienteactualizar = new RegistroActualizarCliente()
            {
                PI_CUSTOMERNO = "",
                PI_SALESORG = "0100",
                PI_DISTR_CHAN = "02",
                PI_DIVISION = "01",
                PI_STCD1 = "V-02896298-0",
                //ZCLIENTE
                ZCLIENTE_NAME_FIRST = "NELSON ARTURO",
                ZCLIENTE_NAME_LAST = "RODRIGUEZ RODRIGUEZ",
                ZCLIENTE_STREET = "AV SOUBLETTE",
                ZCLIENTE_POST_CODE1 = "1070",
                ZCLIENTE_REGION = "VAR",
                ZCLIENTE_CITY1 = "MAIQUETIA",
                //ZCLIENTE_NAME_CO = "VENEZUELA",
                ZCLIENTE_COUNTRY = "VE",
                //ZCLIENTE_TRANSPZONE = "Z000001003",
                ZCLIENTE_REMARK = "FRENTE A ESCUELA MIGUEL SUNIAGA",
                ZCLIENTE_TEL_NUMBER = "02123320903-2",
                ZCLIENTE_MOB_NUMBER = "04144796531-2",
                ZCLIENTE_CORREO = "rodriguezrnelson@hotmail.com-2"
            };
            RespuestaActualizarCliente respuesta2 = rep.ActualizarClienteSap(clienteactualizar);
            MessageBox.Show("Respuesta2: " + respuesta2.excode + " : " + respuesta2.exdetail + " : " + respuesta2.idSapClientePrincipal);

            RegistroActualizarCliente clienteactualizar2 = new RegistroActualizarCliente()
            {
                PI_CUSTOMERNO = "0000300271",
                PI_SALESORG = "0100",
                PI_DISTR_CHAN = "02",
                PI_DIVISION = "01",
                PI_STCD1 = "V-02896298-0",

                Z_DIRECC_KUNNR = "",
                Z_DIRECC_STCD1 = "V-03977921-0",
                Z_DIRECC_NAME_FIRST = "margoth briceño",
                Z_DIRECC_NAME_LAST = "de rodriguez",
                Z_DIRECC_STREET = "AV SOUBLETTE2",
                Z_DIRECC_POST_CODE1 = "1070",
                Z_DIRECC_REGION = "VAR",
                Z_DIRECC_CITY1 = "MAIQUETIA",
                //Z_DIRECC_NAME_CO
                Z_DIRECC_COUNTRY = "VE",
                //Z_DIRECC_TRANSPZONE
                Z_DIRECC_REMARK = "FRENTE A ESCUELA MIGUEL SUNIAGA",
                Z_DIRECC_TEL_NUMBER = "02123320903",
                Z_DIRECC_MOB_NUMBER = "04144796531",
                Z_DIRECC_CORREO = "rodriguezrnelson@hotmail.com",
                Z_DIRECC_ACCION = "I"
            };
            RespuestaActualizarCliente respuesta3 = rep.ActualizarClienteSap(clienteactualizar2);
            MessageBox.Show("Respuesta2: " + respuesta3.excode + " : " + respuesta3.exdetail + " : " + respuesta3.idSapClientePrincipal + " : " + respuesta3.idSapClienteAlterno);
        }       

    }
}
