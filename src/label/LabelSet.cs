using System.Collections.Generic;
using MuOpi.RoutingCS.src.criteria;
using MuOpi.RoutingCS.src.dominance;
using System.Linq;

namespace MuOpi.RoutingCS.src.label
{
    public class LabelSet
    {
        private readonly IDictionary<ICriteria, Label> _labelList;
        private readonly IParetoDominance _paretoDominance;

        public LabelSet(IDictionary<ICriteria, Label> labelList, IParetoDominance paretoDominance)
        {
            _paretoDominance = paretoDominance;
            _labelList = labelList;
        }

        public bool TryAdd(Label label, ICriteria priorityCriteria)
        {
            foreach (var l in _labelList)
            {
                int testResult = _paretoDominance.DominanceTest(label.LabelWeight, l.Value.LabelWeight);
                if (testResult == -1) return false;
                if (testResult == 0) continue;                
                _labelList.Remove(l);
            }
            _labelList.Add(priorityCriteria, label);
            return true;
        }

        public bool IsEmpty()
        {
            return !_labelList.Any();
        }
    }
}