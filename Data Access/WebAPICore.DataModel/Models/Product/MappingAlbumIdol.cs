using System;

namespace WebAPICore.DataModel.Models
{
    public class MappingAlbumIdol : BaseEntity
    {
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public Guid IdolId { get; set; }
        public Idol Idol { get; set; }
    }
}