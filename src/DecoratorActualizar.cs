using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public class DecoratorActualizar : ProyectoDecorator
    {
        public DecoratorActualizar(IProyecto proyecto) : base(proyecto) { }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tAProyecto actualizado.");
        }
    }
}
