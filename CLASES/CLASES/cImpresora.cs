using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.PointOfService;
namespace CLASES
{
    public class cImpresora
    {
        static cImpresora _oImpresora;
        string _nombreLogico;
        PosPrinter _oPrinter = null;
        static public cImpresora ImpresoraActiva(string nombreLogico)
        {
            if (_oImpresora == null)
            {
                _oImpresora= new cImpresora(nombreLogico);
            }
            return _oImpresora;
        }
        public cImpresora(string nombreLogico)
        {
            try
            {

                _nombreLogico = nombreLogico;
                PosExplorer posExplorer = new PosExplorer();
                DeviceInfo deviceInfo = null;
                deviceInfo = posExplorer.GetDevice(DeviceType.PosPrinter, _nombreLogico);
                _oPrinter = (PosPrinter)posExplorer.CreateInstance(deviceInfo);
                _oPrinter.Open();
                _oPrinter.Claim(1000);
                _oPrinter.DeviceEnabled = true;
                //Output by the high quality mode
                _oPrinter.RecLetterQuality = true;

                // Even if using any printers, 0.01mm unit makes it possible to print neatly.
                _oPrinter.MapMode = MapMode.Metric;

            }
            catch (PosControlException ex)
            {
                throw new Exception("Error al abrir la impresora fiscal. " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la impresora fiscal. " + ex.Message);
            }
        }

        public void ImprimirVenta(Cventa oVenta, Ccaja_diaria oCaja)
        {
            try
            {
                string strDate = DateTime.Now.ToString("dd/MM/yyyy  HH:mm");
                if (_oPrinter.CapRecPresent == true)
                {
                    _oPrinter.TransactionPrint(PrinterStation.Receipt, PrinterTransactionControl.Transaction);
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "X\n");
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Documento no valido como factura\n");
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "Caja:" + oCaja.ID + " " + oVenta.ID);
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + strDate + "\n");
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");
                    foreach (Citem oItem in oVenta.Items())
                    {
                        _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + oItem.Cantidad + " " + oItem.Articulo.Descripcion);
                        _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "$" + oItem.Total + "\n");
                    }
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");
                    if (oVenta.DescRecargo != 0)
                    {
                        _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "Subtotal:");
                        _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "$" + oVenta.Subtotal + "\n");
                        if (oVenta.DescRecargo > 0)
                            _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "Recargo:");
                        else
                            _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "Descuento:");
                        _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "$" + oVenta.DescRecargo + "\n");

                    }
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "Total:");
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|rA" + "$" + oVenta.Total + "\n");
                    _oPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|3000uF");
                    if (_oPrinter.CapRecPaperCut == true)
                    {
                        _oPrinter.CutPaper(100);
                    }
                    _oPrinter.TransactionPrint(PrinterStation.Receipt, PrinterTransactionControl.Normal);
                }
            }
            catch (PosControlException ex)
            {
                throw new Exception("Error al imprimir una venta." + ex.Message);
            }
        }
        public void Cerrar()
        {
            _oPrinter.Close();
        }
    }
}
