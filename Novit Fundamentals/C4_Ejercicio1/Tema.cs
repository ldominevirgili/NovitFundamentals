namespace C4_Ejercicio1
{
    public class Tema
    {
        public string Nombre { get; set; }
        public double Duracion { get; set; }

        public Tema(string unNombre, double unaDuracion)
        {
            Nombre = unNombre;
            Duracion = unaDuracion;
        }
    }
}