using System;
using System.ComponentModel.DataAnnotations;

namespace Task.Domain.Entities
{
    public class TaskEntity : BaseEntity
    {
        [Required]
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Done { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
