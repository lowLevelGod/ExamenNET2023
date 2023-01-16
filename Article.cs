using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelExam2022
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Titlu obligatoriu")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Continut obligatoriu")]
        public String Content { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
