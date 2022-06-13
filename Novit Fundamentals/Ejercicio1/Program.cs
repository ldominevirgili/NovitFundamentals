using C2_Ejercicio1;

Console.WriteLine("Vamos a ingresar los datos del libro");
Console.WriteLine("Título:");
string titulo = Console.ReadLine();
Console.WriteLine("Autor:");
string autor = Console.ReadLine();
Console.WriteLine("Total de páginas:");
int Paginas= Convert.ToInt32(Console.ReadLine());


Libro libro = new Libro(titulo, autor, Paginas);

libro.AbrirLibro();
libro.Informar();
libro.CerrarLibro();
libro.Informar();