using Practice.Dijkstra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Dijkstra.Implementations
{
    class Node : INode
    {
		public Constants.NombresNodos Nombre { get; set; }

		public Constants.NombresNodos Antecesor { get; set; }

		public float PesoMinimo { get; set; }

        public IEnumerable<IEdge> Edges { get; private set; }

        public Node( IEnumerable<IEdge> edges )
        {
			Edges = edges;
        }

        public Node()
        {
            PesoMinimo = float.PositiveInfinity;
        }
    }
}
