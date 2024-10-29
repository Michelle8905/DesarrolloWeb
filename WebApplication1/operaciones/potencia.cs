using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.operaciones
{
    public class potencia
    {
        private int a;
        private int b;
        private  int resultado ;
        public potencia(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int getPotencia()
        {
            resultado = 1;
            int i;
            for (i = 1; i <= b; i++)
            {
                resultado = resultado * a;
            }
            return resultado; 
        }
    }
}