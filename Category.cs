using System.ComponentModel.DataAnnotations;

namespace ModelExam2022
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; }
    }
}
