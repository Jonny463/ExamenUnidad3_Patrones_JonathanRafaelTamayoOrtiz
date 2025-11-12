using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    public class ControlVersiones
    {
        private readonly FabricaProyectoBase FabricaProyectos;
        private readonly List<IProyecto> ListaProyectos;
        int verMayor = 0;
        int verMenor = 1;

        public ControlVersiones()
        {
            FabricaProyectos = new FabricaProyectoBase();
            ListaProyectos = new List<IProyecto>();
        }

        public void AñadirVersion(string contenido, bool validar, bool aplicarFormato, bool publicar, bool actualizar)
        {
            string nombre = GenerarNombreVersion();
            IProyecto proyecto = FabricaProyectos.ObtenerProyectoBase(nombre, contenido);
            
            Console.WriteLine($"\nGenerando version {nombre}...");
            if (actualizar)
                proyecto = new DecoratorActualizar(proyecto);
            if (validar)
                proyecto = new DecoratorValidacion(proyecto);
            if (aplicarFormato)
                proyecto = new DecoratorAplicarFormato(proyecto);
            if (publicar)
                proyecto = new DecoratorPublicar(proyecto);

            ListaProyectos.Add(proyecto);
        }
        public void MostrarListaProyectos()
        {
            Console.WriteLine("Historial de versiones:");

            if (ListaProyectos.Count > 0)
            {
                foreach (var proyecto in ListaProyectos)
                {
                    proyecto.Mostrar();
                }
            }
            else
                Console.WriteLine("No hay proyectos en este momento.");
        }

        public void MostrarListaNombres()
        {
            Console.WriteLine("Lista de versiones:");

            if (ListaProyectos.Count > 0)
            {
                foreach (var proyecto in ListaProyectos)
                {
                    Console.Write($"\t{proyecto.Version}");
                }
            }
            else
                Console.WriteLine("No hay proyectos en este momento.");
        }

        private string GenerarNombreVersion()
        {
            string nombre = $"v{verMayor}.{verMenor}";
            verMenor++;
            return nombre;
        }

        public void VersionParaPublicar()
        {
            verMayor++;
            verMenor = 0;
        }
    }
}
