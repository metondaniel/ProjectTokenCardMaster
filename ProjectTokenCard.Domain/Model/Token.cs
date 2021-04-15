using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTokenCard.Model
{
    public class Token
    {
        public Guid TokenId { get; set; }
        public Guid TokenGuid { get; set; }

        public DateTime Create { get; set; }
    }
}
