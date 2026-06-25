using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaTaquillaCine
{
    public abstract class Boleto
    {
        protected decimal precioBase;

        public decimal PrecioBase
        {
            get { return precioBase; }
            set
            {
                if (value > 0)
                {
                    precioBase = value;
                }
                else
                {
                    precioBase = -1;
                }
            }
        }
        public Boleto(decimal _precioBase)
        {
            precioBase = _precioBase;
        }

        public abstract decimal CalcularPrecioFinal();
    }
}
