using System;

namespace MuOpi.RoutingCS.src.criteria
{
    public interface ICriteria<T> : ICriteria where T : struct
    {
        T Value {get;}
    }
    public interface ICriteria : IComparable<ICriteria>
    {
        void Add(ICriteria criteria);        
    }
}