using System.Collections.Generic;
using MuOpi.RoutingCS.src.criteria;
using MuOpi.RoutingCS.src.dominance;

namespace MuOpi.RoutingCS.src.label
{
    public class LabelPriorityQueue : LabelSet
    {
        public LabelPriorityQueue(IParetoDominance paretoDominance) 
        : base(new SortedDictionary<ICriteria, Label>(), paretoDominance)
        {
        }
    }
}