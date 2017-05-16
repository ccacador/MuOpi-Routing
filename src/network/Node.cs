using System;
using System.Collections.Generic;

namespace MuOpi.RoutingCS.src.network
{
    public class Node : IEquatable<Node>
    {
        public Node(int nodeId, IEnumerable<Edge> edges)
        {
            NodeId = nodeId;
            Edges = edges;
        }
        public int NodeId { get; private set; }
        public IEnumerable<Edge> Edges { get; private set; }

        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }            
            return this.Equals((Node)obj);
        }

        public bool Equals(Node other)
        {
            return NodeId.Equals(other.NodeId);
        }

        public override int GetHashCode()
        {            
            return NodeId.GetHashCode();
        }
    }
}