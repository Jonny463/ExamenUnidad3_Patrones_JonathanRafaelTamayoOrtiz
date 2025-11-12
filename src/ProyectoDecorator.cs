using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public abstract class ProyectoDecorator : IProyecto
    {
        protected IProyecto Proyecto;
        public ProyectoDecorator(IProyecto proyecto)
        {
            Proyecto = proyecto;
            Modificado = DateTime.Now;
        }

        public virtual string Version => Proyecto.Version;
        public virtual string Contenido => Proyecto.Contenido;
        public virtual DateTime Modificado { get; set; }
        public virtual void Mostrar() { Proyecto.Mostrar(); }
        public virtual IProyecto Clone() { return Proyecto.Clone(); }
    }
}
