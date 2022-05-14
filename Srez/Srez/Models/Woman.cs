using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Srez.Models
{
    [Table("Woman")]
    public class Woman
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsMuslim { get; set; }
    }
}
