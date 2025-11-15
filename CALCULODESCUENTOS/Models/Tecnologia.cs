using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULODESCUENTOS.Models
{
    // Tecnología con descuento ejemplo
    public class Tecnologia : Producto
    {
        public Tecnologia(decimal precio) : base(precio) { }

        public override decimal CalcularPrecioFinal()
        {
            // 10% de descuento ejemplo
            return Precio * 0.9m;
        }
    }
}
