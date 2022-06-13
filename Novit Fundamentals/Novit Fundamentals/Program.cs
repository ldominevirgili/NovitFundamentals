using C2_Ejercicio2;

Console.WriteLine("Ingrese los datos de la persona.");
Console.WriteLine("Nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El peso en kilogramos:");
decimal peso = Convert.ToDecimal(Console.ReadLine()); 

Console.WriteLine("La altura en metros:");
decimal altura= Convert.ToDecimal(Console.ReadLine()); ;


Persona persona = new Persona(nombre, edad, peso, altura);

Console.WriteLine($"Mayor de Edad: {(persona.MayoriaEdad() ? "Sí" : "No")}");
Console.WriteLine($"IMC: {persona.IMC()}");

persona.Informar();

