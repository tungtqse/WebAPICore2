using System;

namespace WebAPICore.DataModel.Models
{
    public class AttachmentFile : BaseEntity
    {
        public Guid ParentId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }
        public byte[] FileData { get; set; }
        public string Remarks { get; set; }
    }
}