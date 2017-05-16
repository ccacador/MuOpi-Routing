using System;
using MuOpi.RoutingCS.src.criteria;

namespace MuOpi.RoutingCS.src.network
{
    public class Edge : IEquatable<Edge>
    {
        public Edge(int edgeId, CriteriaArray weight, Node startNode, Node endNode)
        {
            EdgeId = edgeId;
            Weight = weight;
            StartNode = startNode;
            EndNode = endNode;
        }
        public int EdgeId { get; private set; }

        public CriteriaArray Weight { get; private set; }

        public Node StartNode { get; private set; }

        public Node EndNode { get; private set; }
        
        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }            
            return EdgeId.Equals((Edge)obj);
        }

        public bool Equals(Edge other)
        {
            return this.EdgeId.Equals(other.EdgeId);
        }

        public override int GetHashCode()
        {            
            return EdgeId.GetHashCode();
        }
    }
}