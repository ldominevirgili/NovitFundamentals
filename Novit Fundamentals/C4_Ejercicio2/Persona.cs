namespace C4_Ejercicio2
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Email { get; set; }

       

        public SmartPhone SmartPhone { get; set; }

        public Persona(string unNombre, string unEmail)
        {
            Nombre =unNombre;
            Email = unEmail;
        }

        public void setSmartPhone(SmartPhone movil)
        {
            SmartPhone = movil;
        }

        public void ActualizarSO()
        {
            
             SmartPhone.ActualizarSO();
            
        }
    }
}