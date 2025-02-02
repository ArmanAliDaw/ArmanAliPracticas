
// Actividad 7

// Diseña una estructura llamada "Paciente" que incluya los campos: nombre, edad, diagnóstico
// y fecha de ingreso.
// Codifica un array de tamaño 6 para almacenar la información de los pacientes registrados en
// un hospital.
// Implementa un menú que permita al usuario:
// ● Registrar un nuevo paciente.
// ● Mostrar la lista completa de pacientes y sus datos.
// ● Buscar un paciente por su nombre y mostrar su información.




// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Paciente[] paciente = new Paciente [6];
//         int opcion = 0;
//         int index =0;

//         do
//         {
//             System.Console.WriteLine("Escribe una opcion");
//             System.Console.WriteLine("Opcion 0 - Registrar un nuevo paciente");
//             System.Console.WriteLine("Opcion 1 - Mostrar la lista completa de pacientes y sus datos.");
//             System.Console.WriteLine("Opcion 2 - Buscar un paciente por su nombre y mostrar su información.");
//             System.Console.WriteLine("Opcion 3 - Salir programa");
            
//             opcion = Convert.ToInt32(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 0:
//                 System.Console.WriteLine("nombre");
//                 paciente[index].nombre = Console.ReadLine();

//                 System.Console.WriteLine("edad");
//                 paciente[index].edad = Convert.ToInt32(Console.ReadLine());

//                 System.Console.WriteLine("diagnostico");
//                 paciente[index].diagnostico = Console.ReadLine();

//                 System.Console.WriteLine("fecha ingreso");
//                 paciente[index].fechaIngreso = Console.ReadLine();
                
//                 index++;
//                 break;


//                 case 1:
//                 foreach (var item in paciente)
//                 {
//                         if (item.nombre!=null)
//                         {
//                         System.Console.WriteLine("Nombre del Paciente "+ item.nombre);
//                         System.Console.WriteLine("edad "+ item.edad);
//                         System.Console.WriteLine("diagnostico "+ item.diagnostico);
//                         System.Console.WriteLine("fecha ingreso "+ item.fechaIngreso);
//                         }
//                 }
//                 break;

//                 case 2:
//                 string solicitudUsuario;
//                 System.Console.WriteLine("Escribe el nombre del paciente al que quieres buscar");
//                 solicitudUsuario = Console.ReadLine();

//                 foreach (var item in paciente)
//                 {
//                     if (solicitudUsuario==item.nombre)
//                     {
//                     System.Console.WriteLine("Nombre " + item.nombre);
//                     System.Console.WriteLine("Edad " +item.edad);
//                     System.Console.WriteLine("diagnostico "+item.diagnostico);
//                     System.Console.WriteLine("fecha ingreso "+ item.fechaIngreso); 
//                     }
//                 }
//                 break;
                
//                 case 3:
//                 opcion=3;
//                 break;
//             }
            
            
//         } while (opcion !=3);
//     }

//     struct Paciente{
//         public string nombre;
//         public int edad;
//         public string diagnostico;
//         public string fechaIngreso;
//     }   

// }






// Codifica una estructura llamada "Película" que contenga los campos: título, director, género
// (acción, comedia, drama, etc.) y duración (en minutos).
// Declara un array bidimensional de tamaño [3,4] para clasificar películas en tres géneros
// distintos.
// Implementa un menú con las siguientes opciones:
// ● Agregar una nueva película en la categoría correspondiente.
// ● Mostrar todas las películas de un género seleccionado.
// ● Calcular el promedio de duración de las películas almacenadas en cada género.

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static Dictionary<string, List<(string Titulo, string Director, int Duracion)>> peliculas = new Dictionary<string, List<(string, string, int)>>()
//     {
//         { "acción", new List<(string, string, int)>() },
//         { "comedia", new List<(string, string, int)>() },
//         { "drama", new List<(string, string, int)>() }
//     };

