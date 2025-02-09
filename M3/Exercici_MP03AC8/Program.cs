using System;

internal class Program
{
    static void Main(string[] args)
    {
        int opcion;
        Producto[] productos = new Producto[20];

        for (int i = 0; i < productos.Length; i++)
        {
            productos[i] = new Producto();
        }

        do
        {
            Console.WriteLine("");
            Console.WriteLine("_____________________________________");
            Console.WriteLine(" OPCIONES ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Agregar un nuevo producto");
            Console.WriteLine("");
            Console.WriteLine("2. Borrar producto");
            Console.WriteLine("");
            Console.WriteLine("3. Editar producto");
            Console.WriteLine("");
            Console.WriteLine("4. Mostrar todos los productos");
            Console.WriteLine("");
            Console.WriteLine("5. Mostrar productos de una categoría");
            Console.WriteLine("");
            Console.WriteLine("6. Salir");


            Console.Write("Elige una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarProducto(productos);
                    break;
                case 2:
                    BorrarProducto(productos);
                    break;
                case 3:
                    EditarProducto(productos);
                    break;
                case 4:
                    MostrarTodosProductos(productos);
                    break;
                case 5:
                    MostrarPorCategoria(productos);
                    break;
                case 6:
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("Opcion no valido.");
                    break;
            }
        }
        while (opcion != 6);
    }

    static void AgregarProducto(Producto[] productos)
    {
        Console.WriteLine("_____________________________________");
        Console.WriteLine(" Agregar Producto ");
        Console.WriteLine("-------------------------------------");

        for (int i = 0; i < productos.Length; i++)
        {
            if (string.IsNullOrEmpty(productos[i].Nombre))
            {
                Console.Write("Nombre producto: ");
                productos[i].Nombre = Console.ReadLine();

                Console.Write("Categoría producto: ");
                productos[i].Categoria = Console.ReadLine();

                Console.Write("Precio producto: ");
                productos[i].Precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Cantidad disponible: ");
                productos[i].Cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("_____________________________________");

                Console.WriteLine($"Producto '{productos[i].Nombre}' agregado");
                return;
            }
        }

    }

    static void BorrarProducto(Producto[] productos)
    {
        Console.WriteLine("_____________________________________");
        Console.WriteLine( "Borrar Producto");
        Console.WriteLine("-------------------------------------");
        Console.Write("Ingresa el nombre del producto : ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Nombre == nombre)
            {
                productos[i] = new Producto();
                Console.WriteLine($"Producto '{nombre}' borrado");
                return;
            }
        }

        Console.WriteLine("Producto no encontrado.");
    }


    static void EditarProducto(Producto[] productos)
    {
        Console.WriteLine("_____________________________________");
        Console.WriteLine(" Editar Producto ");
        Console.WriteLine("------------------------------------");
        Console.Write("Ingresa el nombre del producto: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Nombre == nombre)
            {
                Console.Write("Nuevo nombre del producto: ");
                productos[i].Nombre = Console.ReadLine();

                Console.Write("Nueva categoria del producto: ");
                productos[i].Categoria = Console.ReadLine();

                Console.Write("Nuevo precio del producto: ");
                productos[i].Precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Nueva cantidad disponible: ");
                productos[i].Cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("_____________________________________");

                Console.WriteLine($"Producto '{nombre}' editado");
                return;
            }
        }

        Console.WriteLine("Producto no encontrado");
    }

    static void MostrarTodosProductos(Producto[] productos)
    {
        Console.WriteLine("_____________________________________");
        Console.WriteLine("Todos los Productos");
        Console.WriteLine("--------------------------------------");

        bool ProductosDisponible = false;
        for (int i = 0; i < productos.Length; i++)
        {
            if (!string.IsNullOrEmpty(productos[i].Nombre))
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}");
                Console.WriteLine($"Categoria: {productos[i].Categoria}");
                Console.WriteLine($"Precio: {productos[i].Precio}");
                Console.WriteLine($"Cantidad: {productos[i].Cantidad}");
                ProductosDisponible = true;
                Console.WriteLine("_____________________________________");
            }
        }

        if (!ProductosDisponible)
        {
            Console.WriteLine("Producto No desponible.");
        }
    }
    static void MostrarPorCategoria(Producto[] productos)
    {

        Console.WriteLine("_____________________________________");
        Console.WriteLine(" Mostrar Productos por Categoria ");
        Console.WriteLine("-------------------------------------");

        Console.Write("Ingresa la categoria ");
        string categoria = Console.ReadLine();

        bool ProductosDisponible = false;
        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Categoria == categoria)
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}");
                Console.WriteLine($"Categoria: {productos[i].Categoria}");
                Console.WriteLine($"Precio: {productos[i].Precio}");
                Console.WriteLine($"Cantidad: {productos[i].Cantidad}");
                Console.WriteLine("_____________________________________");

                ProductosDisponible = true;
            }
        }

        if (!ProductosDisponible)
        {
            Console.WriteLine("Producto No desponible");
        }
    }
}

struct Producto
{
    public string Nombre;
    public string Categoria;
    public decimal Precio;
    public int Cantidad;
}
