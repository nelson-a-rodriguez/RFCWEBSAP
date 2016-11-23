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
        RfcDestination SapRfcDestination;
        RfcRepository SapRfcRepository;
        SapConnection con;

        public RepositorioSAP(SapParametros parametros)
        {
            con = new SapConnection(parametros);
            if (RfcDestinationManager.TryGetDestination(con.parametros.Name) == null)
            {
                RfcDestinationManager.RegisterDestinationConfiguration(con);
            }
            SapRfcDestination = RfcDestinationManager.GetDestination(con.parametros.Name);
            SapRfcRepository = SapRfcDestination.Repository;
        }

        public RepositorioSAP(string NombreSistemaSap)
        {
            SapRfcDestination = RfcDestinationManager.GetDestination(NombreSistemaSap);
            SapRfcRepository = SapRfcDestination.Repository;
        }

        public List<RegistroInventario> ConsultarInventario(string sCentro, string sJerarquiaWeb)
        {
            List<RegistroInventario> inventarios = new List<RegistroInventario>();
            try
            {
                IRfcFunction BapiZWEB_INVENTARIO = SapRfcRepository.CreateFunction("ZWEB_INVENTARIO_V2");
                BapiZWEB_INVENTARIO.SetValue("I_SUCURSAl", sCentro);
                BapiZWEB_INVENTARIO.SetValue("I_PRDHA", sJerarquiaWeb);
                BapiZWEB_INVENTARIO.Invoke(SapRfcDestination);
                IRfcTable tabla_E_INVENTARIO = BapiZWEB_INVENTARIO.GetTable("E_INVENTARIO");
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
                    inventarios.Add(fila);
                }
                return inventarios;
            }
            catch (Exception ex)
            {
                inventarios = new List<RegistroInventario>();
                RegistroInventario fila = new RegistroInventario()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                inventarios.Add(fila);
                return inventarios;
            }
        }

        public List<RegistroJerarquiaWeb> ConsultarJerarquiaWeb()
        {
            List<RegistroJerarquiaWeb> jerarquias = new List<RegistroJerarquiaWeb>();
            try
            {
                //pruebas de bapis de despacho automatizado
                //IRfcFunction BapiZWEB_JERARQUIAWEB1 = SapRfcRepository.CreateFunction("ZSD_GRABAR_FACTURA_FISCAL");
                //IRfcFunction BapiZWEB_JERARQUIAWEB1 = SapRfcRepository.CreateFunction("ZMM_VALIDA");
                //IRfcFunction BapiZWEB_JERARQUIAWEB1 = SapRfcRepository.CreateFunction("ZMM_VT01N");
                //BapiZWEB_JERARQUIAWEB1.SetValue("RESWK", "1001");
                //BapiZWEB_JERARQUIAWEB1.SetValue("EWERK", "1006");
                //IRfcTable tabla_E_JERARQUIA_WEB1 = BapiZWEB_JERARQUIAWEB1.GetTable("ZMATERIALES");
                //IRfcTable tabla_E_JERARQUIA_WEB2 = BapiZWEB_JERARQUIAWEB1.GetTable("RETURN");
                //tabla_E_JERARQUIA_WEB1.Append();
                //tabla_E_JERARQUIA_WEB1.CurrentRow.SetValue("MATERIAL", "000000000000020001");
                ////tabla_E_JERARQUIA_WEB1.CurrentRow.SetValue("MATERIAL", "2800010000001");
                //tabla_E_JERARQUIA_WEB1.CurrentRow.SetValue("CANTIDAD", "10");
                //tabla_E_JERARQUIA_WEB1.CurrentRow.SetValue("UNIDAD", "ST");
                //BapiZWEB_JERARQUIAWEB1.Invoke(SapRfcDestination);
                
                IRfcFunction BapiZWEB_JERARQUIAWEB = SapRfcRepository.CreateFunction("ZWEB_JERARQUIAWEB");
                BapiZWEB_JERARQUIAWEB.Invoke(SapRfcDestination);
                IRfcTable tabla_E_JERARQUIA_WEB = BapiZWEB_JERARQUIAWEB.GetTable("E_JERARQUIA_WEB");
                for (int JerarquiaPtr = 0; JerarquiaPtr < tabla_E_JERARQUIA_WEB.RowCount; JerarquiaPtr++)
                {
                    RegistroJerarquiaWeb fila = new RegistroJerarquiaWeb()
                    {
                        fila = tabla_E_JERARQUIA_WEB.CurrentIndex = JerarquiaPtr,
                        PRODH = tabla_E_JERARQUIA_WEB.GetString("PRODH"),
                        STUFE = tabla_E_JERARQUIA_WEB.GetString("STUFE"),
                        VTEXT = tabla_E_JERARQUIA_WEB.GetString("VTEXT"),
                    };
                    jerarquias.Add(fila);
                }
                return jerarquias;
            }
            catch (Exception ex)
            {
                jerarquias = new List<RegistroJerarquiaWeb>();
                RegistroJerarquiaWeb fila = new RegistroJerarquiaWeb()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                jerarquias.Add(fila);
                return jerarquias;
            }
        }

        public RegistroCliente ConsultarClienteSap(string NroDocumento)
        {
            RegistroCliente cliente = new RegistroCliente();
            try
            {
                IRfcFunction BapiZWEB_GET_CUSTOMER = SapRfcRepository.CreateFunction("ZWEB_GET_CUSTOMER");
                BapiZWEB_GET_CUSTOMER.SetValue("A_STCD1", NroDocumento);
                BapiZWEB_GET_CUSTOMER.Invoke(SapRfcDestination);
                cliente.CUSTOMERNO = BapiZWEB_GET_CUSTOMER.GetValue("A_KUNNR").ToString();
                return cliente;
            }
            catch (Exception ex)
            {
                cliente = new RegistroCliente()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                return cliente;
            }
        }

        public RespuestaCrearCliente CrearClienteSap(RegistroCrearCliente datoscliente)
        {
            RespuestaCrearCliente cliente = new RespuestaCrearCliente();
            try
            {
                IRfcFunction BapiIDOC_INBOUND_SINGLE = SapRfcRepository.CreateFunction("IDOC_INBOUND_SINGLE");
                IRfcStructure estructura_PI_IDOC_CONTROL_REC_40 = BapiIDOC_INBOUND_SINGLE.GetStructure("PI_IDOC_CONTROL_REC_40");
                IRfcTable tabla_PT_IDOC_DATA_RECORDS_40 = BapiIDOC_INBOUND_SINGLE.GetTable("PT_IDOC_DATA_RECORDS_40");
                BapiIDOC_INBOUND_SINGLE.SetValue("PI_DO_COMMIT", "X");
                //DATOS DE CONTROL
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("DIRECT", datoscliente.DIRECT);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("IDOCTYP", datoscliente.IDOCTYP);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("MANDT", datoscliente.MANDT);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("MESTYP", datoscliente.MESTYP);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPOR", datoscliente.RCVPOR);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPRN", datoscliente.RCVPRN);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPRT", datoscliente.RCVPRT);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPOR", datoscliente.SNDPOR);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPRN", datoscliente.SNDPRN);
                estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPRT", datoscliente.SNDPRT);
                //ZCLIENTE
                tabla_PT_IDOC_DATA_RECORDS_40.Append();
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SEGNAM", "ZCLIENTE");
                string sdata = "";
                sdata = sdata + datoscliente.ZCLIENTE_STCD1.PadRight(16); //_stcd1 = new char[16];*
                sdata = sdata + "        "; //_date_birth = new char[8];
                sdata = sdata + " "; //_famst = new char();
                sdata = sdata + "                              "; //_Title_P = new char[30];
                sdata = sdata + datoscliente.ZCLIENTE_FIRSTNAME.PadRight(40); //_FirstName = new char[40];*
                sdata = sdata + datoscliente.ZCLIENTE_LASTNAME.PadRight(40); //_LastName = new char[40];*
                sdata = sdata + "                                        "; //_MiddleName = new char[40];
                sdata = sdata + "                                        "; //_SecondName = new char[40];
                sdata = sdata + "                                        "; //_Name2_P = new char[40];
                sdata = sdata + "                    "; //_Title_Aca1 = new char[20];
                sdata = sdata + " "; //_Parge = new char();
                sdata = sdata + "                                        "; //_HomeCity = new char[40];
                sdata = sdata + datoscliente.ZCLIENTE_STREET.PadRight(60); //_Street = new char[60];*
                sdata = sdata + "          "; //_House_NO = new char[10];
                sdata = sdata + "                                        "; //_Str_Suppl1 = new char[40];
                sdata = sdata + "                                        "; //_Str_Suppl2 = new char[40];
                sdata = sdata + "                                        "; //_Str_Suppl3 = new char[40];
                sdata = sdata + "                                    "; //_Location = new char[36];
                sdata = sdata + "          "; //_Postl_Cod1 = new char[10];
                sdata = sdata + datoscliente.ZCLIENTE_CITY.PadRight(40); //_City = new char[40];*
                sdata = sdata + "                                        "; //_District = new char[40];
                sdata = sdata + datoscliente.ZCLIENTE_COUNTRY.PadRight(3); ; //_Country = new char[3];*
                sdata = sdata + datoscliente.ZCLIENTE_REGION.PadRight(3); //_Region = new char[3];*
                sdata = sdata + datoscliente.ZCLIENTE_PO_BOX.PadRight(10); //_Po_Box = new char[10];*
                sdata = sdata + datoscliente.ZCLIENTE_TEL_NUMBER.PadRight(30); //_Tel1_Numbr = new char[30];
                sdata = sdata + "          "; //_Tel1_Ext = new char[10];
                sdata = sdata + datoscliente.ZCLIENTE_MOB_NUMBER.PadRight(30); //_Mob_Number = new char[30];
                sdata = sdata + "                              "; //_FaxNumber = new char[30];
                sdata = sdata + "          "; //_Fax_Extens = new char[10];
                sdata = sdata + datoscliente.ZCLIENTE_CORREO.PadRight(120); //_zclientee_mail = new char[120];
                sdata = sdata + datoscliente.ZCLIENTE_REMARK.PadRight(50); //_remark = new char[50];
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SDATA", sdata);
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("HLEVEL", "01");
                //ZAREA_VTAS
                tabla_PT_IDOC_DATA_RECORDS_40.Append();
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SEGNAM", "ZAREA_VTAS");
                string sdata2 = "";
                sdata2 = sdata2 + datoscliente.ZAREA_VTAS_SALESORG.PadRight(4);
                sdata2 = sdata2 + datoscliente.ZAREA_VTAS_DISTR_CHAN.PadRight(2);
                sdata2 = sdata2 + datoscliente.ZAREA_VTAS_DIVISION.PadRight(2);
                sdata2 = sdata2 + datoscliente.ZAREA_VTAS_STCD1;
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SDATA", sdata2);
                tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("HLEVEL", "01");
                BapiIDOC_INBOUND_SINGLE.Invoke(SapRfcDestination);
                var error = BapiIDOC_INBOUND_SINGLE.GetValue("PE_ERROR_PRIOR_TO_APPLICATION").ToString();
                var idoc = BapiIDOC_INBOUND_SINGLE.GetValue("PE_IDOC_NUMBER").ToString();
                RegistroCliente consulta = ConsultarClienteSap(datoscliente.ZCLIENTE_STCD1);
                if (consulta.excode == 0 && consulta.CUSTOMERNO != "")
                {
                    cliente.idSapCliente = consulta.CUSTOMERNO;
                    return cliente;
                }
                else
                {
                    cliente.excode = consulta.excode;
                    cliente.exdetail = consulta.exdetail;
                    return cliente;
                }
            }
            catch (Exception ex)
            {
                cliente = new RespuestaCrearCliente()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                return cliente;
            }
        }

        public RespuestaActualizarCliente ActualizarClienteSap(RegistroActualizarCliente datoscliente)
        {
            RespuestaActualizarCliente cliente = new RespuestaActualizarCliente();
            try
            {
                IRfcFunction BapiZWEB_UPD_CUSTOMER_V2 = SapRfcRepository.CreateFunction("ZWEB_UPD_CUSTOMER_V2");
                BapiZWEB_UPD_CUSTOMER_V2.SetValue("PI_CUSTOMERNO", datoscliente.PI_CUSTOMERNO);
                BapiZWEB_UPD_CUSTOMER_V2.SetValue("PI_SALESORG", datoscliente.PI_SALESORG);
                BapiZWEB_UPD_CUSTOMER_V2.SetValue("PI_DISTR_CHAN", datoscliente.PI_DISTR_CHAN);
                BapiZWEB_UPD_CUSTOMER_V2.SetValue("PI_DIVISION", datoscliente.PI_DIVISION);
                BapiZWEB_UPD_CUSTOMER_V2.SetValue("PI_STCD1", datoscliente.PI_STCD1);//   
                //ZCLIENTE
                IRfcStructure estructura_ZCLIENTE = BapiZWEB_UPD_CUSTOMER_V2.GetStructure("Z_CLIENTE");
                estructura_ZCLIENTE.SetValue("NAME_FIRST", datoscliente.ZCLIENTE_NAME_FIRST);//
                estructura_ZCLIENTE.SetValue("NAME_LAST", datoscliente.ZCLIENTE_NAME_LAST);//
                estructura_ZCLIENTE.SetValue("STREET", datoscliente.ZCLIENTE_STREET);//
                estructura_ZCLIENTE.SetValue("POST_CODE1", datoscliente.Z_DIRECC_POST_CODE1);
                estructura_ZCLIENTE.SetValue("REGION", datoscliente.ZCLIENTE_REGION);
                estructura_ZCLIENTE.SetValue("CITY1", datoscliente.ZCLIENTE_CITY1);
                estructura_ZCLIENTE.SetValue("COUNTRY", datoscliente.ZCLIENTE_COUNTRY);
                estructura_ZCLIENTE.SetValue("REMARK", datoscliente.ZCLIENTE_REMARK);
                estructura_ZCLIENTE.SetValue("TEL_NUMBER", datoscliente.ZCLIENTE_TEL_NUMBER);
                estructura_ZCLIENTE.SetValue("MOB_NUMBER", datoscliente.ZCLIENTE_MOB_NUMBER);
                estructura_ZCLIENTE.SetValue("CORREO", datoscliente.ZCLIENTE_CORREO);
                //Z_DIRECC
                IRfcTable Tabla_Z_DIRECC = BapiZWEB_UPD_CUSTOMER_V2.GetTable("Z_DIRECC");
                Tabla_Z_DIRECC.Append();
                Tabla_Z_DIRECC.SetValue("KUNNR", datoscliente.Z_DIRECC_KUNNR);
                Tabla_Z_DIRECC.SetValue("STCD1", datoscliente.Z_DIRECC_STCD1);
                Tabla_Z_DIRECC.SetValue("NAME_FIRST", datoscliente.Z_DIRECC_NAME_FIRST);
                Tabla_Z_DIRECC.SetValue("NAME_LAST", datoscliente.Z_DIRECC_NAME_LAST);
                Tabla_Z_DIRECC.SetValue("STREET", datoscliente.Z_DIRECC_STREET);
                Tabla_Z_DIRECC.SetValue("POST_CODE1", datoscliente.Z_DIRECC_POST_CODE1);
                Tabla_Z_DIRECC.SetValue("REGION", datoscliente.Z_DIRECC_REGION);
                Tabla_Z_DIRECC.SetValue("CITY1", datoscliente.Z_DIRECC_CITY1);
                Tabla_Z_DIRECC.SetValue("COUNTRY", datoscliente.Z_DIRECC_COUNTRY);
                Tabla_Z_DIRECC.SetValue("REMARK", datoscliente.Z_DIRECC_REMARK);
                Tabla_Z_DIRECC.SetValue("TEL_NUMBER", datoscliente.Z_DIRECC_TEL_NUMBER);
                Tabla_Z_DIRECC.SetValue("MOB_NUMBER", datoscliente.Z_DIRECC_MOB_NUMBER);
                Tabla_Z_DIRECC.SetValue("CORREO", datoscliente.Z_DIRECC_CORREO);
                Tabla_Z_DIRECC.SetValue("ACCION", datoscliente.Z_DIRECC_ACCION);
                BapiZWEB_UPD_CUSTOMER_V2.Invoke(SapRfcDestination);
                IRfcTable tabla_TI_RETURN = BapiZWEB_UPD_CUSTOMER_V2.GetTable("TI_RETURN");
                string msg = tabla_TI_RETURN.GetValue("MSGTYP").ToString();
                if (msg == "S")
                {
                    cliente.idSapClientePrincipal = datoscliente.PI_CUSTOMERNO;
                    cliente.idSapClienteAlterno = BapiZWEB_UPD_CUSTOMER_V2.GetValue("W_DESTINATARIO").ToString();
                }
                else
                {
                    cliente.excode = -1;
                    cliente.exdetail = tabla_TI_RETURN.GetString("FLDNAME");
                }
                return cliente;
            }
            catch (Exception ex)
            {
                cliente = new RespuestaActualizarCliente()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                return cliente;
            }
        }

        public RegistroOferta ConsultarOfertaSap(string sPedido)
        {
            RegistroOferta oferta = new RegistroOferta();
            try
            {
                IRfcFunction BapiZWEB_STATUS_DOC = SapRfcRepository.CreateFunction("ZWEB_STATUS_DOC");
                BapiZWEB_STATUS_DOC.SetValue("A_BSTNK", sPedido);
                BapiZWEB_STATUS_DOC.Invoke(SapRfcDestination);
                IRfcTable Tabla_TI_STATUS = BapiZWEB_STATUS_DOC.GetTable("TI_STATUS");
                for (int OfertaPtr = 0; OfertaPtr < Tabla_TI_STATUS.RowCount; OfertaPtr++)
                {
                    Tabla_TI_STATUS.CurrentIndex = OfertaPtr;
                    oferta.statusOferta = Tabla_TI_STATUS.GetString("STATUS");
                }
                return oferta;
            }
            catch (Exception ex)
            {
                oferta = new RegistroOferta()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                return oferta;
            }
        }

        public RespuestaCrearOferta CrearOfertaSap(RegistroCrearOferta datosoferta)
        {
            RespuestaCrearOferta oferta = new RespuestaCrearOferta();
            try
            {
                //consultar pedido para evitar duplicidades, si no existe, mandar el idoc de creación
                RegistroOferta consulta = ConsultarOfertaSap(datosoferta.ZSD_OFERTA1_BSTKD);
                if (consulta.excode == 0 && consulta.statusOferta == "0")
                {
                    IRfcFunction BapiIDOC_INBOUND_SINGLE = SapRfcRepository.CreateFunction("IDOC_INBOUND_SINGLE");
                    IRfcStructure estructura_PI_IDOC_CONTROL_REC_40 = BapiIDOC_INBOUND_SINGLE.GetStructure("PI_IDOC_CONTROL_REC_40");
                    IRfcTable tabla_PT_IDOC_DATA_RECORDS_40 = BapiIDOC_INBOUND_SINGLE.GetTable("PT_IDOC_DATA_RECORDS_40");
                    BapiIDOC_INBOUND_SINGLE.SetValue("PI_DO_COMMIT", "X");
                    //DATOS DE CONTROL
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("DIRECT", datosoferta.DIRECT);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("IDOCTYP", datosoferta.IDOCTYP);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("MANDT", datosoferta.MANDT);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("MESTYP", datosoferta.MESTYP);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPOR", datosoferta.RCVPOR);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPRN", datosoferta.RCVPRN);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("RCVPRT", datosoferta.RCVPRT);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPOR", datosoferta.SNDPOR);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPRN", datosoferta.SNDPRN);
                    estructura_PI_IDOC_CONTROL_REC_40.SetValue("SNDPRT", datosoferta.SNDPRT);
                    //ZSD_OFERTA1 
                    tabla_PT_IDOC_DATA_RECORDS_40.Append();
                    tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SEGNAM", "ZSD_OFERTA1");
                    string sdata = "";
                    sdata = sdata + datosoferta.ZSD_OFERTA1_AUART.PadRight(4);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_VKORG.PadRight(4);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_VTWEG.PadRight(2);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_SPART.PadRight(2);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_KUNNR.PadRight(10);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_KUNNR2.PadRight(10);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_BSTKD.PadRight(35);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_BSTDK.PadRight(8);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_ANGDT.PadRight(8);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_BNDDT.PadRight(8);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_BNDDT2.PadRight(8);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_TDLINE.PadRight(132);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_XFELD.PadRight(1);
                    sdata = sdata + datosoferta.ZSD_OFERTA1_WERKS_D.PadRight(4);
                    tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SDATA", sdata);
                    tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("HLEVEL", "01");
                    //ZSD_OFERTA2
                    foreach (RegistroPosicionCrearOferta p in datosoferta.POSICIONES_OFERTA)
                    {
                        tabla_PT_IDOC_DATA_RECORDS_40.Append();
                        tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SEGNAM", "ZSD_OFERTA2");
                        string sdata2 = "";
                        sdata2 = sdata2 + p.ZSD_OFERTA2_POSNR_VA.PadRight(6);
                        sdata2 = sdata2 + p.ZSD_OFERTA2_MATNR.PadRight(18);
                        sdata2 = sdata2 + p.ZSD_OFERTA2_KWMENG.PadRight(17);
                        sdata2 = sdata2 + p.ZSD_OFERTA2_VRKME.PadRight(3);
                        sdata2 = sdata2 + p.ZSD_OFERTA2_WERKS_EXT;//.PadRight(4);
                        tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("SDATA", sdata2);
                        tabla_PT_IDOC_DATA_RECORDS_40.CurrentRow.SetValue("HLEVEL", "01");
                    }
                    BapiIDOC_INBOUND_SINGLE.Invoke(SapRfcDestination);
                    //var error = BapiIDOC_INBOUND_SINGLE.GetValue("PE_ERROR_PRIOR_TO_APPLICATION").ToString();
                    //var idoc = BapiIDOC_INBOUND_SINGLE.GetValue("PE_IDOC_NUMBER").ToString();
                    //VERIFICAR EL ESTATUS DE CARGA DEL IDOC, SE HACE CONSULTANDO EL ESTATUS DE LA OFERTA SAP CON EL PEDIDO WEB
                    consulta = ConsultarOfertaSap(datosoferta.ZSD_OFERTA1_BSTKD);
                    if (consulta.excode == 0 && consulta.statusOferta !=null)
                    {
                        oferta.statusOferta = consulta.statusOferta;
                        return oferta;
                    }
                    else
                    {
                        oferta.excode = -2;
                        oferta.exdetail = "No se pudo verificar la creación de la oferta en SAP";
                        return oferta;
                    }
                }
                else
                {
                    oferta.excode = -1;
                    oferta.exdetail = "El pedido suministrado ya se encuentra registrado en SAP";
                    return oferta;
                }                               
            }
            catch (Exception ex)
            {
                oferta = new RespuestaCrearOferta()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                return oferta;
            }
        }

        public RegistroFactura ConsultarFactura(string sPedido)
        {
            RegistroFactura factura = new RegistroFactura();
            try
            {
                IRfcFunction BapiZSD_FACTURA_WEB = SapRfcRepository.CreateFunction("ZSD_FACTURA_WEB");
                BapiZSD_FACTURA_WEB.SetValue("V_BSTNK", sPedido);
                BapiZSD_FACTURA_WEB.Invoke(SapRfcDestination);
                IRfcTable tabla_Z_FACTURA_K = BapiZSD_FACTURA_WEB.GetTable("Z_FACTURA_K");
                for (int FacturaPtr = 0; FacturaPtr < tabla_Z_FACTURA_K.RowCount; FacturaPtr++)                
                {
                    tabla_Z_FACTURA_K.CurrentIndex = FacturaPtr;
                    factura.FACTURA = tabla_Z_FACTURA_K.GetString("FACTURA");
                    factura.VKORG = tabla_Z_FACTURA_K.GetString("VKORG");
                    factura.VTWEG = tabla_Z_FACTURA_K.GetString("VTWEG");
                    factura.RIF = tabla_Z_FACTURA_K.GetString("RIF");
                    factura.NBE_AUTOMER = tabla_Z_FACTURA_K.GetString("NBE_AUTOMER");
                    factura.DIRECCION = tabla_Z_FACTURA_K.GetString("DIRECCION");
                    factura.TLF_AUTOMER = tabla_Z_FACTURA_K.GetString("TLF_AUTOMER");
                    factura.TIENDA = tabla_Z_FACTURA_K.GetString("TIENDA");
                    factura.DIREC_TIENDA = tabla_Z_FACTURA_K.GetString("DIREC_TIENDA");
                    factura.TLF_TIENDA = tabla_Z_FACTURA_K.GetString("TLF_TIENDA");
                    factura.WERKS = tabla_Z_FACTURA_K.GetString("WERKS");
                    factura.NBE_CLIENTE = tabla_Z_FACTURA_K.GetString("NBE_CLIENTE");
                    factura.DIREC_CLIENTE = tabla_Z_FACTURA_K.GetString("DIREC_CLIENTE");
                    factura.RIF_CLIENTE = tabla_Z_FACTURA_K.GetString("RIF_CLIENTE");
                    factura.TLF_CLIENTE = tabla_Z_FACTURA_K.GetString("TLF_CLIENTE");
                    factura.FECHA = tabla_Z_FACTURA_K.GetString("FECHA");
                    factura.MONEDA = tabla_Z_FACTURA_K.GetString("MONEDA");
                    factura.SUB_TOTAL = tabla_Z_FACTURA_K.GetString("SUB_TOTAL");
                    factura.EXENTO = tabla_Z_FACTURA_K.GetString("EXENTO");
                    factura.IVA_8 = tabla_Z_FACTURA_K.GetString("IVA_8");
                    factura.IVA_12 = tabla_Z_FACTURA_K.GetString("IVA_12");
                    factura.TOTAL = tabla_Z_FACTURA_K.GetString("TOTAL");
                    factura.COD_TRANSP = tabla_Z_FACTURA_K.GetString("COD_TRANSP");
                    factura.NBE_TRANSP = tabla_Z_FACTURA_K.GetString("NBE_TRANSP");
                    factura.POSICIONES_FACTURA = new List<PosicionesFactura>();
                    IRfcTable tabla_Z_FACTURA_P = BapiZSD_FACTURA_WEB.GetTable("Z_FACTURA_P");
                    factura.POSICIONES_FACTURA = new List<PosicionesFactura>();
                    for (int PosicionesPtr = 0; PosicionesPtr < tabla_Z_FACTURA_P.RowCount; PosicionesPtr++)
                    {
                        PosicionesFactura fila = new PosicionesFactura()
                        {
                            fila = tabla_Z_FACTURA_P.CurrentIndex = PosicionesPtr,
                            FACTURA = tabla_Z_FACTURA_P.GetString("FACTURA"),
                            POSNR = tabla_Z_FACTURA_P.GetString("POSNR"),
                            COD_ARTIC = tabla_Z_FACTURA_P.GetString("COD_ARTIC"),
                            ARTICULO = tabla_Z_FACTURA_P.GetString("ARTICULO"),
                            CANTIDAD = tabla_Z_FACTURA_P.GetString("CANTIDAD"),
                            UNIDAD_MEDIDA = tabla_Z_FACTURA_P.GetString("UNIDAD_MEDIDA"),
                            PRECIO = tabla_Z_FACTURA_P.GetString("PRECIO"),
                            ALICUOTA = tabla_Z_FACTURA_P.GetString("ALICUOTA"),
                            MONTO = tabla_Z_FACTURA_P.GetString("MONTO")
                        };
                        factura.POSICIONES_FACTURA.Add(fila);
                    }
                }
                return factura;
            }
            catch (Exception ex)
            {
                factura = new RegistroFactura()
                {
                    excode = ex.HResult,
                    exdetail = ex.Message
                };
                return factura;
            }
        }

        //public void Close()
        //{
        //    RfcDestinationManager.UnregisterDestinationConfiguration(con);
        //}

        public class SapParametros
        {
            public string Name { set; get; }
            public string User { set; get; }
            public string Password { set; get; }
            public string Client { set; get; }
            public string Language { set; get; }
            public string AppServerHost { set; get; }
            public string SystemNumber { set; get; }
            public string PoolSize { set; get; }
            public string ConnectionIdleTimeout { set; get; }
        }

        public class SapConnection : IDestinationConfiguration
        {
            public SapParametros parametros { set; get; }

            public SapConnection(SapParametros parametros)
            {
                this.parametros = parametros;
            }

            public RfcConfigParameters GetParameters(string NombreConexion)
            {
                RfcConfigParameters conf = new RfcConfigParameters();
                conf.Add(RfcConfigParameters.Name, parametros.Name);
                conf.Add(RfcConfigParameters.AppServerHost, parametros.AppServerHost);
                conf.Add(RfcConfigParameters.SystemNumber, parametros.SystemNumber);
                conf.Add(RfcConfigParameters.User, parametros.User);
                conf.Add(RfcConfigParameters.Password, parametros.Password);
                conf.Add(RfcConfigParameters.Client, parametros.Client);
                conf.Add(RfcConfigParameters.Language, parametros.Language);
                conf.Add(RfcConfigParameters.PoolSize, parametros.PoolSize);
                conf.Add(RfcConfigParameters.ConnectionIdleTimeout, parametros.ConnectionIdleTimeout);
                return conf;
            }

            public bool ChangeEventsSupported()
            {
                return true;
            }

            public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;
        }
    }
}
