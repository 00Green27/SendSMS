using System;

namespace SendSMS.Models
{
    class Message
    {
        public long Id { get; set; }
        public long DeliveryId { get; set; }
        public long ContactId { get; set; }
        public string MessageId { get; set; }
        public DateTime? ReportedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string Text { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
    }
}
