using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Dijkstra.Interfaces;
using Practice.Dijkstra.Implementations;
using System.Collections.Generic;
using Practice.Dijkstra.Implementations.Extensions;

namespace Test.Practice.Dijkstra
{
    [TestClass]
    public class EdgeTest
    {
		private IEnumerable<IEdge> _testEdges;

        [TestInitialize]
        public void Initialize()
        {
			_testEdges = new List<IEdge>()
			{
				new Edge { Destino = Constants.NombresNodos.d, Peso = 6 },
				new Edge { Destino = Constants.NombresNodos.c, Peso = 4},
				new Edge { Destino = Constants.NombresNodos.a, Peso = 4.5F},
				new Edge { Destino = Constants.NombresNodos.b, Peso = 7},
			};
			
        }
        [TestMethod]
        public void EdgeInitialize()
        {
			var edge = new Edge();

			Assert.AreEqual(0f, edge.Peso);
        }

		[TestMethod]
		public void GetMinimumEdge()
		{
		}
    }
}
