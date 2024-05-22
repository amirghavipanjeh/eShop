using Shop.Catalog.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Domain.Categories.ValueObjects
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
                //throw new InvalidLengthBusinessException();
            }
        }


    }
}