//     static void Main()
//     {
//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine("Menú:");
//             Console.WriteLine("1. Agregar película");
//             Console.WriteLine("2. Mostrar películas");
//             Console.WriteLine("3. Promedio duración");
//             Console.WriteLine("4. Salir");
//             int opcion = int.Parse(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 1: AgregarPelicula(); break;
//                 case 2: MostrarPeliculas(); break;
//                 case 3: PromedioDuracion(); break;
//                 case 4: return;
//                 default: Console.WriteLine("Opción inválida."); break;
//             }
//             Console.ReadKey();
//         }
//     }

//     static void AgregarPelicula()
//     {
//         Console.Write("Título: ");
//         string titulo = Console.ReadLine();
//         Console.Write("Director: ");
//         string director = Console.ReadLine();
//         Console.Write("Género (acción, comedia, drama): ");
//         string genero = Console.ReadLine().ToLower();
//         if (!peliculas.ContainsKey(genero)) { Console.WriteLine("Género inválido."); return; }

//         Console.Write("Duración (minutos): ");
//         int duracion = int.Parse(Console.ReadLine());

//         peliculas[genero].Add((titulo, director, duracion));
//         Console.WriteLine("Película agregada.");
//     }

//     static void MostrarPeliculas()
//     {
//         Console.Write("Género: ");
//         string genero = Console.ReadLine().ToLower();
//         if (peliculas.ContainsKey(genero))
//         {
//             foreach (var p in peliculas[genero])
//                 Console.WriteLine($"Título: {p.Titulo}, Director: {p.Director}, Duración: {p.Duracion} min");
//         }
//         else
//         {
//             Console.WriteLine("Género no encontrado.");
//         }
//     }

//     static void PromedioDuracion()
//     {
//         foreach (var genero in peliculas)
//         {
//             if (genero.Value.Count > 0)
//             {
//                 double avg = genero.Value.Average(p => p.Duracion);
//                 Console.WriteLine($"Promedio {genero.Key}: {avg:F2} minutos.");
//             }
//             else
//             {
//                 Console.WriteLine($"No hay películas en {genero.Key}.");
//             }
//         }
//     }
// }




// Diseña una estructura llamada "EventoDeportivo" con los campos: nombre del evento, fecha,
// lugar y número de participantes.
// Declara un array de tamaño 5 para almacenar información sobre 5 eventos deportivos
// diferentes.
// Diseña un menú que permita:
// ● Agregar un nuevo evento deportivo.
// ● Mostrar la lista de eventos organizados con sus detalles.
// ● Buscar un evento por su nombre.




// internal class Program
// {
//     private static void Main(string[] args)
//     {
//       Evento[] evento = new Evento [5];
//         int opcion = 0;
//         int index =0;

//         do
//         {
//             System.Console.WriteLine("Escribe una opcion");
//             System.Console.WriteLine("Opcion 0 - Agregar evento deportivo");
//             System.Console.WriteLine("Opcion 1 - Mostrar la lista completa de eventos organizados con sus detalles.");
//             System.Console.WriteLine("Opcion 2 - Buscar un evento por su nombre.");
//             System.Console.WriteLine("Opcion 3 - Salir programa");
            
//             opcion = Convert.ToInt32(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 0:
//                 System.Console.WriteLine("nombre del evento");
//                 evento[index].nombreEvento = Console.ReadLine();

//                 System.Console.WriteLine("fecha lugar");
//                 evento[index].fechaLugar = Console.ReadLine();

//                 System.Console.WriteLine("numero participantes");
//                 evento[index].numeroParticipantes = Convert.ToInt32(Console.ReadLine());
                
//                 index++;
//                 break;


//                 case 1:
//                 foreach (var item in evento)
//                 {
//                         if (item.nombreEvento!=null)
//                         {
//                         System.Console.WriteLine("nombre del evento "+ item.nombreEvento);
//                         System.Console.WriteLine("fecha lugar "+ item.fechaLugar);
//                         System.Console.WriteLine("numero participantes "+ item.numeroParticipantes);
//                         }
//                 }
//                 break;

//                 case 2:
//                 string solicitudUsuario;
//                 System.Console.WriteLine("Escribe el nombre del evento que quieres buscar");
//                 solicitudUsuario = Console.ReadLine();

