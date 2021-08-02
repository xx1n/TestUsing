using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using AutomaticTest.untils;
using static System.Console;
using System.Threading.Tasks;

namespace AutomaticTest.data
{
    class DataBases
    {
        public DataBases()
        {
            var conn = new MySqlConnection(ConnectionString());
        }

        private string server;
        private string database;
        private string userID;
        private string password;
        public string ConnectionString()
        {
            server = ReadConfigs.CONFIG_DIC["server"];
            database = ReadConfigs.CONFIG_DIC["database"];
            userID = ReadConfigs.CONFIG_DIC["user"];
            password = ReadConfigs.CONFIG_DIC["password"];
            string connectString = server + ";" + database + ";" + userID + ";" + password + ";";
            return connectString;
        }

        public void Update()
        {
            using (var conn = new MySqlConnection(ConnectionString()))
            {

            }
           //AddAsync();
        }
        //public async Task AddAsync()
        //{
        //    WriteLine("链接到数据库");
        //    //await conn.OpenAsync();
        //    //using (var command = conn.CreateCommand())
        //    //{
        //    //    command.CommandText = "INSERT INTO xx VALUES()";
        //    //    command.Parameters.AddWithValue("", "");
        //    //    int rowCount = await command.ExecuteNonQueryAsync();
        //    //}


        //}
        public void Delete()
        {

        }

        public void Select()
        {

        }

        public void Alter()
        {

        }
        public void t()
        {
            string sqlConnect = "server=localhost;port=3306;user=root;password=123456; database=item_info;";
            MySqlConnection conn = new MySqlConnection(sqlConnect);
            try
            {
                conn.Open();//建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里可以使用代码对数据库进行增删查改的操作
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);//有错则报出错误
            }
            //      var command = conn.CreateCommand();
            //      command.CommandText = "select * from weapon_blade";
            //      //string sql = "select * from weapon_blade";
            //      var reader = command.ExecuteReader();
            //      while (reader.Read())
            //      {
            //          Console.WriteLine(string.Format(
            //"Reading from table=({0}, {1}, {2})",
            //reader.GetValue(0),
            //reader.GetValue(1),
            //reader.GetValue(2)));
            //      }

            var command = conn.CreateCommand();
            command.CommandText = "UPDATE weapon_blade set blade_id  = 12009 WHERE blade_id = 12006";
            int count = command.ExecuteNonQuery();
            Console.WriteLine(count);

            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //MySqlDataReader reader = cmd.ExecuteReader();
            ////Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
            ////Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
            ////Console.WriteLine(reader.GetInt32("userid") + reader.GetString("username") + reader.GetString("password"));//"userid"是数据库对应的列名，推荐这种方式
            //while (reader.Read())
            //{
            //    string str = reader["blade_name"].ToString();
            //    Console.WriteLine(reader);
            //    //Console.WriteLine(str);
            //}
        }
    }
}
