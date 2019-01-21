using System;

namespace SendSMS.Models
{
    public class Delivery
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int Sent { get; set; }
        public int Delivered { get; set; }
    }
}
