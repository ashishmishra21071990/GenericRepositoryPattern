using System.ComponentModel.DataAnnotations;

namespace GenericRepostoryPatternCore.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string ?Sname { get; set; }
        public int Sage { get; set; }
        public string ?SAddress { get; set; }
    }
}