//                 foreach (var item in evento)
//                 {
//                     if (solicitudUsuario==item.nombreEvento)
//                     {
//                     System.Console.WriteLine("Nombre Evento " + item.nombreEvento);
//                     System.Console.WriteLine("fecha lugar "+ item.fechaLugar);
//                     System.Console.WriteLine("numero participantes "+ item.numeroParticipantes); 
//                     }
//                 }
//                 break;
                
//                 case 3:
//                 opcion=3;
//                 break;
//             }
            
            
//         } while (opcion !=3);
//     }   


    
//     struct Evento{
//         public string nombreEvento;
//         public string fechaLugar;
//         public int numeroParticipantes;
//     }

// }




// Crea una estructura llamada "ReservaLibro" con los campos: título del libro, nombre del
// usuario, fecha de reserva y fecha de devolución.
// Declara un array de tamaño 7 para registrar las reservas realizadas por los usuarios.
// Diseña un menú que permita:
// ● Realizar una nueva reserva (si hay espacio disponible).
// ● Mostrar todas las reservas realizadas.
// ● Buscar las reservas de un usuario específico.
// ● Mostrar cuántos libros están pendientes de devolución.




// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         ReservaLibro[] reservaLibro = new ReservaLibro [7];
//         int opcion = 0;
//         int index =0;
//         int librosPendientes = 0;
//         do
//         {
//             System.Console.WriteLine("Escribe una opcion");
//             System.Console.WriteLine("Opcion 0 - Realizar reserva");
//             System.Console.WriteLine("Opcion 1 - Mostrar reservas");
//             System.Console.WriteLine("Opcion 2 - Buscar reservas de un usuario especifico.");
//             System.Console.WriteLine("Opcion 3 - Mostrar cuántos libros están pendientes de devolucion");
//             System.Console.WriteLine("Opcion 4 - Salir");
            
//             opcion = Convert.ToInt32(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 0:
//                 System.Console.WriteLine("titulo del libro");
//                 reservaLibro[index].tituloLibro = Console.ReadLine();

//                 System.Console.WriteLine("nombre usuario");
//                 reservaLibro[index].nombreUsuario = Console.ReadLine();

//                 System.Console.WriteLine("fecha reserva");
//                 reservaLibro[index].fechaReserva = Console.ReadLine();
                
//                 System.Console.WriteLine("fecha de devolucion");
//                 reservaLibro[index].fechaDevolucion = Console.ReadLine();

//                 index++;
//                 librosPendientes++;
//                 break;


//                 case 1:
//                 foreach (var item in reservaLibro)
//                 {
//                         if (item.tituloLibro!=null)
//                         {
//                         System.Console.WriteLine("titulo del libro "+ item.tituloLibro);
//                         System.Console.WriteLine("nombre usuario "+ item.nombreUsuario);
//                         System.Console.WriteLine("fecha reserva "+ item.fechaReserva);
//                         System.Console.WriteLine("fecha de devolucion "+ item.fechaDevolucion);
//                         }
//                 }
//                 break;

//                 case 2:
//                 string solicitudUsuario;
//                 System.Console.WriteLine("Escribe el nombre del usuario al que quieres ver las reservas");
//                 solicitudUsuario = Console.ReadLine();

//                 foreach (var item in reservaLibro)
//                 {
//                     if (solicitudUsuario==item.nombreUsuario)
//                     {
//                         System.Console.WriteLine($"El usuario {item.nombreUsuario} tiene reservado el libro: {item.tituloLibro}");
//                     }
//                 }
//                 break;
                
//                 case 3:
//                 System.Console.WriteLine($"Libros pendientes de devolucion: {librosPendientes}");
//                 break;

//                 case 4:
//                 opcion=3;
//                 break;
//             }
            
            
//         } while (opcion !=3);
//     }   


//     }
//     struct ReservaLibro{
//         public string tituloLibro;
//         public string nombreUsuario;
//         public string fechaReserva;
//         public string fechaDevolucion;
//     }
