using System;

namespace WebAPICore.DataModel.Models
{
    public class MappingMovieCategory : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}