using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cpermiso
    {
        int _id;
        string _descripcion;
        bool _usuariosPermisos;
        bool _proovedores;
        bool _cobrosPagos;
        bool _formaPago;
        bool _estadTableroControl;
        bool _clientes;
        bool _compras;
        bool _articulos;
        bool _config;
        bool _ctasCtes;

        public int ID
        {
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentException("Error en ID de cuenta corriente");
                }
            }
            get
            {
                return _id;
            }
        }
        public string Descripcion
        {
            set
            {
                if (value == "")
                
                    throw new Exception("La descripcion es un valor necesario");
                
                else
                    _descripcion = value;
            }
            get
            {
                return _descripcion;
            }
        }
        public bool USUARIOS_Y_PERMISOS
        {
            set
            {
                _usuariosPermisos = value;
            }
            get
            {
                return _usuariosPermisos;
            }
        }
        public bool PROVEEDORES
        {
            set
            {
                _proovedores = value;
            }
            get
            {
                return _proovedores;
            }
        }
        public bool COBROS_y_PAGOS
        {
            set
            {
                _cobrosPagos = value;
            }
            get
            {
                return _cobrosPagos;
            }
        }
        public bool FORMAS_DE_PAGO
        {
            set
            {
                _formaPago = value;
            }
            get
            {
                return _formaPago;
            }
        }
        public bool ESTADISTICAS_Y_TABLERO_CONTROL
        {
            set
            {
                _estadTableroControl = value;
            }
            get
            {
                return _estadTableroControl;
            }
        }
        public bool CLIENTES
        {
            set
            {
                _clientes = value;
            }
            get
            {
                return _clientes;
            }
        }
        public bool COMPRAS
        {
            set
            {
                _compras = value;
            }
            get
            {
                return _compras;
            }
        }
        public bool ARTICULOS
        {
            set
            {
                _articulos = value;
            }
            get
            {
                return _articulos;
            }
        }
        public bool CONFIGURACIONES
        {
            set
            {
                _config = value;
            }
            get
            {
                return _config;
            }
        }
        public bool CTAS_CTES
        {
            set
            {
                _ctasCtes = value;
            }
            get
            {
                return _ctasCtes;
            }
        }

        public Cpermiso(string descripcion,bool user,bool proveed,bool cobrosPagos,bool Fpago,bool EstadTablero,bool client,bool compras, bool art,bool config,bool ctaCte)
        {
            Descripcion = descripcion;
            USUARIOS_Y_PERMISOS = user;
            PROVEEDORES = proveed;
            COBROS_y_PAGOS = cobrosPagos;
            FORMAS_DE_PAGO = Fpago;
            ESTADISTICAS_Y_TABLERO_CONTROL = EstadTablero;
            CLIENTES = client;
            COMPRAS = compras;
            ARTICULOS = art;
            CONFIGURACIONES = config;
            CTAS_CTES = ctaCte;
        }

        public Cpermiso(int id, string descr,bool user, bool proveed, bool cobrosPagos, bool Fpago, bool EstadTablero, bool client, bool compras, bool art, bool config, bool ctaCte)
        {
            Descripcion = descr;
            ID = id;
            USUARIOS_Y_PERMISOS = user;
            PROVEEDORES = proveed;
            COBROS_y_PAGOS = cobrosPagos;
            FORMAS_DE_PAGO = Fpago;
            ESTADISTICAS_Y_TABLERO_CONTROL = EstadTablero;
            CLIENTES = client;
            COMPRAS = compras;
            ARTICULOS = art;
            CONFIGURACIONES = config;
            CTAS_CTES = ctaCte;
        }
    }
}
