using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoTask.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate  { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public PrioritySet Priority { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public StatusSet Status { get; set; }


        public enum PrioritySet
        {
            Low,
            High,
            Medium
        }

        public enum StatusSet
        {
            Completed,
            Pending
        }
    }
}
