internal class Program
{
    private static List<Nave> naves= new List<Nave>();
    private static Stack<Nave> pilaNaves= new Stack<Nave>();
    public static Random rand=new Random();
    private static void Main(string[] args)
    {
        

        int opcion;
        do
        {
            Menu();
            opcion=Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearNave();
                break;
                case 2:
                    Crear10Naves();
                break;
                case 3:
                     CambiarNombreNave();
                break;
                case 4:
                    ListarNaves();
                break;
                case 5:
                    EliminarTodosNaves();
                break;
                case 6:
                    EliminarNave();
                break;
                case 7:
                    MoveralPila();
                break;
                case 8:
                    MostrarPila();
                break;
                case 9:
                    System.Console.WriteLine("!Bye Bye¡");
                break;
            }
        } while (opcion!=10);
    }
    


    struct Nave{
        public string name;
        public bool exist;
    }

    public static void Menu(){
        System.Console.WriteLine("");
        System.Console.WriteLine("____________________________________");
        System.Console.WriteLine("|          Menyuoo Naves            |");
        System.Console.WriteLine("|-----------------------------------|");
        System.Console.WriteLine("|  1- Crear Nave                    |");
        System.Console.WriteLine("|  2- Crear Bloque de 10 naves      |");
        System.Console.WriteLine("|  3- Cambiar nombre de la nave     |");
        System.Console.WriteLine("|  4- Listar los naves creadas      |");
        System.Console.WriteLine("|  5- Eliminar todas las naves      |");
        System.Console.WriteLine("|  6- Eliminar un nave              |");
        System.Console.WriteLine("|  7- Mover naves a pila            |");
        System.Console.WriteLine("|  8- Mostrar naves en la pila      |");
        System.Console.WriteLine("|  9- Salir                         |");
        System.Console.WriteLine("|___________________________________|");
        System.Console.WriteLine("");
    }
    
    public static void CrearNave(){
        
        string nombre = NombreNave();
        naves.Add( new Nave { name=nombre, exist=true});
        System.Console.WriteLine("Nave creada en la posicion {0}: Nombre:{1} ",naves.Count -1,nombre);
    }
    public static void Crear10Naves(){
        for (int i = 0; i < 10; i++)
        {
            CrearNave();
        }
    }
    public static void  CambiarNombreNave(){
        System.Console.WriteLine("Posicion de la nave");
        int pos =Convert.ToInt32(Console.ReadLine());
        if (pos<0||pos>=naves.Count||!naves[pos].exist)
        {
            Console.WriteLine("No hay nave en esa posición.");
            return;
        }
        Nave naveCambiada=naves[pos];
        string nuevoNombre=NombreNave();
        naveCambiada.name=nuevoNombre;
        naves[pos]=naveCambiada;
        Console.WriteLine("Nave con nuevo nombre: {0}", nuevoNombre);
    }
    public static void ListarNaves(){
        System.Console.WriteLine("\nLista de naves: ");
        bool a=false;
        for (int i = 0; i < naves.Count; i++)
        {
            if (naves[i].exist)
            {
                System.Console.WriteLine("Posicion{0}: Nombre: {1}", i,naves[i].name);
                a=true;
            }
        }
        if(!a){
            System.Console.WriteLine("Naves no existen");
        }
    }
    public static void EliminarTodosNaves(){
        naves.Clear();
        System.Console.WriteLine("Todas las naves eliminados");
    }
    public static void EliminarNave(){
        System.Console.WriteLine("Dime la posicion para eliminar : ");
        int pos =Convert.ToInt32(Console.ReadLine());
        if (pos<0||pos>=naves.Count||!naves[pos].exist)
        {
            Console.WriteLine("Nave no existe en esa posicioon.");
            return;
        }
        naves[pos]=new Nave();
        System.Console.WriteLine("Nave {0} eliminada ",pos);
    }
    public static void MoveralPila(){
        foreach (var nave in naves)
        {
            if (nave.exist)
            {
                pilaNaves.Push(nave);
            }
        }
        System.Console.WriteLine("Las naves han de estar una lista a pasar en una pila");
    }
    public static void MostrarPila(){
        if (pilaNaves.Count == 0){
            Console.WriteLine("La pila es vacía.");
            return;
        }

        Console.WriteLine("Les Naves mostrando en la pila:");
        foreach (var nave in pilaNaves){
        Console.WriteLine("Nave: {0}", nave.name);
        }
    }


    public static string NombreNave(){
        string nombre;
        bool ID;
        string[]names=["HALCONMILENARIO", "CAZAESTELAR", "SUPERDESTRUCTOR", "YWING", "XWING"];
        do
        {
            
            ID= true;
            nombre=names[rand.Next(names.Length)]+"-"+ rand.Next(10, maxValue: 99);
            for (int i = 0; i < naves.Count;i++)
            {
                    if (naves[i].exist && naves[i].name == nombre)
                {
                    ID = false;
                    break; 
                }
            }
        } while (!ID);
        return nombre;
    }
}