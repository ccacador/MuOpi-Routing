using MuOpi.RoutingCS.src.criteria;
using MuOpi.RoutingCS.src.dominance;
using MuOpi.RoutingCS.src.label;
using MuOpi.RoutingCS.src.network;
using System.Linq;

namespace MuOpi.RoutingCS.src.algorithm
{
    public class ShortestPath
    {
        private readonly Graph _graph;
        public ShortestPath(Graph graph)
        {
            _graph = graph;
        }
        public void CalculatePath(int startNodeId, int endNodeId)
        {
            var startNode = _graph.GetNodeById(startNodeId);
            var priorityQueue = new LabelPriorityQueue(new ParetoDominance(3));
            priorityQueue.TryAdd(new Label(startNode, null, null, null), null);

            while (!priorityQueue.IsEmpty())
            {
                
            }

        }
    }
}