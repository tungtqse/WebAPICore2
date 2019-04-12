using System;
using System.Collections.Generic;

namespace WebAPICore.DataModel.Models
{
    public class Comment : BaseEntity
    {
        public Guid ParentId { get; set; }
        public string Content { get; set; }

        public ICollection<MappingUserComment> UserComments { get; set; }
    }
}