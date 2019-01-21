using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SendSMS.Models;

namespace SendSMS.Data
{
    class DbManager : IDisposable
    {
        private const string databaseFileName = "b2b.db"; //Path.Combine(Application.StartupPath, "messenger.db");

        private readonly SQLiteConnection connection;

        public DbManager()
        {
            var conn = new SQLiteConnectionStringBuilder { DataSource = databaseFileName };

            connection = new SQLiteConnection(conn.ConnectionString);
            connection.Open();
        }

        public static string DatabaseFileName
        {
            get
            {
                return databaseFileName;
            }
        }

        public void Dispose()
        {
            connection.Dispose();
        }

        #region Groups

        public long? GetGroupIdByName(string name)
        {
            var groupOperation = new GroupOperation(connection);
            return groupOperation.GetGroupIdByName(name);

        }

        public long SaveGroup(Group group)
        {
            var groupOperation = new GroupOperation(connection);
            return groupOperation.Save(group);
        }

        public void UpdateGroup(Group group)
        {
            var groupOperation = new GroupOperation(connection);
            groupOperation.Update(group);
        }

        public void DeleteGroup(Group group)
        {
            var groupOperation = new GroupOperation(connection);
            groupOperation.Delete(group);
        }

        public List<Group> GetGroups()
        {
            var groupOperation = new GroupOperation(connection);
            return groupOperation.GetGroups();
        }
#endregion


        #region Contacts

        public long SaveContact(Contact contact)
        {
            var contactOperation = new ContactOperation(connection);
            return contactOperation.Save(contact);
        }

        public void UpdateContact(Contact contact)
      {
          var contactOperation = new ContactOperation(connection);
            contactOperation.Update(contact);
        }

        public void DeleteContact(Contact contact)
        {
            var contactOperation = new ContactOperation(connection);
            contactOperation.Delete(contact);
        }

        public List<Contact> GetContacts()
        {
            var contactOperation = new ContactOperation(connection);
            return contactOperation.GetContacts();
        }

        public List<Contact> GetContactsByGroup(long id)
        {
            var contactOperation = new ContactOperation(connection);
            if (id == 0)
                return contactOperation.GetContacts();
            return contactOperation.GetContacts(id);
        }

        public Contact GetContactByPhone(string phone)
        {
            var contactOperation = new ContactOperation(connection);
            return contactOperation.GetContactByPhone(phone);
        }
        #endregion

        public void SetCredentials(string login, string password)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"delete from auth; insert into auth(login, password) values (?, ?);";
                cmd.Parameters.Add(new SQLiteParameter { Value = login });
                cmd.Parameters.Add(new SQLiteParameter { Value = password });
                cmd.ExecuteNonQuery();
            }
        }

        public User GetCredentials()
        {
            var user = new User();
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"select login, password from auth";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Login = reader["login"].ToString();
                        user.Password = reader["password"].ToString();
                    }
                }
            }
            return user;
        }

        public string GetSender()
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"select sender from senders";
                return (string) cmd.ExecuteScalar();
            }
        }

        public void SetSender(string sender)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"delete from senders; insert into senders(sender) values(?);";
                cmd.Parameters.Add(new SQLiteParameter { Value = sender });
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveSettings(Dictionary<string, string> settings)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"delete from settings;";
                cmd.ExecuteNonQuery();
            }

            foreach (var setting in settings)
            {
                using (SQLiteCommand cmd = this.connection.CreateCommand())
                {
                    cmd.CommandText = @"insert into settings(setting_key, setting_value) values(?, ?);";
                    cmd.Parameters.Add(new SQLiteParameter { Value = setting.Key });
                    cmd.Parameters.Add(new SQLiteParameter { Value = setting.Value });
                    cmd.ExecuteNonQuery();
                }               
            }
        }

        public Dictionary<string, string> LoadSettings()
        {
            var settings = new Dictionary<string, string>();
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"select setting_key, setting_value from settings";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        settings.Add(reader["setting_key"].ToString(), reader["setting_value"].ToString());
                    }
                }
            }
            return settings;
        }

        public long SaveDelivery(string name)
        {
            var operation = new DeliveryOperation(connection);
            return operation.Save(name);
        }

        public List<Delivery> GetDeliveries()
        {
            var operation = new DeliveryOperation(connection);
            return operation.GetDeliveries();
        }

        public List<Message> GetMessagesByDelivery(long id)
        {
            var operation = new DeliveryOperation(connection);
            return operation.GetMessagedByDelivery(id);
        }

        public void SaveMessage(Message message)
        {
            var operation = new DeliveryOperation(connection);
            operation.SaveMessage(message);
        }

        public void UpdateMessage(Message message)
        {
            var operation = new DeliveryOperation(connection);
            operation.UpdateMessage(message);
        }

        public List<string> ExportToCsv()
        {
            var str = new List<string>();
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"select ifnull(g.name,'') || ';' || c.phone || ';' || c.lastname || ';' || c.firstname || ';' || c.patronymic || ';' || c.sex || ';' || ifnull(c.birthday_day,'') || '.' || ifnull(c.birthday_month,'') || '.' || ifnull(c.birthday_year,'') from contacts c left join groups g on c.group_id = g.id ";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        str.Add(reader[0].ToString().Replace("..", ""));
                    }
                }
            }
            return str;
        }
    }
}
