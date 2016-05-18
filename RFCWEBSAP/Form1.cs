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
            string EntornoSAP = System.Configuration.ConfigurationManager.AppSettings["EntornoSAP"];
            RepositorioSAP rep = new RepositorioSAP(EntornoSAP);
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
            string EntornoSAP = System.Configuration.ConfigurationManager.AppSettings["EntornoSAP"];
            RepositorioSAP rep = new RepositorioSAP(EntornoSAP);
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
            string EntornoSAP = System.Configuration.ConfigurationManager.AppSettings["EntornoSAP"];
            RepositorioSAP rep = new RepositorioSAP(EntornoSAP);
            string resultado = rep.ProbarIdocInboundSingle();
            //string NroCliente = rep.BuscarCliente("V-14566318-0");
            string NroCliente = rep.BuscarCliente("V-14768188-0");
            //string resultado = rep.InsertarActualizarCliente("V-14768188-0", "");
            //{ fila = 0, NU_ALTERNO = 0000306258, NOMBRE = NELSON ARTURO RODRIGUEZ BRICEÑO, APELLIDO = , CEDULA = V-14566318-0, TELEFONO = 02123320903, CALLE1 = PRINCIPAL LO CHORROS, CALLE2 = , URBANIZACION = DOS CAMINOS, CIUDAD = CARACAS, ESTADO = DF, PAIS = VE, CODIGO_POSTAL = 1071, REMARK = 
            RegistroCliente DatosCliente = new RegistroCliente()
            {
                STCD1 = "V-14566318-0", // PI_STCD1 ,
                FAMST = 0,
                TITLE_P = 1,
                FIRSTNAME = "NELSON ARTURO",
                LASTNAME = "RODRIGUEZ BRICEÑO",
                PARGE = 1,
                STREET = "AV SOUBLETTE",
                CITY = "MAIQUETIA",
                COUNTRY = "VE",
                REGION = "VAR",
                KTOKD = "ZNAT",

                VKORG = "0100", // PI_SALESORG 
                VTWEG = "02",  // PI_DISTR_CHAN 
                SPART = "01",   //PI_DIVISION 

                GBDAT = "19800906",
                KUNNR = NroCliente,

                TITLE_MEDI ="100",
                TITLE_ACA1 = "200",
                TEL_NUMBER = "300",
                MOB_NUMBER = "400",
                SMTP_ADDR = "500",

                NAME_FIRST = "600",
                NAMEMIDDLE = "700",
                NAME_LAST2 = "800",
                NAME_LAST = "900",
                NAME2_P = "1000",
                NAMCOUNTRY = "2000",
                STR_SUPPL1 = "3000",
                STR_SUPPL2 = "4000",
                STR_SUPPL3 = "5000",
                LOCATION = "6000",
                CITY2 = "7000",
                HOME_CITY = "8000",
                POST_CODE1 = "9000",
                CITY1 = "10000",
                REMARK = "11000",
            };

            //string resultado = rep.ActualizarCliente(NroCliente, DatosCliente);
            //MessageBox.Show(resultado);
        }

    }
}
