using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public class FabricaProyectoBase
    {
        private static Dictionary<string, ProyectoBase> proyectos = new Dictionary<string, ProyectoBase>();

        public IProyecto ObtenerProyectoBase(string version, string contenido)
        {
            if (!proyectos.ContainsKey(version))
            {
                proyectos[version] = new ProyectoBase(version, contenido);
            }
            return proyectos[version].Clone();
        }
        public int TotalProyectosBase => proyectos.Count;
    }
}
