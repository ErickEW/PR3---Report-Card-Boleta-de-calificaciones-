using System;

namespace Boleta
{
    class Alumnos
    {
        string nombre { get; set; }

       public Alumnos(string nombre)
        {
            this.nombre = nombre;
        } 

         public string Nombre()
        {
            return nombre;
        }
    }
}
