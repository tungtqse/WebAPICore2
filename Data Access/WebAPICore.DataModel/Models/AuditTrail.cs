using System;

namespace WebAPICore.DataModel.Models
{
    public class AuditTrail : BaseEntity
    {
        public string TableName { get; set; }
        public Guid ItemId { get; set; }
        public string TrackChange { get; set; }
        public string TransactionId { get; set; }
    }
}
