using System;
using System.Collections.Generic;
using System.Text;
using TakeChat.Domain.Entities;

namespace TODO.Domain.Entities
{
    public class TODO : BaseEntity
    {
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
