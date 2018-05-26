using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejemplo
    {
        private int x, y;

        public Ejemplo(int a,int b)
        {
            this.x = a;
            this.y = b;
        }

        public bool metodo(int m,int n)
        {
            if (m == n) return true;
            return false;
        }
    }
}
