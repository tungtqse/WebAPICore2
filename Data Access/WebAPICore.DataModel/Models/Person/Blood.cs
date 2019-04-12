using System;
using System.Collections.Generic;

namespace WebAPICore.DataModel.Models
{
    public class Blood : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Idol> Idols { get; set; }
    }
}