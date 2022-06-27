namespace C4_Ejercicio1
{
    public class Disco
    {
        public string Nombre { get; set; }
        public int AnioLanzamiento { get; set; }
        public string Genero { get; set; }
        public Artista Artista { get; set; }
        public List<Tema> Temas { get; set; }
        public string SelloProductor { get; set; }

        public Disco(string unNombre, int unAnioLanzamiento, string unGenero, Artista unArtista, List<Tema> unaLista, string unSelloProductor)
        {
            Nombre = unNombre;
            AnioLanzamiento = unAnioLanzamiento;
            Genero = unGenero;
            Artista = unArtista;
            Temas = unaLista;
            SelloProductor = unSelloProductor;
        }

        public void nuevoTema(Tema unTema) => this.Temas.Add(unTema);

        public void eliminarTema(Tema unTema) => this.Temas.Remove(unTema);
       
    }
}