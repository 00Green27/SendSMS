using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using SendSMS.Models;

namespace SendSMS.Data
{
    using System.Linq;

    public class ContactOperation
    {
        private readonly SQLiteConnection connection;
        private SQLiteCommand insertContactCommand;

        public ContactOperation(SQLiteConnection connection)
        {
            this.connection = connection;
        }

        public long Save(Contact contact)
        {
            long id;
            PrepareToSaveContact(contact);
            using (SQLiteTransaction transaction = this.connection.BeginTransaction())
            {
                this.insertContactCommand.Connection = this.connection;
                using (SQLiteCommand cmd = this.insertContactCommand)
                {
                    id = (long)cmd.ExecuteScalar();
                }
                transaction.Commit();
            }
            return id;
        }

        public Contact GetContact(int id)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "select * from contacts c join groups g on c.group_id = g.id where c.id = ?";
                cmd.Parameters.Add(new SQLiteParameter { Value = id });
                DataRow row = LoadDataFromCommand(cmd).Rows[0];
                return FillContact(row);
            }
        }

        public Contact GetContactByPhone(string phone)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "select * from contacts c left join groups g on c.group_id = g.id where c.phone = ?;";
                cmd.Parameters.Add(new SQLiteParameter { Value = phone });
                DataTable table = LoadDataFromCommand(cmd);
                if (table.Rows.Count == 0) return null;
                DataRow row = table.Rows[0];
                return FillContact(row);
            }
        }

        public List<Contact> GetContacts()
        {
            var contacts = new List<Contact>();
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "select * from contacts c left join groups g on c.group_id = g.id";
                var dataTable = LoadDataFromCommand(cmd);

                contacts.AddRange(from DataRow row in dataTable.Rows select this.FillContact(row));
                return contacts;
            }
        }

        public List<Contact> GetContacts(long id)
        {
            var contacts = new List<Contact>();
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "select * from contacts c join groups g on c.group_id = g.id where group_id = ?";
                cmd.Parameters.Add(new SQLiteParameter { Value = id });
                var dataTable = LoadDataFromCommand(cmd);

                contacts.AddRange(from DataRow row in dataTable.Rows select this.FillContact(row));
                return contacts;
            }
        }

        public static DataTable LoadDataFromCommand(SQLiteCommand command)
        {
            var adapter = new SQLiteDataAdapter(command);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset.Tables["table"];
        }

        public Contact FillContact(DataRow row)
        {
            var contact = new Contact
                {
                    Id = Convert.ToInt64(row["id"]),
                    Sex = Convert.ToInt32(row["sex"]),
                    Phone = row["phone"].ToString(),
                    LastName = row["lastname"].ToString(),
                    FirstName = row["firstname"].ToString(),
                    Patronymic = row["patronymic"].ToString()
                };
            contact.Sex = Convert.ToInt32(row["sex"]);
            if (!DBNull.Value.Equals(row["birthday_day"])) contact.BirthdayDay = Convert.ToInt32(row["birthday_day"]);
            if (!DBNull.Value.Equals(row["birthday_month"])) contact.BirthdayMonth = Convert.ToInt32(row["birthday_month"]);
            if (!DBNull.Value.Equals(row["birthday_year"])) contact.BirthdayYear = Convert.ToInt32(row["birthday_year"]);

//            if (!DBNull.Value.Equals(row["birthday"]))
//                contact.Birthday = Convert.ToDateTime(row["birthday"]);
            contact.Group = new Group { Id = TryToParse(row["group_id"].ToString()), Name = Convert.ToString(row["name"]) };

            return contact;
        }

        private long TryToParse(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                return number;
            }
            return -1;
        }

        private void PrepareToSaveContact(Contact contact)
        {
            const string Sql = "insert into contacts(group_id, phone, lastname, firstname, patronymic, sex, birthday_day, birthday_month, birthday_year) values (" +
                               "@GroupId, @Phone, @LastName, @FirstName, @Patronymic, @Sex, @BirthdayDay, @BirthdayMonth, @BirthdayYear); SELECT last_insert_rowid();";
            this.insertContactCommand = new SQLiteCommand(Sql);
            this.insertContactCommand.Parameters.AddWithValue("@GroupId", contact.Group.Id);
            this.insertContactCommand.Parameters.AddWithValue("@Phone", contact.Phone);
            this.insertContactCommand.Parameters.AddWithValue("@LastName", contact.LastName);
            this.insertContactCommand.Parameters.AddWithValue("@FirstName", contact.FirstName);
            this.insertContactCommand.Parameters.AddWithValue("@Patronymic", contact.Patronymic);
            this.insertContactCommand.Parameters.AddWithValue("@Sex", contact.Sex);
            this.insertContactCommand.Parameters.AddWithValue("@BirthdayDay", contact.BirthdayDay);
            this.insertContactCommand.Parameters.AddWithValue("@BirthdayMonth", contact.BirthdayMonth);
            this.insertContactCommand.Parameters.AddWithValue("@BirthdayYear", contact.BirthdayYear);
        }


        public void Update(Contact contact)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"update contacts set group_id = @GroupId, phone = @Phone, lastname = @LastName, firstname = @FirstName, patronymic = @Patronymic, sex = @Sex, birthday_day = @BirthdayDay, birthday_month = @BirthdayMonth, birthday_year = @BirthdayYear where id = @Id;";
                cmd.Parameters.AddWithValue("@Id", contact.Id);
                cmd.Parameters.AddWithValue("@GroupId", contact.Group.Id);
                cmd.Parameters.AddWithValue("@Phone", contact.Phone);
                cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                cmd.Parameters.AddWithValue("@Patronymic", contact.Patronymic);
                cmd.Parameters.AddWithValue("@Sex", contact.Sex);
                cmd.Parameters.AddWithValue("@BirthdayDay", contact.BirthdayDay);
                cmd.Parameters.AddWithValue("@BirthdayMonth", contact.BirthdayMonth);
                cmd.Parameters.AddWithValue("@BirthdayYear", contact.BirthdayYear);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(Contact contact)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"delete from contacts where id = @Id;";
                cmd.Parameters.AddWithValue("@Id", contact.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}