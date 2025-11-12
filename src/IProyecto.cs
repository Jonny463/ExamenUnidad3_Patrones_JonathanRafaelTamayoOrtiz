using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public interface IProyecto
    {
        string Version { get; }
        string Contenido { get; }
        DateTime Modificado { get; set; }
        void Mostrar();
        IProyecto Clone();
    }
}
