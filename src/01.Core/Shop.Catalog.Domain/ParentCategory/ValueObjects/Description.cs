using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Domain.ParentCategory.ValueObjects
{
    public class Description : ValueObject
    {
        public Description(string value)
        {
            ValidateDescription(value);
            Value = value;
        }

        public string Value { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private static void ValidateDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                if (description.Length > 600)
                {
                    throw new BusinessException(ExceptionMessages.InvalidLength);
                }
            }
        }
    }
}
