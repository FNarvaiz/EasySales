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
       
        
    }
}
