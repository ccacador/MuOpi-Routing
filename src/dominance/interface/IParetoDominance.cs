using MuOpi.RoutingCS.src.criteria;

namespace MuOpi.RoutingCS.src.dominance
{
    public interface IParetoDominance
    {
         int DominanceTest(CriteriaArray firstArray, CriteriaArray secondArray);
    }
}