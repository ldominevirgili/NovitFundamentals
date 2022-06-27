namespace C4_Ejercicio2
{
    public class SistemaOperativo
    {
        private string nombre;
        public double Version { get; set; }

        public SistemaOperativo(string unNombre, double unaVersion = 10.1)
        {
            nombre = unNombre;
            Version = unaVersion;
        }

        public string Nombre() 
        {
        
            return nombre;
        
        }
    }
}