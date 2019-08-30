using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_cuentas_corrientes
    {
        public int ultimo;
        int ultimoCredito;
        int ultimoDebito;
        private static Ctrl_cuentas_corrientes Control;

        public static Ctrl_cuentas_corrientes ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_cuentas_corrientes();
                Control.CargarUltimo();
            }
            return Control;
        }
        // CARGAR DE BD
        public void CargarUltimo()
        {
            if (ultimo == 0)
                ultimo = Cdatos_cuentas_corrientes.DevolverUltimo();
        }
        public void CargarAltasDebitosyCreditos(Ccuenta_corriente obj)
        {
            if (obj.Creditos == null)
            {
                decimal saldoActual = obj.Saldo;
                obj.Saldo = 0;
                DataTable DT = Cdatos_operaciones.DevolverDebitos(obj, true);
                obj.Debitos = new List<Crecibo_debito>();
                Crecibo_debito oDebito;
                foreach (DataRow DR in DT.Rows)
                {
                    oDebito = new Crecibo_debito(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToDecimal(DR[2]), Convert.ToDateTime(DR[3]), true);
                    obj.AgregarDebito(oDebito);
                    if (DR[4].ToString() != "")
                        oDebito.Compra(new Ccompra(Convert.ToInt32(DR[4]), Convert.ToDecimal(DR[5]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]), Convert.ToDateTime(DR[8])));
                }
                DT = Cdatos_operaciones.DevolverCreditos(obj, true);
                obj.Creditos = new List<Cpago_credito>();
                Cpago_credito oCredito=null;
                int index = 0;
                Cpago oPago;
                Ctrl_formas_pagos adm = Ctrl_formas_pagos.ClaseActiva();
                foreach (DataRow DR in DT.Rows)
                {
                    if (index == 0 )
                    {
                        oCredito = new Cpago_credito(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToDecimal(DR[2]), Convert.ToDateTime(DR[3]), true);
                        //obj.Creditos.Insert(index, oCredito);
                        obj.AgregarCredito(oCredito);
                        index++;
                        if (DR[4].ToString() != "")
                        {
                            oPago = new Cpago(adm.BuscarPorID(Convert.ToInt32(DR[11])), Convert.ToDecimal(DR[8]), DR[9].ToString(), Convert.ToDecimal(DR[10]));
                            oCredito.Venta(new Cventa(Convert.ToInt32(DR[4]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]), Convert.ToDecimal(DR[6])- Convert.ToDecimal(DR[7]), oPago));
                            oCredito.ID_Caja_Diaria(Convert.ToInt32(DR[5]));
                        }
                    }
                    else
                    {
                        if (obj.Creditos[index - 1].Numero != Convert.ToInt32(DR[0]))
                        {
                            oCredito = new Cpago_credito(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToDecimal(DR[2]), Convert.ToDateTime(DR[3]), true);
                            //obj.Creditos.Insert(index, oCredito);
                            obj.AgregarCredito(oCredito);
                            index++;
                            if (DR[4].ToString() != "")
                            {
                                oPago = new Cpago(adm.BuscarPorID(Convert.ToInt32(DR[11])), Convert.ToDecimal(DR[8]), DR[9].ToString(), Convert.ToDecimal(DR[10]));
                                oCredito.Venta(new Cventa(Convert.ToInt32(DR[4]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]), Convert.ToDecimal(DR[6]) - Convert.ToDecimal(DR[7]), oPago));
                                oCredito.ID_Caja_Diaria(Convert.ToInt32(DR[5]));
                            }
                        }
                        else
                        {
                            oPago = new Cpago(adm.BuscarPorID(Convert.ToInt32(DR[11])), Convert.ToDecimal(DR[8]), DR[9].ToString(), Convert.ToDecimal(DR[10]));
                            oCredito.Venta().Pago2 = oPago;
                        }
                    }
                }
                if (saldoActual != obj.Saldo)
                    Modificar(obj);
            }
        }
        public void CargarCreditosdeDebitos(Ccuenta_corriente obj)
        {
            DataTable tabla;
            foreach (Crecibo_debito aux in obj.Debitos)
            {
                tabla = Cdatos_operaciones.DevolverCreditosDeDebitos(aux);
                if (tabla.Rows.Count > 0 && aux.Creditos()==null)
                {
                    aux.InstanciaCreditos();
                    foreach (DataRow DR in tabla.Rows)
                        aux.AgregarCreditos(obj.BuscarCredito(Convert.ToInt32(DR[0])));
                }
            }
        }
        public void CargarRecibosDePagos(Ccuenta_corriente obj)
        {
            DataTable tabla;
            foreach (Cpago_credito aux in obj.Creditos)
            {
                tabla = Cdatos_operaciones.DevolverRebibosDePagos(aux);
                if (tabla.Rows.Count > 0 && aux.Recibos()==null)
                {
                    aux.InstanciaRecibos();
                    foreach (DataRow DR in tabla.Rows)
                        aux.AgregarRecibo(obj.BuscarDebito(Convert.ToInt32(DR[0])));
                }
            }
        }
        public void CargarBajasDebitosyCreditos(Ccuenta_corriente obj)
        {
            DataTable DT = Cdatos_operaciones.DevolverDebitos(obj, false);
            int index = 0;
            Crecibo_debito oDebito;
            foreach (DataRow DR in DT.Rows)
            {
                oDebito = new Crecibo_debito(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToDecimal(DR[2]), Convert.ToDateTime(DR[3]), false);
                obj.Debitos.Insert(index, oDebito);
                index++;
                if (DR[4].ToString() != "")
                {
                    oDebito.Compra(new Ccompra(Convert.ToInt32(DR[4]), Convert.ToDecimal(DR[5]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]), Convert.ToDateTime(DR[8])));
                }
            }
            DT = Cdatos_operaciones.DevolverCreditos(obj, false);
            index = 0;
            Cpago_credito oCredito=null;
            Cpago oPago;
            Ctrl_formas_pagos adm= Ctrl_formas_pagos.ClaseActiva();
            foreach (DataRow DR in DT.Rows)
            {
                if(index==0 || obj.Creditos[index].Numero!=Convert.ToInt32(DR[0])){
                    oCredito = new Cpago_credito(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToDecimal(DR[2]), Convert.ToDateTime(DR[3]), false);
                    obj.Creditos.Insert(index, oCredito);
                    index++;
                    if (DR[4].ToString() != "")
                    {
                        oPago= new Cpago(adm.BuscarPorID(Convert.ToInt32(DR[11])),Convert.ToDecimal(DR[8]),DR[9].ToString(),Convert.ToDecimal(DR[10]));
                        oCredito.Venta(new Cventa(Convert.ToInt32(DR[4]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]),oPago));
                        oCredito.ID_Caja_Diaria(Convert.ToInt32(DR[5]));
                    }
                }
                else{
                    oPago= new Cpago(adm.BuscarPorID(Convert.ToInt32(DR[11])),Convert.ToDecimal(DR[8]),DR[9].ToString(),Convert.ToDecimal(DR[10]));
                    oCredito.Venta().Pago2=oPago;
                }


            }
        }
        public Cproveedor BuscarProveedor(Cgasto obj){
            int id_cuenta = Cdatos_operaciones.BuscarCuentayCargarCredito(obj);
            Ctrl_proveedores adm= Ctrl_proveedores.ClaseActiva();
            foreach(Cproveedor oproveedor in adm.VerLista()){
                if(oproveedor.DevolverCuentaCorriente().ID==id_cuenta){
                    CargarAltasDebitosyCreditos(oproveedor.DevolverCuentaCorriente());
                    return oproveedor;
                }
            }
            return null;
        }
        public Cpersona BuscarClienteUsuario(Ccobro obj)
        {
            int id_cuenta = Cdatos_operaciones.BuscarCuentayCargarDebito(obj);
            foreach (Cpersona opersona in DevolverClienteUsuarios())
            {
                if (opersona.DevolverCuentaCorriente().ID == id_cuenta)
                {
                    CargarAltasDebitosyCreditos(opersona.DevolverCuentaCorriente());
                    return opersona;
                }
            }
            return null;
        }

        // METODOS EN MEMORIA
        public List<Cpersona> DevolverClienteUsuarios()
        {
            List<Cpersona> lista = new List<Cpersona>();
            Ctrl_usuarios admusu = Ctrl_usuarios.ClaseActiva();
            foreach (Cpersona aux in admusu.VerLista())
            {
                lista.Add(aux);
            }
            Ctrl_clientes admclientes = Ctrl_clientes.ClaseActiva();
            foreach (Cpersona aux in admclientes.VerLista())
            {
                lista.Add(aux);
            }
            return lista;
        }
        public bool TieneCreditosODebitos(Ccuenta_corriente obj)
        {
            CargarAltasDebitosyCreditos(obj);
            if (obj.Creditos.Count > 0)
                return true;
            if (obj.Debitos.Count > 0)
                return true;
            CargarBajasDebitosyCreditos(obj);
            if (obj.Creditos.Count > 0)
                return true;
            if (obj.Debitos.Count > 0)
                return true;
            return false;
        }
        public void SacarBajas(Ccuenta_corriente obj)
        {
            Cpago_credito objCred;
            int cont = 0;
            while (cont < obj.Creditos.Count)
            {
                objCred = obj.Creditos[cont];
                if (objCred.Alta)
                    cont++;
                else
                    obj.Creditos.Remove(objCred);
            }
            cont = 0;
            Crecibo_debito objDeb;
            while (cont < obj.Debitos.Count)
            {
                objDeb = obj.Debitos[cont];
                if (objDeb.AltaOp())
                    cont++;
                else
                    obj.Debitos.Remove(objDeb);
            }
        }
        public Crecibo_debito BuscarDeCompra(Ccuenta_corriente obj, Ccompra ocompra)
        {
            CargarAltasDebitosyCreditos(obj);
            foreach (Crecibo_debito aux in obj.Debitos)
            {
                if (aux.Compra() != null)
                {
                    if (aux.Compra().Id == ocompra.Id)
                        return aux;
                }
            }
            CargarBajasDebitosyCreditos(obj);
            foreach (Crecibo_debito aux in obj.Debitos)
            {
                if (aux.Compra() != null)
                {
                    if (aux.Compra().Id == ocompra.Id)
                        return aux;
                }
            }
            SacarBajas(obj);
            return null;
        }

        // METODOS ABM
        public void Agregar(Ccuenta_corriente obj, Cpersona objpersona)
        {
            try
            {
                ultimo++;
                obj.ID = ultimo;
                Cdatos_cuentas_corrientes.Agregar(obj,objpersona);
                objpersona.AgregarCuentaCorriente(obj);
            }
            catch
            {
                Agregar(obj, objpersona);
            }
        }   
        public void Modificar(Ccuenta_corriente obj)
        {
            Cdatos_cuentas_corrientes.Modificar(obj);
        }
        public void AgregarOperacion(Cpago_credito objcredito, Ccuenta_corriente objcuenta)
        {
            if (ultimoCredito == 0)
            {
                ultimoCredito = Cdatos_operaciones.DevolverUltimo("[PAGOS_CREDITOS]");
            }
            try
            {
                ultimoCredito++;
                objcredito.Numero = ultimoCredito;
                Cdatos_operaciones.Agregar("[PAGOS_CREDITOS]", objcredito, objcuenta,objcredito.Concepto);
                objcuenta.AgregarCredito(objcredito);
                Cdatos_cuentas_corrientes.Modificar(objcuenta);
            }
            catch
            {
                AgregarOperacion(objcredito, objcuenta);
            }
        }
        public void AgregarOperacion(Crecibo_debito objDebito, Ccuenta_corriente objcuenta)
        {
            if (ultimoDebito == 0)
                {
                    ultimoDebito = Cdatos_operaciones.DevolverUltimo("[RECIBOS_DEBITOS]");
                }
            try
            {
                ultimoDebito++;
                objDebito.Numero = ultimoDebito;
                Cdatos_operaciones.Agregar("[RECIBOS_DEBITOS]", objDebito, objcuenta,objDebito.Concepto);
                objcuenta.AgregarDebito(objDebito);
                Cdatos_cuentas_corrientes.Modificar(objcuenta);
            }
            catch
            {
                AgregarOperacion(objDebito,objcuenta);
            }
        }
        public void AgregarReferiaEntreOperacion(Cpago_credito objCredito, Crecibo_debito objDebito)
        {
            Cdatos_operaciones.AgregarRelacion(objCredito, objDebito);
        }
        public void AgregarReferiaEntreOperacion(Crecibo_debito objdebito, Ccobro objcobro)
        {
            Cdatos_operaciones.AgregarRelacion(objdebito, objcobro);
        }
        public void AgregarReferiaEntreOperacion(Cpago_credito objcredito, Cgasto objgasto)
        {
            Cdatos_operaciones.AgregarRelacion(objcredito, objgasto);
        }
        public void AgregarReferiaEntreOperacion(Cpago_credito objcredito,Cventa objventa,Ccaja_diaria caja)
        {
            objcredito.Venta(objventa);
            Cdatos_operaciones.AgregarRelacion(objcredito, objventa,caja.ID);
        }
        public void AgregarReferiaEntreOperacion(Crecibo_debito objdebito, Ccompra objcompra)
        {
            Cdatos_operaciones.AgregarRelacion(objdebito, objcompra);
        }
        public void ModificarOperacion(Cpago_credito objcredito)
        {
            Cdatos_operaciones.Modificar("[PAGOS_CREDITOS]", objcredito,true,objcredito.Concepto);
        }
        public void ModificarOperacion(Crecibo_debito objdebito)
        {
            Cdatos_operaciones.Modificar("[RECIBOS_DEBITOS]", objdebito,true,objdebito.Concepto);
        }
        public void DarBajaoAlta(Cpago_credito obj, Ccuenta_corriente objcuenta,bool alta)
        {
            Cdatos_operaciones.Modificar("[PAGOS_CREDITOS]", obj, alta,obj.Concepto);
            if (alta)
            {
                objcuenta.Creditos.Remove(obj);
                obj.Alta = alta;
                objcuenta.AgregarCredito(obj);
            }
            else
                objcuenta.EliminarCredito(obj);
        }
        public void DarBajaoAlta(Crecibo_debito obj,Ccuenta_corriente objcuenta,bool alta)
        {
            Cdatos_operaciones.Modificar("[RECIBOS_DEBITOS]", obj, alta,obj.Concepto);
            
            if (alta)
            {
                objcuenta.Debitos.Remove(obj);
                obj.Alta = alta;
                objcuenta.AgregarDebito(obj);
            }
            else
                objcuenta.EliminarDebito(obj);
        }
        public void DarTodasDeBaja(Ccuenta_corriente obj)
        {
            Cdatos_operaciones.DarDeBajas(obj);
            obj.Creditos.Clear();
            obj.Debitos.Clear();
            obj.Saldo = 0;
        }
        public void EliminarRefOperacion(Coperacion obj,string tabla){
            Cdatos_operaciones.EliminarReferenciaDe(tabla,obj);
        }
        public Ccuenta_corriente EliminarOperacion(Crecibo_debito obj, bool tienecobro,Ccuenta_corriente cuenta)
        {
            Cdatos_operaciones.EliminarReferenciaDebitosCreditos("Debito", obj);
            if (tienecobro)
                EliminarRefOperacion(obj, "[COBROS-RECIBOS]");
            Cdatos_operaciones.Eliminar("[RECIBOS_DEBITOS]", obj);
            cuenta.EliminarDebito(obj);
            return cuenta;
        }
        public Ccuenta_corriente EliminarOperacion(Cpago_credito obj, bool tienepago,Ccuenta_corriente cuenta)
        {
            Cdatos_operaciones.EliminarReferenciaDebitosCreditos("Credito", obj);
            if (tienepago)
                EliminarRefOperacion(obj, "[GASTOS-PAGOS]");
            Cdatos_operaciones.Eliminar("[PAGOS_CREDITOS]", obj);
            cuenta.EliminarCredito(obj);
            return cuenta;
        }
        public void EliminarOperacionesDe(Ccuenta_corriente obj)
        {
            if (obj.Debitos != null)
            {
                foreach (Crecibo_debito debito in obj.Debitos)
                   EliminarRefOperacion(debito,"[COBROS-RECIBOS]");
                Cdatos_operaciones.Eliminar("[RECIBOS_DEBITOS]", obj);
            }
            if (obj.Creditos != null)
            {
                foreach (Cpago_credito credito in obj.Creditos)
                    EliminarRefOperacion(credito, "[GASTOS-PAGOS]");
                Cdatos_operaciones.Eliminar("[PAGOS_CREDITOS]", obj);
            }
        }
        public void Eliminar(Ccuenta_corriente obj)
        {
            Cdatos_cuentas_corrientes.Eliminar(obj);
        }
        //COMPROBACIONES EN BD
        public bool TieneCobro(Crecibo_debito obj)
        {
            return Cdatos_operaciones.TieneCobro(obj);
        }
        public bool TieneGasto(Cpago_credito obj)
        {
            return Cdatos_operaciones.TieneGasto(obj);
        }

        public void ActualizarInflacionDeCreditos(Ccuenta_corriente ocuenta) {
            foreach (Cpago_credito ocredito in ocuenta.Creditos)
            {
                Cventa oVenta = ocredito.Venta();
                if (oVenta != null)
                {
                    if (oVenta.Items().Count == 0)
                    {
                        Ctrl_Ventas admventa = Ctrl_Ventas.ClaseActiva();
                        admventa.CargarItems(oVenta, ocredito.ID_Caja_Diaria());
                    }
                    decimal TotalInflado = 0;
                    foreach (Citem item in oVenta.Items())
                    {
                        TotalInflado += item.Articulo.Precio * item.Cantidad;
                    }
                    
                    decimal ImporteNuevoCredito;
                    if (oVenta.Pago2 != null)
                    {
                        decimal importeAcuenta;
                        if (oVenta.Pago.FormaPago.ID == 2)
                            importeAcuenta = oVenta.Pago.Importe;
                        else
                            importeAcuenta = oVenta.Pago2.Importe;
                        ImporteNuevoCredito = (importeAcuenta / oVenta.Total) * TotalInflado;
                    }
                    else
                        ImporteNuevoCredito = TotalInflado;
                    ImporteNuevoCredito = Math.Round(ImporteNuevoCredito, 2, MidpointRounding.AwayFromZero);
                    if (ImporteNuevoCredito != ocredito.Importe)
                    {
                        ocuenta.ModificarCredito(ocredito, ImporteNuevoCredito);
                        ModificarOperacion(ocredito);
                    }
                }
            }
        }
        
    }
}
