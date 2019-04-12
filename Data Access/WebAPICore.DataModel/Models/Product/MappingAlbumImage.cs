using System;

namespace WebAPICore.DataModel.Models
{
    public class MappingAlbumImage:BaseEntity
    {
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}