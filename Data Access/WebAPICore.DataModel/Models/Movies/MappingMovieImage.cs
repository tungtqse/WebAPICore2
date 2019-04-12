using System;

namespace WebAPICore.DataModel.Models
{
    public class MappingMovieImage : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}