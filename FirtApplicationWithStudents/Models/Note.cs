using System;
using System.ComponentModel.DataAnnotations;

namespace FirtApplicationWithStudents.Models
{
    public class Note
    {
        public int Id { get; set; }
        [MaxLength(10,ErrorMessage ="Titlemiz 10tadan oshmasligi kerak!")]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
    }
}
