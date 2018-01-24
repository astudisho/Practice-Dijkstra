using System;
using System.Collections.Generic;
using System.Text;
using Practice.Dijkstra.Implementations;

namespace Practice.Dijkstra.Interfaces
{
    public interface IEdge
    {
        Constants.NombresNodos Destino { get; }
        float Peso { get; set; }
    }
}
