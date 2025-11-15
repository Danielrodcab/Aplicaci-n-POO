using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULODESCUENTOS.Models
{
    // Clase base
    public class Producto
    {
        public decimal Precio { get; set; }

        public Producto(decimal precio)
        {
            Precio = precio;
        }

        public virtual decimal CalcularPrecioFinal()
        {
            return Precio; // Sin descuento
        }
    }
}