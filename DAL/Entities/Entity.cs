using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public bool IsArchived { get; set; }
    }
}
