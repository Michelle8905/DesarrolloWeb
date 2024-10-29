using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.operaciones
{
    
    
        public class restas
        {
            private int a;
            private int b;

            public restas(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public int getResta()
            {
                return a - b;
            }

        }
    }
