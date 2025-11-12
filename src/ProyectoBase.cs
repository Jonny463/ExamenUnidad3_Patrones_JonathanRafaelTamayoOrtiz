using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public class ProyectoBase : IProyecto
    {
        public string Version { get; }
        public string Contenido { get; }
        public DateTime Modificado { get; set; }

        public ProyectoBase(string version, string contenido)
        {
            this.Version = version;
            this.Contenido = contenido;
            Modificado = DateTime.Now;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"\n\tVersion: {Version}");
            Console.WriteLine($"\tUltima modificacion: {Modificado}");
            Console.WriteLine($"\tContenido:\n\t{Contenido}");
        }

        public virtual IProyecto Clone()
        {
            return new ProyectoBase(Version, Contenido)
            {
                Modificado = this.Modificado
            };
        }
    }
}
