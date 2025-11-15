using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULODESCUENTOS.Models
{
    // Alimento con descuento ejemplo
    public class Alimento : Producto
    {
        public Alimento(decimal precio) : base(precio) { }

        public override decimal CalcularPrecioFinal()
        {
            // 5% de descuento ejemplo
            return Precio * 0.95m;
        }
    }
}
