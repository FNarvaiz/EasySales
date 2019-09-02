using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cconfiguracion
    {

        int _id; 
        bool _multiusuario;
        bool _multicaja;
        bool _perdirPass;
        bool _PorVenta;
        bool _Facturacion;
        bool _EpsonSamsung;
        int _Puerto;
        int _Modelo;
        bool _Comisiones;
        bool _OrdenPrioridad;
        bool _DescuentoFormaDePago;
        bool _ExistenciaPorCompras;
        int _Version;
        string _HostName;
        decimal _IVA;
        string _nombre_logico;
        public string connectionString { get; set; }
        public string backupDirectory { get; set; }
        public int Version//Free =0 basic=1 pro=2 premium=3
        {
            set
            {
                _Version=value;
            }
            get
            {
                return _Version;
            }
        }
        public string HostName
        {
            set
            {
                _HostName = value;
            }
            get
            {
                return _HostName;
            }
        }
        public int Puerto
        {
            set
            {
                _Puerto = value;
            }
            get
            {
                return _Puerto;
            }
        }
        public int Modelo
        {
            set
            {
                _Modelo = value;
            }
            get
            {
                return _Modelo;
            }
        }
        public bool ExistenciaPorCompras
        {
            set
            {
                _ExistenciaPorCompras = value;
            }
            get
            {
                return _ExistenciaPorCompras;
            }
        }
        public bool DescuentoFormaPago
        {
            set
            {
                _DescuentoFormaDePago = value;
            }
            get
            {
                return _DescuentoFormaDePago;
            }
        }
        public bool OrdenPrioridad
        {
            set
            {
                _OrdenPrioridad = value;
            }
            get
            {
                return _OrdenPrioridad;
            }
        }
        decimal _PorcComision;
        public bool Facturacion
        {
            set
            {
                _Facturacion = value;
            }
            get
            {
                return _Facturacion;
            }
        }
        public bool Epson_Samsung
        {
            set
            {
                _EpsonSamsung = value;
            }
            get
            {
                return _EpsonSamsung;
            }
        }
        public bool PorVenta
        {
            set
            {
                _PorVenta = value;
            }
            get
            {
                return _PorVenta;
            }
        }
        public bool PedirPass
        {
            set
            {
                _perdirPass = value;
            }
            get
            {
                return _perdirPass;
            }
        }
        public bool MultiCaja
        {
            set
            {
                _multicaja = value;
            }
            get
            {
                return _multicaja;
            }
        }
        public bool MultiUsuario
        {
            set
            {
                _multiusuario = value;
            }
            get
            {
                return _multiusuario;
            }
        }
        public int ID
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public bool PorComisiones
        {
            set
            {
                _Comisiones = value;
            }
            get
            {
                return _Comisiones;
            }
        }
        public decimal PorcComision
        {
            set
            {
                _PorcComision = value;
            }
            get
            {
                return _PorcComision;
            }
        }
        public decimal IVA
        {
            set
            {
                _IVA = value;
            }
            get
            {
                return _IVA;
            }
        }
        public string NombreLogico
        {
            set
            {
                _nombre_logico = value;
            }
            get
            {
                return _nombre_logico;
            }
        }
        public Cconfiguracion(int id, bool multiusuario, bool multicaja, bool pedirpass, bool porventa, bool factura, bool Epsonsamsung, bool Comisiones, decimal porcComisiones, bool porprioridad, bool descuentoformapago, bool existenciaporcompras, int puerto, int modelo,decimal iva, string hostname,int version,string nombreLogico)
        {
            _EpsonSamsung = Epsonsamsung;
            Facturacion = factura;
            MultiCaja = multicaja;
            MultiUsuario = multiusuario;
            PedirPass = pedirpass;
            PorVenta = porventa;
            PorComisiones = Comisiones;
            PorcComision = porcComisiones;
            ExistenciaPorCompras = existenciaporcompras;
            OrdenPrioridad = porprioridad;
            DescuentoFormaPago = descuentoformapago;
            Puerto=puerto;
            Modelo = modelo;
            IVA = iva;
            HostName = hostname;
            Version = version;
            NombreLogico = nombreLogico;

        }
    }
}
