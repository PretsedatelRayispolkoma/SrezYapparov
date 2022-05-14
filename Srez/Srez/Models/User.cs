using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Srez.Models
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        [Unique]
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }

        public static List<User> GetUserList()
        {
            return new List<User>
            {
                new User { Login = "diyar123", Password = "123123", RoleID = 1},
                new User { Login = "petuch228", Password = "qwerty", RoleID = 2}
            };
        }
    }
}
