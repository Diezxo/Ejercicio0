using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    class Producto
    {
        private string? nombre;
        private float precio;
        public Producto(string? _nombre, float _precio)
        {
            nombre = _nombre;
            precio = _precio;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public string? getNombre()
        {
            return nombre;
        }
    }
}
