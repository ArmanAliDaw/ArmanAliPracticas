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
            Console.WriteLine(" OPCIONES ");
            Console.WriteLine("1. Agregar un nuevo producto");
            Console.WriteLine("2. Borrar producto");
            Console.WriteLine("3. Editar producto");
            Console.WriteLine("4. Mostrar todos los productos");
            Console.WriteLine("5. Mostrar productos de una categoría");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");
            
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
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 6);
    }

    static void AgregarProducto(Producto[] productos)
    {
        Console.WriteLine(" Agregar Producto ");


        for (int i = 0; i < productos.Length; i++)
        {
            if (string.IsNullOrEmpty(productos[i].Nombre))
            {
                Console.Write("Nombre del producto: ");
                productos[i].Nombre = Console.ReadLine();

                Console.Write("Categoría del producto: ");
                productos[i].Categoria = Console.ReadLine();

                Console.Write("Precio del producto: ");
                productos[i].Precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Cantidad disponible: ");
                productos[i].Cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Producto '{productos[i].Nombre}' agregado con éxito.");
                return;
            }
        }

        Console.WriteLine("No hay espacio disponible para agregar un nuevo producto.");
    }

    static void BorrarProducto(Producto[] productos)
    {
        Console.Clear();
        Console.WriteLine( "Borrar Producto");
        Console.Write("Ingresa el nombre del producto a borrar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Nombre == nombre)
            {
                productos[i] = new Producto();
                Console.WriteLine($"Producto '{nombre}' borrado con éxito.");
                return;
            }
        }

        Console.WriteLine("Producto no encontrado.");
    }


    static void EditarProducto(Producto[] productos)
    {
        Console.Clear();
        Console.WriteLine(" Editar Producto ");
        Console.Write("Ingresa el nombre del producto a editar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Nombre == nombre)
            {
                Console.Write("Nuevo nombre del producto: ");
                productos[i].Nombre = Console.ReadLine();

                Console.Write("Nueva categoría del producto: ");
                productos[i].Categoria = Console.ReadLine();

                Console.Write("Nuevo precio del producto: ");
                productos[i].Precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Nueva cantidad disponible: ");
                productos[i].Cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Producto '{nombre}' editado con éxito.");
                return;
            }
        }

        Console.WriteLine("Producto no encontrado.");
    }

    static void MostrarTodosProductos(Producto[] productos)
    {
        Console.WriteLine("Todos los Productos");

        bool ProductosDisponible = false;
        for (int i = 0; i < productos.Length; i++)
        {
            if (!string.IsNullOrEmpty(productos[i].Nombre))
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}");
                Console.WriteLine($"Categoría: {productos[i].Categoria}");
                Console.WriteLine($"Precio: {productos[i].Precio}");
                Console.WriteLine($"Cantidad: {productos[i].Cantidad}");
                Console.WriteLine("--------------------------");
                ProductosDisponible = true;
            }
        }

        if (!ProductosDisponible)
        {
            Console.WriteLine("No hay productos en el almacén.");
        }
    }
    static void MostrarPorCategoria(Producto[] productos)
    {

        Console.WriteLine(" Mostrar Productos por Categoría ");
        Console.Write("Ingresa la categoría de los productos a mostrar: ");

        string categoria = Console.ReadLine();

        bool ProductosDisponible = false;
        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i].Categoria == categoria)
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}");
                Console.WriteLine($"Categoría: {productos[i].Categoria}");
                Console.WriteLine($"Precio: {productos[i].Precio}");
                Console.WriteLine($"Cantidad: {productos[i].Cantidad}");

                ProductosDisponible = true;
            }
        }

        if (!ProductosDisponible)
        {
            Console.WriteLine("No hay productos en esa categoría.");
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
