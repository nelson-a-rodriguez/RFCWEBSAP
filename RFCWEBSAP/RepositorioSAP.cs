using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFCWEBSAP
{
    public class RepositorioSAP
    {
        static RfcDestination SapRfcDestination;
        static RfcRepository SapRfcRepository;

        public RepositorioSAP(string NombreSistemaSap)
        {
            SapRfcDestination = RfcDestinationManager.GetDestination(NombreSistemaSap);
            SapRfcRepository = SapRfcDestination.Repository;
        }

        public List<RegistroInventario> ConsultarInventario(string sCentro, string sJerarquiaWeb)
        {
            try
            {
                IRfcFunction BapiZWEB_INVENTARIO = SapRfcRepository.CreateFunction("ZWEB_INVENTARIO_V2");
                BapiZWEB_INVENTARIO.SetValue("I_SUCURSAl", sCentro);
                BapiZWEB_INVENTARIO.SetValue("I_PRDHA", sJerarquiaWeb);
                BapiZWEB_INVENTARIO.Invoke(SapRfcDestination);
                //INVENTARIO
                IRfcTable tabla_E_INVENTARIO = BapiZWEB_INVENTARIO.GetTable("E_INVENTARIO");
                List<RegistroInventario> resultado = new List<RegistroInventario>();
                for (int InventarioPtr = 0; InventarioPtr < tabla_E_INVENTARIO.RowCount; InventarioPtr++)
                {
                    RegistroInventario fila = new RegistroInventario()
                    {
                        fila = tabla_E_INVENTARIO.CurrentIndex = InventarioPtr,
                        CENTRO = tabla_E_INVENTARIO.GetString("CENTRO"),
                        ALMACEN = tabla_E_INVENTARIO.GetString("ALMACEN"),
                        MATERIAL = tabla_E_INVENTARIO.GetString("MATERIAL"),
                        SAPNUM = tabla_E_INVENTARIO.GetString("SAPNUM"),
                        NOMBRE_L = tabla_E_INVENTARIO.GetString("NOMBRE_L"),
                        NOMBRE_C = tabla_E_INVENTARIO.GetString("NOMBRE_C"),
                        INVENTARIO = tabla_E_INVENTARIO.GetString("INVENTARIO"),
                        UNIDAD_VTA = tabla_E_INVENTARIO.GetString("UNIDAD_VTA"),
                        JERARQUIA = tabla_E_INVENTARIO.GetString("JERARQUIA"),
                        JERARQ_WEB = tabla_E_INVENTARIO.GetString("JERARQ_WEB"),
                        IMPUESTO = tabla_E_INVENTARIO.GetString("IMPUESTO"),
                        MONEDA = tabla_E_INVENTARIO.GetString("MONEDA"),
                        CADUCIDAD = tabla_E_INVENTARIO.GetString("CADUCIDAD"),
                        PROPIO = tabla_E_INVENTARIO.GetString("PROPIO"),
                        TIPO_ART = tabla_E_INVENTARIO.GetString("TIPO_ART"),
                        CLASE = tabla_E_INVENTARIO.GetString("CLASE"),
                        FEC_INICIO = tabla_E_INVENTARIO.GetString("FEC_INICIO"),
                        FEC_FIN = tabla_E_INVENTARIO.GetString("FEC_FIN"),
                        PRECIO = tabla_E_INVENTARIO.GetString("PRECIO"),
                        KMEIN = tabla_E_INVENTARIO.GetString("UNIDAD_COND"),
                        VOLUMEN = tabla_E_INVENTARIO.GetString("VOLUMEN"),
                        PESO = tabla_E_INVENTARIO.GetString("PESO"),
                        MARCA = tabla_E_INVENTARIO.GetString("MARCA")
                    };
                    resultado.Add(fila);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public List<RegistroJerarquiaWeb> ConsultarJerarquiaWeb()
        {
            try
            {
                IRfcFunction BapiZWEB_JERARQUIAWEB = SapRfcRepository.CreateFunction("ZWEB_JERARQUIAWEB");
                BapiZWEB_JERARQUIAWEB.Invoke(SapRfcDestination);
                //JERARQUIA WEB
                IRfcTable tabla_E_JERARQUIA_WEB = BapiZWEB_JERARQUIAWEB.GetTable("E_JERARQUIA_WEB");
                List<RegistroJerarquiaWeb> resultado = new List<RegistroJerarquiaWeb>();
                for (int JerarquiaPtr = 0; JerarquiaPtr < tabla_E_JERARQUIA_WEB.RowCount; JerarquiaPtr++)
                {
                    RegistroJerarquiaWeb fila = new RegistroJerarquiaWeb()
                    {
                        fila = tabla_E_JERARQUIA_WEB.CurrentIndex = JerarquiaPtr,
                        PRODH = tabla_E_JERARQUIA_WEB.GetString("PRODH"),
                        STUFE = tabla_E_JERARQUIA_WEB.GetString("STUFE"),
                        VTEXT = tabla_E_JERARQUIA_WEB.GetString("VTEXT"),
                    };
                    resultado.Add(fila);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public string ProbarIdocInboundSingle()
        {
            try
            {
                //IRfcFunction BapiBAPI_CUSTOMER_CREATEFROMDATA1 = SapRfcRepository.CreateFunction("BAPI_CUSTOMER_CREATEFROMDATA1");                
                //IRfcStructure estructura_PI_COPYREFERENCE = BapiBAPI_CUSTOMER_CREATEFROMDATA1.GetStructure("PI_COPYREFERENCE");
                //IRfcStructure estructura_PI_PERSONALDATA = BapiBAPI_CUSTOMER_CREATEFROMDATA1.GetStructure("PI_PERSONALDATA");
                //////Llenar parametros de funcion
                //estructura_PI_COPYREFERENCE.SetValue("SALESORG", "0100");
                //estructura_PI_COPYREFERENCE.SetValue("DISTR_CHAN", "02");
                //estructura_PI_COPYREFERENCE.SetValue("DIVISION", "01");
                //estructura_PI_COPYREFERENCE.SetValue("REF_CUSTMR", "V-14566318-0");
                //estructura_PI_PERSONALDATA.SetValue("TITLE_P", " ");
                //estructura_PI_PERSONALDATA.SetValue("FIRSTNAME", "nelson gerardo");
                //estructura_PI_PERSONALDATA.SetValue("LASTNAME", "rodriguez briceño");
                //estructura_PI_PERSONALDATA.SetValue("MIDDLENAME", " ");
                //estructura_PI_PERSONALDATA.SetValue("SECONDNAME", " ");
                //estructura_PI_PERSONALDATA.SetValue("DATE_BIRTH", " ");
                //estructura_PI_PERSONALDATA.SetValue("CITY", " ");
                //estructura_PI_PERSONALDATA.SetValue("DISTRICT", " ");
                //estructura_PI_PERSONALDATA.SetValue("POSTL_COD1", " ");
                //estructura_PI_PERSONALDATA.SetValue("POSTL_COD2", " ");
                //estructura_PI_PERSONALDATA.SetValue("PO_BOX", " ");
                //estructura_PI_PERSONALDATA.SetValue("PO_BOX_CIT", " ");
                //estructura_PI_PERSONALDATA.SetValue("STREET", " ");
                //estructura_PI_PERSONALDATA.SetValue("HOUSE_NO", " ");
                //estructura_PI_PERSONALDATA.SetValue("BUILDING", " ");
                //estructura_PI_PERSONALDATA.SetValue("FLOOR", " ");
                //estructura_PI_PERSONALDATA.SetValue("ROOM_NO", " ");
                //estructura_PI_PERSONALDATA.SetValue("COUNTRY", " ");
                //estructura_PI_PERSONALDATA.SetValue("COUNTRYISO", " ");
                //estructura_PI_PERSONALDATA.SetValue("REGION", " ");
                //estructura_PI_PERSONALDATA.SetValue("TEL1_NUMBR", " ");
                //estructura_PI_PERSONALDATA.SetValue("TEL1_EXT", " ");
                //estructura_PI_PERSONALDATA.SetValue("FAX_NUMBER", " ");
                //estructura_PI_PERSONALDATA.SetValue("FAX_EXTENS", " ");
                //estructura_PI_PERSONALDATA.SetValue("E_MAIL", " ");
                //estructura_PI_PERSONALDATA.SetValue("LANGU_P", " ");
                //estructura_PI_PERSONALDATA.SetValue("LANGUP_ISO", " ");
                //estructura_PI_PERSONALDATA.SetValue("CURRENCY", " ");
                //estructura_PI_PERSONALDATA.SetValue("CURRENCY_ISO", " ");
                //estructura_PI_PERSONALDATA.SetValue("TITLE_KEY", " ");
                //estructura_PI_PERSONALDATA.SetValue("ONLY_CHANGE_COMADDRESS", " ");
                //BapiBAPI_CUSTOMER_CREATEFROMDATA1.Invoke(SapRfcDestination);
                //IRfcStructure estructura_RETURN = BapiBAPI_CUSTOMER_CREATEFROMDATA1.GetStructure("RETURN");
                //string mensaje = estructura_RETURN.GetString("TYPE") + " " + estructura_RETURN.GetString("MESSAGE");                
                //return mensaje;  


                IRfcFunction BapiIDOC_INBOUND_SINGLE = SapRfcRepository.CreateFunction("IDOC_INBOUND_SINGLE");
                IRfcStructure estructura_PI_IDOC_CONTROL_REC_40 = BapiIDOC_INBOUND_SINGLE.GetStructure("PI_IDOC_CONTROL_REC_40");
                IRfcTable tabla_PT_IDOC_DATA_RECORDS_40 = BapiIDOC_INBOUND_SINGLE.GetTable("PT_IDOC_DATA_RECORDS_40");
                BapiIDOC_INBOUND_SINGLE.SetValue("PI_DO_COMMIT", "X");
                //no existe: Llenar estructura de control de funcion, estos datos los tengo yo, quizas los ponga en el appconfig/webconfig
                //no existe: estructura_PI_IDOC_CONTROL_REC_40.SetValue("CLIENT", "100");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("DIRECT", "2");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("IDOCTYP", "ZCLIENTE");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("MANDT", "300");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("MESTYP", "ZKNA1");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPOR", "SAPDV1");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPRN", "SAP");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPRT", "LS");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPOR", "WEBX");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPRN", "WEBPLZ");
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPRT", "LS");
                //no existe: estructura_PI_IDOC_CONTROL_REC_40.SetValue("SYSTEMNUMBER", "0");
                //no existe: estructura_PI_IDOC_CONTROL_REC_40.SetValue("USERNAME", "webplz");
                //Llenar estructura de datos de funcion
                //ZCLIENTE, estos datos si recibirlos de la web
                tabla_PT_IDOC_DATA_RECORDS_40.Append();
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SEGNAM", "ZCLIENTE");
                string sdata = "";
                sdata = sdata + "V-14768188-0    "; //_stcd1 = new char[16];*
                sdata = sdata + "        "; //_date_birth = new char[8];
                sdata = sdata + "0"; //_famst = new char();
                sdata = sdata + "1                             "; //_Title_P = new char[30];
                sdata = sdata + "nelson gerardo                          "; //_FirstName = new char[40];*
                sdata = sdata + "rodriguez briceño                       "; //_LastName = new char[40];*
                sdata = sdata + "                                        "; //_MiddleName = new char[40];
                sdata = sdata + "                                        "; //_SecondName = new char[40];
                sdata = sdata + "                                        "; //_Name2_P = new char[40];
                sdata = sdata + "                    "; //_Title_Aca1 = new char[20];
                sdata = sdata + "1"; //_Parge = new char();
                sdata = sdata + "                                        "; //_HomeCity = new char[40];
                sdata = sdata + "av soublette                                                "; //_Street = new char[60];*
                sdata = sdata + "          "; //_House_NO = new char[10];
                sdata = sdata + "                                        "; //_Str_Suppl1 = new char[40];
                sdata = sdata + "                                        "; //_Str_Suppl2 = new char[40];
                sdata = sdata + "                                        "; //_Str_Suppl3 = new char[40];
                sdata = sdata + "                                    "; //_Location = new char[36];
                sdata = sdata + "          "; //_Postl_Cod1 = new char[10];
                sdata = sdata + "maiquetia                               "; //_City = new char[40];*
                sdata = sdata + "                                        "; //_District = new char[40];
                sdata = sdata + "ve "; //_Country = new char[3];*
                sdata = sdata + "var"; //_Region = new char[3];*
                sdata = sdata + "1070      "; //_Po_Box = new char[10];*
                sdata = sdata + "                              "; //_Tel1_Numbr = new char[30];
                sdata = sdata + "          "; //_Tel1_Ext = new char[10];
                sdata = sdata + "                              "; //_Mob_Number = new char[30];
                sdata = sdata + "                              "; //_FaxNumber = new char[30];
                sdata = sdata + "          "; //_Fax_Extens = new char[10];
                sdata = sdata + "                                                                                                                        "; //_zclientee_mail = new char[120];
                sdata = sdata + "referencia                                        "; //_remark = new char[50];
                //sdata = sdata + "ZNAT"; //_KTOKD = new char[4];*
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SDATA", sdata);
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("HLEVEL", "01");
                //ZAREA_VTAS, estos datos si recibirlos de la web
                tabla_PT_IDOC_DATA_RECORDS_40.Append();
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SEGNAM", "ZAREA_VTAS");
                string sdata2 = "";
                sdata2 = sdata2 + "0100";
                sdata2 = sdata2 + "02";
                sdata2 = sdata2 + "01";
                sdata2 = sdata2 + "V-14768188-0";
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SDATA", sdata2);
                //ejecutar funcion
                BapiIDOC_INBOUND_SINGLE.Invoke(SapRfcDestination);
                var error = BapiIDOC_INBOUND_SINGLE.GetValue("PE_ERROR_PRIOR_TO_APPLICATION").ToString();
                var idoc = BapiIDOC_INBOUND_SINGLE.GetValue("PE_IDOC_NUMBER").ToString();
                return error + " " + idoc;            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public string BuscarCliente(string NroDocumento)
        {
            try
            {
                IRfcFunction BapiZWEB_GET_CUSTOMER = SapRfcRepository.CreateFunction("ZWEB_GET_CUSTOMER");
                BapiZWEB_GET_CUSTOMER.SetValue("A_STCD1", NroDocumento);
                BapiZWEB_GET_CUSTOMER.Invoke(SapRfcDestination);
                IRfcTable tabla_ZDIR_ALTERNA = BapiZWEB_GET_CUSTOMER.GetTable("ZDIR_ALTERNA");
                List<Object> filas = new List<Object>();
                for (int JerarquiaPtr = 0; JerarquiaPtr < tabla_ZDIR_ALTERNA.RowCount; JerarquiaPtr++)
                {
                    var fila = new
                    {
                        fila = tabla_ZDIR_ALTERNA.CurrentIndex = JerarquiaPtr,
                        NU_ALTERNO = tabla_ZDIR_ALTERNA.GetString("NU_ALTERNO"),
                        NOMBRE = tabla_ZDIR_ALTERNA.GetString("NOMBRE"),
                        APELLIDO = tabla_ZDIR_ALTERNA.GetString("APELLIDO"),
                        CEDULA = tabla_ZDIR_ALTERNA.GetString("CEDULA"),
                        TELEFONO = tabla_ZDIR_ALTERNA.GetString("TELEFONO"),
                        CALLE1 = tabla_ZDIR_ALTERNA.GetString("CALLE1"),
                        CALLE2 = tabla_ZDIR_ALTERNA.GetString("CALLE2"),
                        URBANIZACION = tabla_ZDIR_ALTERNA.GetString("URBANIZACION"),
                        CIUDAD = tabla_ZDIR_ALTERNA.GetString("CIUDAD"),
                        ESTADO = tabla_ZDIR_ALTERNA.GetString("ESTADO"),
                        PAIS = tabla_ZDIR_ALTERNA.GetString("PAIS"),
                        CODIGO_POSTAL = tabla_ZDIR_ALTERNA.GetString("CODIGO_POSTAL"),
                        REMARK = tabla_ZDIR_ALTERNA.GetString("REMARK")
                    };
                    filas.Add(fila);
                }
                return BapiZWEB_GET_CUSTOMER.GetValue("A_KUNNR").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
        }

        public string ActualizarCliente(string NroCliente, RegistroCliente DatosCliente)
        {
            try
            {
                IRfcFunction BapiZWEB_UPD_CUSTOMER = SapRfcRepository.CreateFunction("ZWEB_UPD_CUSTOMER");
                BapiZWEB_UPD_CUSTOMER.SetValue("PI_CUSTOMERNO", NroCliente);
                BapiZWEB_UPD_CUSTOMER.SetValue("PI_SALESORG", DatosCliente.VKORG);
                BapiZWEB_UPD_CUSTOMER.SetValue("PI_DISTR_CHAN", DatosCliente.VTWEG);
                BapiZWEB_UPD_CUSTOMER.SetValue("PI_DIVISION", DatosCliente.SPART);
                BapiZWEB_UPD_CUSTOMER.SetValue("PI_STCD1", DatosCliente.STCD1);      
                IRfcStructure estructura_PI_ADRC = BapiZWEB_UPD_CUSTOMER.GetStructure("PI_ADRC");
                estructura_PI_ADRC.SetValue("NAME_FIRST", DatosCliente.NAME_FIRST);
                estructura_PI_ADRC.SetValue("NAMEMIDDLE", DatosCliente.NAMEMIDDLE);
                estructura_PI_ADRC.SetValue("NAME_LAST2", DatosCliente.NAME_LAST2);
                estructura_PI_ADRC.SetValue("NAME_LAST", DatosCliente.NAME_LAST);
                estructura_PI_ADRC.SetValue("NAME2_P", DatosCliente.NAME2_P);
                estructura_PI_ADRC.SetValue("NAMCOUNTRY", DatosCliente.NAMCOUNTRY);
                estructura_PI_ADRC.SetValue("STR_SUPPL1", DatosCliente.STR_SUPPL1);
                estructura_PI_ADRC.SetValue("STR_SUPPL2", DatosCliente.STR_SUPPL2);
                estructura_PI_ADRC.SetValue("STR_SUPPL3", DatosCliente.STR_SUPPL3);
                estructura_PI_ADRC.SetValue("STREET", DatosCliente.STREET);
                estructura_PI_ADRC.SetValue("LOCATION", DatosCliente.LOCATION);
                estructura_PI_ADRC.SetValue("CITY2", DatosCliente.CITY2);
                estructura_PI_ADRC.SetValue("HOME_CITY", DatosCliente.HOME_CITY);
                estructura_PI_ADRC.SetValue("POST_CODE1", DatosCliente.POST_CODE1);
                estructura_PI_ADRC.SetValue("CITY1", DatosCliente.CITY1);
                estructura_PI_ADRC.SetValue("COUNTRY", DatosCliente.COUNTRY);
                estructura_PI_ADRC.SetValue("REGION", DatosCliente.REGION);
                estructura_PI_ADRC.SetValue("REMARK", DatosCliente.REMARK);
                IRfcStructure estructura_PI_SZA7 = BapiZWEB_UPD_CUSTOMER.GetStructure("PI_SZA7");
                estructura_PI_SZA7.SetValue("TITLE_MEDI", DatosCliente.TITLE_MEDI);
                estructura_PI_SZA7.SetValue("TITLE_ACA1", DatosCliente.TITLE_ACA1);
                estructura_PI_SZA7.SetValue("TEL_NUMBER", DatosCliente.TEL_NUMBER);
                estructura_PI_SZA7.SetValue("MOB_NUMBER", DatosCliente.MOB_NUMBER);
                estructura_PI_SZA7.SetValue("SMTP_ADDR", DatosCliente.SMTP_ADDR);
                IRfcStructure estructura_PI_KNVK = BapiZWEB_UPD_CUSTOMER.GetStructure("PI_KNVK");
                estructura_PI_KNVK.SetValue("PARGE", DatosCliente.PARGE);
                estructura_PI_KNVK.SetValue("GBDAT", DatosCliente.GBDAT);
                estructura_PI_KNVK.SetValue("FAMST", DatosCliente.FAMST);
                estructura_PI_KNVK.SetValue("KUNNR", DatosCliente.KUNNR);
                
                BapiZWEB_UPD_CUSTOMER.Invoke(SapRfcDestination);
                IRfcTable tabla_TI_RETURN = BapiZWEB_UPD_CUSTOMER.GetTable("TI_RETURN");
                string msg = tabla_TI_RETURN.GetValue("MSGTYP").ToString();
                msg = msg + "/" + tabla_TI_RETURN.GetString("MSGV1") + "/" + tabla_TI_RETURN.GetString("MSGV2") + "/" + tabla_TI_RETURN.GetString("MSGV3") + "/" + tabla_TI_RETURN.GetString("MSGV4");
                msg = msg + "/" + tabla_TI_RETURN.GetString("FLDNAME");
                return msg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
        }

    }
}
