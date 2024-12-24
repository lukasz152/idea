namespace Abstractions.Kernel
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot(){}
        protected AggregateRoot(Guid id): base(id){}
        
        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        private readonly List<IDomainEvent> _events = new List<IDomainEvent>();
        private bool _versionIncremented;
        protected void AddEvent(IDomainEvent Domainevent)
        {
            if (_events.Count == 0 && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;
            }
            _events.Add(Domainevent);
        }
        protected void IncrementVersion()
        {
            if (_versionIncremented) 
            {
                return;
            }
            Version++;
            _versionIncremented = true;
        }
        public void ClearEvents() => _events.Clear();
    }
}
