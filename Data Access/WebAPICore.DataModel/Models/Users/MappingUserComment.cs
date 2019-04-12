using System;

namespace WebAPICore.DataModel.Models
{
    public class MappingUserComment : BaseEntity
    {
        public Guid UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}