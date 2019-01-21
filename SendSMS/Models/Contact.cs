using System;

namespace SendSMS.Models
{
    public class Contact
    {
        public long Id { get; set; }
        public Group Group { get; set; }
        public string Phone { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Patronymic { get; set; }
        public int Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Message { get; set; }
        public string MessageId { get; set; }
        public int? BirthdayDay { get; set; }
        public int? BirthdayMonth { get; set; }
        public int? BirthdayYear { get; set; }

        protected bool Equals(Contact other)
        {
            return string.Equals(Phone, other.Phone);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Contact) obj);
        }

        public override int GetHashCode()
        {
            return (Phone != null ? Phone.GetHashCode() : 0);
        }
    }
}
