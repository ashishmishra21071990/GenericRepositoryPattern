using System.ComponentModel.DataAnnotations;

namespace GenericRepostoryPatternCore.Models
{
    public class School
    {
        [Key]
        public int School_Id { get; set; }
        public string ?School_Name { get; set; }
        public string  ?School_City { get; set; }
    }
}
