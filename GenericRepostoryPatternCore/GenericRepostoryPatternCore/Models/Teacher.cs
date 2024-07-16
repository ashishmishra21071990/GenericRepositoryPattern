using System.ComponentModel.DataAnnotations;

namespace GenericRepostoryPatternCore.Models
{
    public class Teacher
    {
        [Key]
        public int Tid { get; set; }
        public string? Tname { get; set; }
        public int Age { get; set; }
        public string? TSubject { get; set; }
    }
}
