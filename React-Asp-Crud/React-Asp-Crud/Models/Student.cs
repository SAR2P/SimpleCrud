using System.ComponentModel.DataAnnotations;

namespace React_Asp_Crud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string StName { get; set; } = string.Empty;

        public string Course { get; set; } = string.Empty;
    }
}
