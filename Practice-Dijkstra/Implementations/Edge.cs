using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Practice.Dijkstra.Interfaces;

namespace Practice.Dijkstra.Implementations
{
    public class Edge : IEdge
    {
        public Constants.NombresNodos Destino { get; set; }
        public float Peso { get; set; }

    }
}
