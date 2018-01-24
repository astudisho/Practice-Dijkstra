using System;
using System.Collections.Generic;
using System.Text;
using Practice.Dijkstra.Interfaces;
using System.Linq;

using Practice.Dijkstra.Implementations.Extensions;

namespace Practice.Dijkstra.Implementations
{
    public class Graph : IGraph
    {
        public IEnumerable<INode> Nodes { get; set ; }
        public Constants.NombresNodos Inicio { get; set; }
        public Constants.NombresNodos Destino { get; set; }

		private IList<INode> _visitados, _porVisitar;
		private IEnumerable<INode> _camino;

        public Graph()
        {
            
        }

        IEnumerable<INode> Dijsktra(Constants.NombresNodos inicio, Constants.NombresNodos fin)
        {
            _visitados = new List<INode>();
            _porVisitar = new List<INode>();
            _camino = Nodes.ToList();
            Inicio = inicio;
            Destino = fin;
            INode nodoActual;

            try
            {
				nodoActual = _porVisitar.GetNodeByName(inicio);
				nodoActual.PesoMinimo = 0f;
				
				while (nodoActual.Nombre != fin)
				{
					_porVisitar.Remove(nodoActual);
					_visitados.Add(nodoActual);

					

					foreach (var edge in nodoActual.Edges)
					{
						if (edge.Peso <  nodoActual.PesoMinimo)
						{
							
						}
					}
				}								
            }
            catch (Exception e)
            {

                throw;
            }

            return _camino;
        }
    }
}
