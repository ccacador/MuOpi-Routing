using System;

namespace MuOpi.RoutingCS.src.criteria.simplerouting
{
    public class SpeedCriteria : ICriteria<uint>, IComparable<SpeedCriteria>
    {
        public SpeedCriteria(uint speed)
        {
            Value = speed;
        }

        public uint Value {get; private set;}

        public int CompareTo(SpeedCriteria other)
        {
            return Value.CompareTo(other.Value);
        }

        public int CompareTo(ICriteria other)
        {
            return CompareTo(other as SpeedCriteria);
        }

        public void Add(ICriteria criteria)
        {
            Add(criteria as SpeedCriteria);
        }

        public void Add(SpeedCriteria speedCriteria)
        {
            Value += speedCriteria.Value;
        }
    }
}