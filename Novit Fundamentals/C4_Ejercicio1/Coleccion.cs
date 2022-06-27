namespace C4_Ejercicio1
{
    public class Coleccion
    {
        public List<Disco> Discos { get; set; }

        public Coleccion()
        {
            this.Discos = new List<Disco>();
            Console.WriteLine("Nueva coleccion de elementos");
        }

        public void agregarDisco(Disco unDisco)
        {
            this.Discos.Add(unDisco);
            Console.WriteLine($"El elemento {unDisco.Nombre} se agregó a la colección");
        }

        
        public void quitarDisco(string unNombreDisco)
        {
            var eliminarDisco = this.Discos.Find(x => x.Nombre == unNombreDisco);
            if (eliminarDisco != null)
            {
                this.Discos.Remove(eliminarDisco);
                Console.WriteLine($"El elemento {eliminarDisco.Nombre} fue eliminado");
            }
            else Console.WriteLine("No existe el elemento ");
        }

        public void cantidadDiscos()
        {
            Console.WriteLine($"Cantidad de elementos en la coleccion: {this.Discos.Count}");
        }

        public void buscarDisco(string unNombreDisco)
        {
            var discoBuscado = this.Discos.Find(x => x.Nombre == unNombreDisco);
            if (discoBuscado != null) Console.WriteLine($"El elemento {discoBuscado.Nombre} es parte de la colección.");
            else Console.WriteLine($"Elemento inexistente");
        }
    }
}