using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio1
{
    internal class Libro

    {
        private string Titulo { get; set; }

        private string Autor { get; set; }

        private int Paginas { get; set; }

        private bool Estado = false;

        

        public Libro(string unTitulo, string unAutor, int unPaginas)
        {
            Titulo = unTitulo;
            Autor = unAutor;
            Paginas = unPaginas;
            Estado = false;
        }


        public void AbrirLibro()
        {
            if (!Estado)
                Estado = true;
            else
                throw new Exception("Abierto");
        }
        public void CerrarLibro()
        {
            if (Estado)
                Estado = false;
            else
                throw new Exception("Cerrado");
        }
        public bool verEstadoLibro() => Estado;
        public void Informar()
        {
            Console.WriteLine($"El libro {Titulo} escrito por {Autor} tiene {Paginas} páginas y su estado es {Estado}");
        }


    }
}
