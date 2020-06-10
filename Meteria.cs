using System;

namespace Boleta
{
    class Materia
    {
        string nombre { get; set; }

       public Materia(string nombre)
        {
            this.nombre = nombre;
        } 

         public string Nombre()
        {
            return nombre;
        }
    }
}
