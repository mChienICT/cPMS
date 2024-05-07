using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common
{
    public class AuditableEntity : BaseEntity
    {
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<DateTime> CreatedDate { get; set; }
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public Nullable<DateTime> UpdatedDate { get; set; }
    }
}
