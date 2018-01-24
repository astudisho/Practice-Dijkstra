using System;
using System.Collections.Generic;
using System.Text;

using Practice.Dijkstra.Implementations;

namespace Practice.Dijkstra.Interfaces
{
    public interface INode
    {
        IEnumerable<IEdge> Edges { get; }
		Constants.NombresNodos Nombre { get; set; }
		Constants.NombresNodos Antecesor { get; set; }
        float PesoMinimo { get; set; }
    }
}
