using System;
using System.Collections.Generic;

namespace MuOpi.RoutingCS.src.criteria
{
    public class CriteriaArray : IComparable<CriteriaArray>
    {
        private readonly IEnumerable<ICriteria> _criteriaValues;
        public CriteriaArray(IEnumerable<ICriteria> criteriaValues)
        {
            _criteriaValues = criteriaValues;            
        }

        public IEnumerable<ICriteria> CriteriaValues 
        { 
            get {return _criteriaValues; }
        }

        public void Add(CriteriaArray criteriaArray)
        {
            var enumerator = criteriaArray.CriteriaValues.GetEnumerator();

            foreach (var criteria in _criteriaValues)
            {
                enumerator.MoveNext();
                criteria.Add(enumerator.Current);
            }
        }

        public int CompareTo(CriteriaArray other)
        {
            var enumerator = _criteriaValues.GetEnumerator();
            var otherEnumerator = other.CriteriaValues.GetEnumerator();
            
            while (enumerator.MoveNext() && otherEnumerator.MoveNext())
            {
                 var comparison = enumerator.Current.CompareTo(otherEnumerator.Current);
                 if (comparison != 0)
                 {
                     return comparison;
                 }
            }
            return 0;
        }
    }
}