using System.Collections.Generic;

namespace WebAPICore.DataModel.Models
{
    public class Category: BaseEntity
    {
        public string Name{get;set;}
        public ICollection<MappingMovieCategory> MovieCategories { get; set; }
    }
}