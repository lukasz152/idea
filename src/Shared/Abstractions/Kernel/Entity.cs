namespace Abstractions.Kernel
{
    public abstract class Entity
    {
        public Guid Id { get; init; }

        protected Entity(Guid id) => Id = id;
        protected Entity() { }

        public override bool Equals(object? obj) 
            => obj is not null && obj.GetType() == GetType() && ((Entity)obj).Id == Id; 
    }
}
