using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Catalog.Domain.Base;
using Shop.Catalog.Domain.Categories.ValueObjects;

namespace Shop.Catalog.Domain.ParentCategories.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string value)
        {
            Value = value;
            Validate(value);
        }
        public string Value { get; }
        public void Validate(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                if (description.Length > 600)
                {
                    // throw new BusinessException(ExceptionMessages.InvalidLength);
                }
            }
        }


    }
}
