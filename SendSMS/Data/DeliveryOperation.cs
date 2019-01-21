using System;
using System.Collections.Generic;
using System.Data.SQLite;

using SendSMS.Models;

namespace SendSMS.Data
{
    class DeliveryOperation
    {
        private readonly SQLiteConnection connection;

        public DeliveryOperation(SQLiteConnection connection)
        {
            this.connection = connection;
        }

        public long Save(string name)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"insert into delivery(name, created) values(?, ?); SELECT last_insert_rowid();";
                cmd.Parameters.Add(new SQLiteParameter { Value = name });
                cmd.Parameters.Add(new SQLiteParameter { Value = DateTime.Now });
                return (long)cmd.ExecuteScalar();
            }  
        }

        public List<Delivery> GetDeliveries()
        {
            var d = new List<Delivery>();
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"
select id, created, name, coalesce(sent, 0) sent, coalesce(delivered, 0) delivered from delivery d left join
(
    select delivery_id,
    sum(case when status = -1 or status = 0 then 1 else 0 end) sent,
    sum(case when status = 0 then 1 else 0 end) delivered
    from messages where status in (-1, 0) group by delivery_id 
) m on d.id = m.delivery_id order by created desc
;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        d.Add(new Delivery
                                  {
                                      Id = Int64.Parse(reader["id"].ToString()), 
                                      Name = reader["name"].ToString(),
                                      CreatedDate = DateTime.Parse(reader["created"].ToString()),
                                      Sent = Int32.Parse(reader["sent"].ToString()),
                                      Delivered = Int32.Parse(reader["delivered"].ToString())

                                  });
                    }
                }
            }
            return d;
        }

        public List<Message> GetMessagedByDelivery(long id)
        {
            var d = new List<Message>();
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"select * from messages where delivery_id = ?;";
                cmd.Parameters.Add(new SQLiteParameter { Value = id });
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        d.Add(new Message { 
                            Id = Int64.Parse(reader["id"].ToString()),
                            SubmittedDate = reader["submitted_date"] == DBNull.Value ? (DateTime?) null : DateTime.Parse(reader["submitted_date"].ToString()),
                            ReportedDate = reader["reported_date"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(reader["reported_date"].ToString()),
                            Phone = reader["phone"].ToString(),
                            Text = reader["message"].ToString(),
                            MessageId = reader["message_id"].ToString(),
                            Status = Int32.Parse(reader["status"].ToString())

                        });
                    }
                }
            }
            return d;
        }

        public void SaveMessage(Message message)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"insert into messages(delivery_id, message_id, reported_date, submitted_date,  phone, message, status) values(?, ?, ?, ?, ?, ?, ?);";
                cmd.Parameters.Add(new SQLiteParameter { Value = message.DeliveryId });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.MessageId });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.ReportedDate });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.SubmittedDate });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.Phone });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.Text });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.Status });
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMessage(Message message)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"update messages set reported_date=? , submitted_date=?, status=? where id=?";
                cmd.Parameters.Add(new SQLiteParameter { Value = message.ReportedDate });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.SubmittedDate });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.Status });
                cmd.Parameters.Add(new SQLiteParameter { Value = message.Id });
                cmd.ExecuteNonQuery();
            }
        }
    }
}
