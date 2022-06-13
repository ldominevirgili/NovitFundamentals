using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio2
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private decimal Peso { get; set; }
        private decimal Altura { get; set; }

        public Persona(string unNombre, int unaEdad, decimal unPeso, decimal unAltura)
        {
            Nombre = unNombre;
            Edad = unaEdad;
            Peso = unPeso;
            Altura = unAltura;
        }

        public string IMC()
        {
                decimal IMC =( Peso / (Altura * Altura));
                if (IMC < (decimal)18.5) return "Bajo Peso";
                if (IMC < (decimal)25.0) return "Peso Ideal";
                return "Sobrepeso"; 
        }

        public void Informar()
        {
            Console.WriteLine("La persona de nombre {Nombre}, de {Edad} años de edad , con un peso de {Peso} kilogramos. y una altura de {Altura} metros.");
        }


        public bool MayoriaEdad()
        {
            return this.Edad >= 18;
        }

       
    }
}