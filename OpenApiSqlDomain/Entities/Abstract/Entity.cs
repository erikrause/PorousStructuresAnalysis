using System.ComponentModel.DataAnnotations;

namespace OpenApiSqlDomain.Entities.Abstract
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public bool IsArchived { get; set; }
    }
}
