using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using SendSMS.Models;

namespace SendSMS.Data
{
    using System.Linq;

    public class GroupOperation
    {
        private readonly SQLiteConnection connection;

        public GroupOperation(SQLiteConnection connection)
        {
            this.connection = connection;
        }

        public long Save(Group group)
        {
            long id;
            using (SQLiteTransaction transaction = this.connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = this.connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO groups(name) VALUES (?);" +
                        "SELECT last_insert_rowid();";
                    cmd.Parameters.Add(new SQLiteParameter { Value = group.Name });
                    id = (long)cmd.ExecuteScalar();
                }
                transaction.Commit();
            }
            return id;
        }

        public List<Group> GetGroups()
        {
            var groups = new List<Group>();

            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"select count(id) from contacts;";
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                groups.Add(new Group { Count = count, Name =  "Все"});
            }

            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "select g.id, g.name, case when c.count is null then 0 else c.count end count from groups g left join (select group_id, count(id) count from contacts contact group by group_id) c on g.id = c.group_id";
                var dataTable = LoadDataFromCommand(cmd);

                groups.AddRange(from DataRow row in dataTable.Rows select this.FillContact(row));
                return groups;
            }
        }

        public static DataTable LoadDataFromCommand(SQLiteCommand command)
        {
            var adapter = new SQLiteDataAdapter(command);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset.Tables["table"];
        }

        public Group FillContact(DataRow row)
        {
            var group = new Group();
            group.Id = Convert.ToInt64(row["id"]);
            group.Name = row["name"].ToString();
            group.Count = Convert.ToInt32(row["count"]);
            return group;
        }

        public void Delete(Group group)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"delete from groups where id = @GroupId; update contacts set group_id = null where group_id = @GroupId";
                cmd.Parameters.AddWithValue("@GroupId", group.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Group group)
        {
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = @"update groups set name = @Name where id = @Id";
                cmd.Parameters.AddWithValue("@Name", group.Name);
                cmd.Parameters.AddWithValue("@Id", group.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public long? GetGroupIdByName(string name)
        {
            long? id;
            using (SQLiteCommand cmd = this.connection.CreateCommand())
            {
                cmd.CommandText = "SELECT id from groups where name = ?";
                cmd.Parameters.Add(new SQLiteParameter { Value = name });
                id = (long?)cmd.ExecuteScalar();
            }
            return id;
        }
    }
}