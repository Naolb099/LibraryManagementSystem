using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class BookIssue
    {
        [Key]
        public int Id{ get; set; }
        public string FullName { get; set; }
        public string BookTitle { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime Returndate { get; set; }
        public int BookId { get; set; }
        public string UserName { get; set; }


    }
}
