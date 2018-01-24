using System;
using System.Collections.Generic;
using System.Text;
using Practice.Dijkstra.Implementations;

namespace Practice.Dijkstra.Interfaces
{
    public interface IGraph
    {
        IEnumerable<INode> Nodes { get; set; }

        Constants.NombresNodos Inicio { get; set; }
        Constants.NombresNodos Destino { get; set; }
    }
}
