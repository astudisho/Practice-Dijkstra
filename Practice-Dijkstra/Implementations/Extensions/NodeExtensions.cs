using Practice.Dijkstra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Practice.Dijkstra.Implementations;

namespace Practice.Dijkstra.Implementations.Extensions
{
    public static class NodeExtensions
    {
		public static INode GetNodeByName(this IEnumerable<INode> node, Constants.NombresNodos val)
#if DEBUG
		{
			var result = node.First(n => n.Nombre.Equals(val));
			return result;
		}
	}

	public static class EdgeExtensions
	{
		public static IEdge GetEdgesWithLessWeight(this IEnumerable<IEdge> edges, float weight)
		{
			return edges.OrderBy(e => e.Peso).First();
		}
	}
}
