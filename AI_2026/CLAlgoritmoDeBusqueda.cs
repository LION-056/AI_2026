using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_2026
{
    public static class CLAlgoritmoDeBusqueda
    {
        public static List<CLEstado> AnchuraPrioritaria(CLEstado Inicial)
        {
            // Definición de Variables

            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos= new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();
            CLEstado Actual = new CLEstado();
            // Algoritmo

            Abiertos.Add(Inicial);
            Actual = Abiertos[0];

            while (!Actual.EsFinal() && Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);
                Hijos=Actual.GenerarHijos();
                Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);
                foreach (CLEstado a in Hijos)
                    Abiertos.Add(a);
                Actual = Abiertos[0];
            }

            if (Actual.EsFinal())
            {
                while (Actual != null)
                {
                    Solucion.Insert(0, Actual);
                    Actual = Actual.padre;
                }
            }
            return Solucion;            
        }

        private static List<CLEstado> TratarRepetidos(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            List<CLEstado> HijosDepurados = new List<CLEstado>();
            bool Encontrado = false;

            foreach (CLEstado hijo in hijos)
            {
                Encontrado = false;

                //Comparar con abiertos
                foreach (var a in abiertos)
                {
                    if (hijo.EsIgual(a))
                    {
                        Encontrado = true; break;
                    }
                }

                if (Encontrado) continue;

                // comparar con cerrados
                foreach (var c in cerrados)
                {
                    if (hijo.EsIgual(c))
                    {
                        Encontrado = true; break;
                    }
                }

                if (!Encontrado)
                {
                    HijosDepurados.Add(hijo);
                }
            }
            return HijosDepurados;
        }


    }
}
