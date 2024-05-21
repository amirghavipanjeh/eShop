using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Domain.ParentCategory.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string value)
        {
            Value = value;
            Validate();
        }
        public string Value { get; }
        public void Validate()
        {
            if (Value.Length > 250)
            {
                throw new InvalidLengthBusinessException();
            }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
