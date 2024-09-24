using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Entities;

namespace TestConsole.Service
{

    public class ProductoService
    {
        private readonly List<Producto> _producto = new List<Producto>();


        public string AgregarProducto(Producto producto)
        {
            _producto.Add(producto);

            return "Producto agregado";
        }

        public Producto ObtenerProductoMasCaro()
        {
            try
            {
                if (!_producto.Any())
                {
                    throw new InvalidOperationException();
                }
                return _producto.OrderByDescending(p => p.Precio).FirstOrDefault();
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
        }

        public decimal calcularPrecioPromedio()
        {
            try
            {
                if (!_producto.Any())
                {
                    throw new InvalidOperationException();
                }
                return _producto.Average(p => p.Precio);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
        }
    }
}
