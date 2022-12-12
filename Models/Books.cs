using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Books
    {
       
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTittle { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string BookGenre { get; set; }
        public string BookEdition { get; set; }
       
        public float BookPrice { get; set; }

        public int BookStock { get; set; }
        public int AvailableStock { get; set; }
        public string Language { get; set; }
    }

}
