using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }

        //private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        //public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

        //protected void AddDomainEvent(IDomainEvent domainEvent)
        //{
        //    _domainEvents.Add(domainEvent);
        //}

        //protected void ClearDomainEvents()
        //{
        //    _domainEvents.Clear();
        //}
    }

}
