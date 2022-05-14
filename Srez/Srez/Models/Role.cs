using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Srez.Models
{
    [Table("Role")]
    public class Role
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
