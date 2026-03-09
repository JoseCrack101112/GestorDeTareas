using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorTareasGUI1
{
    internal class Class1
    {
        public class Tarea
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public bool Completada { get; set; }

            public override string ToString()
            {
                return $"{Nombre} - {Fecha.ToShortDateString()} {(Completada ? "[✔]" : "[ ]")}";
            }
        }
    }
}
