using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.operaciones
{
    public class sumatoria
    {
        private int a;
        private int b;

        public sumatoria(int a, int b) { 
        this.a = a;
        this.b = b;
        }

        public int getSuma() {
            return a + b;
        }

    }
}