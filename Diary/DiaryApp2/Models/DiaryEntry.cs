using System.ComponentModel.DataAnnotations;

namespace DiaryApp2.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        //public string? Title1 { get; set; }
        //public required string Title2 { get; set; }
        //public string Title3 { get; set; } = string.Empty;
        public string Content { get; set; }
        public DateTime Creation { get; set; }

    }
}
