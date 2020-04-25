using System.ComponentModel.DataAnnotations;

namespace OpenApiSqlDomain.Entities.Abstract
{
    public class Entity
    {
        [Key]
        public virtual int Id { get; set; }     // Can be overrided with data annotations (for foreign keys).

        public bool IsArchived { get; set; }
    }
}
