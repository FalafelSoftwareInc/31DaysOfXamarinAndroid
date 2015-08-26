using System;
using SQLite;

namespace SqliteSample
{
    [Table("Todo")]
    public class ToDoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}

        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsComplete { get; set; }

        [Ignore]
        public string ReadableTitle
        {
            get
            {
                return Title.ToString() + " Created At " + CreatedAt.ToLocalTime().ToShortDateString();
            }
                
        }

    }
}

