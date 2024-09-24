using TestConsole.Entities;
using TestConsole.Service;


var productoService = new ProductoService();

while (true) {
    var opcion = Console.ReadLine();
    switch (opcion)
{
    case "1":
        try
        {
            Console.WriteLine("Nombre del producto: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Precio del producto: ");


            if (!int.TryParse(Console.ReadLine(), out var precio))
            {
                throw new Exception("El precio debe ser un número");
            }

            
            var producto = new Producto { Nombre = nombre, Precio = precio };
            var agregarProducto = productoService.AgregarProducto(producto);
            Console.WriteLine(agregarProducto.ToString());

        }catch(Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }
        break;

    case "2":
        try
        {
            Console.WriteLine("El producto más caro: ");
            var obtenerMasCaro = productoService.ObtenerProductoMasCaro();
            Console.WriteLine(obtenerMasCaro.Nombre);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }
        break;
    case "3":
        try
        {
            Console.WriteLine("Precio promedio es: ");
            var calcularPromedio = productoService.calcularPrecioPromedio();
            Console.WriteLine(calcularPromedio);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }
        break;
    }
}