
using MuOpi.RoutingCS.src.criteria;

namespace MuOpi.RoutingCS.src.dominance
{
    public class ParetoDominance : IParetoDominance
    {
        private readonly int _arraySize;
        public ParetoDominance(int arraySize)
        {
            _arraySize = arraySize;
        }

        public int DominanceTest(CriteriaArray firstArray, CriteriaArray secondArray)
        {
            var comparisonCounter = 0;
            var secondArrayEnumerator = secondArray.CriteriaValues.GetEnumerator();

            foreach (var criteria in firstArray.CriteriaValues)
            {
                secondArrayEnumerator.MoveNext();
                comparisonCounter += criteria.CompareTo(secondArrayEnumerator.Current);                
            }

            return _arraySize == -comparisonCounter ? -1 : _arraySize == comparisonCounter ? 1 : 0;
        }
    }
}