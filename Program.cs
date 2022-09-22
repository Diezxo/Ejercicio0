using Problema;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cuantos productos deseas agregar a la lista?");
        int cantidadproductos = Convert.ToInt32(Console.ReadLine());
        Producto[] ventas = new Producto[cantidadproductos];
        for (int i = 0; i < cantidadproductos; i++)
        {
            Console.WriteLine("Ingresa el nombre del producto");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Ingresa su precio");
            float precio = (float)Convert.ToDouble(Console.ReadLine());
            ventas[i] = new Producto(nombre, precio);
            Console.WriteLine();
        }
        float ventas_brutas = 0;
        float ventas_con_descuentos = 0;
        float ventas_totales = 0;
        const float impuesto = 0.18f;
        float valor_impuesto = ventas_brutas * impuesto;
        for (int i = 0; i < cantidadproductos; i++)
        {
            ventas_brutas = ventas_brutas + ventas[i].GetPrecio();
        }
        

        Console.WriteLine("se aplico algun descuento?");

        string? Respuesta = Console.ReadLine();
        if (Respuesta == "si")
        {
            Console.WriteLine("De cuanto fue el descuento en porcentaje?");
            Console.WriteLine("Referencia: 10%=0.10");
            float descuento = ventas_brutas * (float)Convert.ToDouble(Console.ReadLine());
            ventas_con_descuentos = ventas_brutas - (descuento);
            Console.WriteLine("El descuento de la venta fue: " + descuento);
            Console.WriteLine("Tus ventas totales sin impuestos fueron de: " + ventas_con_descuentos);
            ventas_totales = ventas_con_descuentos + (ventas_con_descuentos * impuesto);
        }
        else if (Respuesta == "no")
        {
            Console.WriteLine("Tus ventas totales sin impuestos fueron de: " + ventas_brutas);
            ventas_totales= ventas_brutas+(ventas_brutas*impuesto);
        }
        
        Console.WriteLine("DETALLE");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Tus ventas brutas fueron: " + ventas_brutas);
        Console.WriteLine("Tus ventas generaron un impuesto del 18%");
        Console.WriteLine("Tus ventas finales fueron de: " + ventas_totales);
    }
}

