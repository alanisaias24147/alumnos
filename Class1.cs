using System;
using System.Collections.Generic;
using System.Text;
using Alumnos;

namespace alumnos
{
    class program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Ernesto", "Ordoñez");
            Console.WriteLine(persona1.nombreCompleto);

            persona1.apellido = "Linares";
            Console.WriteLine(persona1.nombreCompleto);
            persona1.presentarse();

            persona1.ColorFavorito = "morado";
            Console.WriteLine(persona1.ColorFavorito);

            
        }
    }
}
