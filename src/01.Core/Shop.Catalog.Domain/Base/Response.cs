using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Catalog.Domain.Base
{
    public abstract class Response<T> 
    {
        public T Id { get;  set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
