using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : AuditableEntity
    {
        public required string Username { get; set; }
        public required string Password { get;set; }
        public string Email { get; set; } = string.Empty;
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public Nullable<DateTime> LastLogin { get; set; }
    }
}
