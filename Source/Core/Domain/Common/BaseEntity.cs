using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
