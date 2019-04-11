using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPICore.DataModel.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool StatusId { get; set; }
    }
}
