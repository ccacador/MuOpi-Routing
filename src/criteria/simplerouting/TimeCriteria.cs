using System;

namespace MuOpi.RoutingCS.src.criteria.simplerouting
{
    public class TimeCriteria : ICriteria<ulong>, IComparable<TimeCriteria>
    {
        public TimeCriteria(ulong time)
        {
            Value = time;
        }

        public TimeCriteria(TimeSpan timeSpan) 
            : this((ulong)timeSpan.TotalSeconds)
        {
        }

        public ulong Value {get; private set;}

        public int CompareTo(TimeCriteria other)
        {
            return Value.CompareTo(other.Value);
        }

        public int CompareTo(ICriteria other)
        {
            return CompareTo(other as TimeCriteria);
        }

        public void Add(ICriteria criteria)
        {
            Add(criteria as TimeCriteria);
        }

        public void Add(SpeedCriteria speedCriteria)
        {
            Value += speedCriteria.Value;
        }

    }
}