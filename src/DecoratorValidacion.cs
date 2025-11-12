using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public class DecoratorValidacion : ProyectoDecorator
    {
        public DecoratorValidacion(IProyecto proyecto) : base(proyecto) { }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tProyecto validado.");
        }
    }
}
