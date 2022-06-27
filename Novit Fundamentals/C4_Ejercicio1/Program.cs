using C4_Ejercicio1;
Console.WriteLine("Coleccion de discos:");

Artista artista1 = new Artista("WOS", "Argentina");
Tema tema1 = new Tema("Arrancamelo", 3.06);
Tema tema2 = new Tema("Canguro", 3.09);
List<Tema> unaLista = new List<Tema>() { tema1, tema2 };
Disco disco1 = new Disco("Oscuro Extasis", 2003,"HIP HOP", artista1, unaLista, "SONY");

Artista artista2 = new Artista("Eminem", "Estados Unidos");
Tema tema3 = new Tema("Rock Bottom ", 3.34 );
Tema tema4 = new Tema("I'm Shady", 3.32);
List<Tema> unaLista2 = new List<Tema>() { tema3, tema4 };
Disco disco2 = new Disco("The Slim Shady LP", 1999, "HIP HOP", artista1, unaLista2, "SONY");
Tema tema5 = new Tema("Bad Guys Always Die",4.39); 

Console.WriteLine("Coleccion");
Coleccion coleccion = new Coleccion();
coleccion.agregarDisco(disco1);
coleccion.agregarDisco(disco2);

Console.WriteLine("Discos:");
coleccion.cantidadDiscos();
coleccion.buscarDisco("The Slim Shady LP");
coleccion.quitarDisco("The Slim Shady LP");
coleccion.cantidadDiscos();


Console.WriteLine("Agregar y eliminar tema al disco:");
disco2.nuevoTema(tema5);
disco2.eliminarTema(tema5);
