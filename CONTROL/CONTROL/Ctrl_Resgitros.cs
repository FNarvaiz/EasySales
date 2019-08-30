using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
namespace CONTROL
{
    public class Ctrl_Resgitros
    {
        int total=0;
        static Ctrl_Resgitros Control;
        public static Ctrl_Resgitros ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_Resgitros();
            }
            return Control;
        }
         private int ValorMes()
        {
            DateTime hoy = DateTime.Today;
            char letra = 'o';
            if (hoy.Month < 7)
            {
                if (hoy.Month < 4)
                {
                    if (hoy.Month < 3)
                    {
                        if (hoy.Month == 1)
                            letra = 'A';
                        else
                            letra = 'J';
                    }
                    else
                        letra = 'X';
                }
                else
                {
                    if (hoy.Month < 6)
                    {
                        if (hoy.Month == 4)
                            letra = 'N';
                        else
                            letra = 'K';
                    }
                    else
                        letra = 'O';
                }
            }
            else
            {
                if (hoy.Month < 10)
                {
                    if (hoy.Month < 9)
                    {
                        if (hoy.Month == 7)
                            letra = 'L';
                        else
                            letra = 'V';
                    }
                    else
                        letra = 'Z';
                }
                else
                {
                    if (hoy.Month < 12)
                    {
                        if (hoy.Month == 10)
                            letra = 'M';
                        else
                            letra = 'I';
                    }
                    else
                        letra = 'R';
                }
            }
            Byte valorbyte = Convert.ToByte(letra);
            return Convert.ToInt32(valorbyte);
        }
         private int ValorAño()
        {
            DateTime hoy = DateTime.Today;
            char letra = 'O';
            if (hoy.Year == 2013)
                letra = 'Q';
            else if (hoy.Year == 2014)
                letra = 'L';
            else if (hoy.Year == 2012)
                letra = 'M';
            else if (hoy.Year == 2015)
                letra = 'A';
            Byte valorbyte = Convert.ToByte(letra);
            return Convert.ToInt32(valorbyte);
        }
         private bool ClaveDelMesActual(int valor)
        {
            foreach (Cregistro aux in Cdatos_registros.Devolver(Ctrl_configuraciones.Devolver()))
            {
                if (aux.Fecha.Month == DateTime.Today.Month && aux.Fecha.Year == DateTime.Today.Year)
                {
                    Byte[] codigos = System.Text.ASCIIEncoding.ASCII.GetBytes(aux.Clave);
                    int valorClaveRegistrada = 0;
                    foreach (byte AUX in codigos)
                    {
                        valorClaveRegistrada += Convert.ToInt32(AUX);
                    }
                    if (valorClaveRegistrada == valor)
                        return true;
                }
            }
            return false;
        }
         public int ClaveCorrecta(string ClaveActual)
        {
            if (Ctrl_configuraciones.FechaCorrecta())
            {
                int valorclave = 0;
                Byte[] codigos = System.Text.ASCIIEncoding.ASCII.GetBytes(ClaveActual);
                foreach (byte AUX in codigos)
                {
                    valorclave += Convert.ToInt32(AUX);
                }
                if (ClaveDelMesActual(valorclave))
                    return 0;
                else
                {
                    if (total == 0)
                    {
                        codigos = System.Text.ASCIIEncoding.ASCII.GetBytes(Ctrl_configuraciones.Devolver().HostName);
                        //codigos = System.Text.ASCIIEncoding.ASCII.GetBytes("Gerencia");
                        int valorHostName = 0;
                        foreach (byte AUX in codigos)
                        {
                            valorHostName += Convert.ToInt32(AUX);
                        }

                        total = ValorMes() + ValorAño() + valorHostName;
                    }
                    if (total < valorclave)
                    {
                        if (total + 400 == valorclave)
                        {
                            return 1;
                        }
                        else if (total + 800 == valorclave)
                        {
                            return 2;
                        }
                        else if (total + 1200 == valorclave)
                        {
                            return 3;
                        }
                    }
                }
            }
            else
            {
                throw new Exception("La fecha de su computadora es incorrecta.\n Por favor corrijala y vuelva a intentarlo.");
            }
            return 0;
        }
         public int ClaveActualCorrecta()
         {
             int valorclave = 0;
             Byte[] codigos = System.Text.ASCIIEncoding.ASCII.GetBytes(Cdatos_registros.Devolver(Ctrl_configuraciones.Devolver())[0].Clave);
             foreach (byte AUX in codigos)
             {
                 valorclave += Convert.ToInt32(AUX);
             }
             if (total == 0)
             {
                 codigos = System.Text.ASCIIEncoding.ASCII.GetBytes(Ctrl_configuraciones.Devolver().HostName);
                 int valorHostName = 0;
                 foreach (byte AUX in codigos)
                 {
                     valorHostName += Convert.ToInt32(AUX);
                 }
                 total = ValorMes() + ValorAño() + valorHostName;
             }
             if (total + 400 == valorclave)
             {
                 return 1;
             }
             else if (total + 800 == valorclave)
             {
                 return 2;
             }
             else if (total + 1200 == valorclave)
             {
                 return 3;
             }
             return 0;
         }
         public void Agregar(Cregistro obj)
         {
             try
             {
                 Cdatos_registros.Agregar(obj, Ctrl_configuraciones.Devolver());
             }
             catch(Exception ex)
             {
                 throw new Exception(ex.Message);
             }
         }
    }
}
