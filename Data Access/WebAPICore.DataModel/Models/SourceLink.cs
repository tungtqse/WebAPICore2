using System;

namespace WebAPICore.DataModel.Models
{
    public class SourceLink : BaseEntity
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string DownloadLink { get; set; }
        public string Resolution { get; set; }
        public string Server { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}