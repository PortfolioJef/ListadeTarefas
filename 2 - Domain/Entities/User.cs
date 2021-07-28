using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Domain.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public virtual List<TaskEntity> Tasks { get; set; }

    }
}
