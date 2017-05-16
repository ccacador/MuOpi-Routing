namespace MuOpi.RoutingCS.src.criteria.simplerouting
{
    public class SpeedTimeCriteriaFactory
    {
        public CriteriaArray CreateArray(SpeedCriteria speedCriteria, TimeCriteria timeCriteria)
        {
            return new CriteriaArray(new [] {speedCriteria as ICriteria, timeCriteria});
        }

        public CriteriaArray CreateArray(uint speed, ulong time)
        {
            return new CriteriaArray(new[] {new SpeedCriteria(speed) as ICriteria, new TimeCriteria(time) });
        }
    }
}