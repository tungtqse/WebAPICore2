using System;

namespace WebAPICore.DataModel.Models
{
    public class MappingMovieIdol : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Guid IdolId { get; set; }
        public Idol Idol { get; set; }
    }
}