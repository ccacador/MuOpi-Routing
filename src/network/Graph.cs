using System.Collections.Generic;

namespace MuOpi.RoutingCS.src.network
{
    public class Graph
    {
        private readonly IDictionary<int, Edge> _edges;

        private readonly IDictionary<int, Node> _nodes;
        public Graph(IDictionary<int, Edge> edges, IDictionary<int, Node> nodes)
        {
            _edges = edges;
            _nodes = nodes;
        }

        public Edge GetEdgeById(int id)
        {
            Edge edge;
            return _edges.TryGetValue(id, out edge) ? edge : null;
        }

        public Node GetNodeById(int id)
        {
            Node node;
            return _nodes.TryGetValue(id, out node) ? node : null;
        }
    }
}