
namespace C4_Ejercicio2
{
    public class SmartPhone
    {
        private string marca;
        private string modelo;
        private SistemaOperativo sistemaOperativo;

        public SmartPhone(string unaMarca, string unModelo, SistemaOperativo unSistemaOperativo)
        {
            marca = unaMarca;
            modelo = unModelo;
            sistemaOperativo = unSistemaOperativo;
        }

        public string Marca() 
        { 
          
            return marca; 
       
        }

        public void ActualizarSO()
        {
            NuevoSO();
        }

        private void NuevoSO()
        {
            sistemaOperativo.Version = +1.0;
            Console.WriteLine($"Nuevo sistema actualizado Version: {sistemaOperativo.Version}");
        }


    }
}