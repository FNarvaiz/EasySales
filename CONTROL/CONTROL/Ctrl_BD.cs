using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_DATOS;
namespace CONTROL
{
    public class Ctrl_BD
    {
        public Ctrl_BD (string connectionString)
        {
            cDatos.StartConnection(connectionString);
        }
        public bool ExisteBD(){
            try
            {
                return cDatos.ExisteBD();
            }
            catch
            {
                throw new Exception();
            }
        }
        public void CrearBD()
        {
            try
            {
                cDatos.CrearBD();
            }
            catch
            {
                throw new Exception();
            }
        }
        public void CrearTablas()
        {
            try
            {
                cDatos.CrearTablas();
            }
            catch
            {
                throw new Exception();
            }
        }
        public bool ExisteInstancia()
        {
            try
            {
                return cDatos.ExisteInstancia();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
