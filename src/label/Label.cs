using MuOpi.RoutingCS.src.criteria;
using MuOpi.RoutingCS.src.network;

namespace MuOpi.RoutingCS.src.label
{
    public class Label
    {
        public Label(Node node, Label previousLabel, Edge previousEdge, CriteriaArray labelWeight)
        {
            Node = node;
            PreviousLabel = previousLabel;
            PreviousEdge = previousEdge;
            LabelWeight = labelWeight;

        }
        public CriteriaArray LabelWeight { get; private set; }

        public Node Node { get; private set; }

        public Edge PreviousEdge { get; private set; }

        public Label PreviousLabel {get; private set;}

    }
}