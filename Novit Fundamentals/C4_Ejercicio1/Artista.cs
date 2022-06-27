namespace C4_Ejercicio1
{
    public class Artista
    {
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public Artista(string unNombre, string unaNacionalidad)
        {
            Nombre = unNombre;
            Nacionalidad = unaNacionalidad;
        }
    }
}