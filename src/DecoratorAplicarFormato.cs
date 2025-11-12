using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public class DecoratorAplicarFormato : ProyectoDecorator
    {
        public DecoratorAplicarFormato(IProyecto proyecto) : base(proyecto) { }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tAplicando formato PDF.");
        }
    }
}
