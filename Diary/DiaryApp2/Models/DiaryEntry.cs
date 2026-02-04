using System.ComponentModel.DataAnnotations;

namespace DiaryApp2.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        // public int DiaryEntryId { get; set; }
        //[Key]
        // public int SomeOtherNameId { get; set; }
        
        [Required]
        public required string Title { get; set; } = string.Empty;
        //public string? Title1 { get; set; }
        //public required string Title2 { get; set; }
        //public string Title3 { get; set; } = string.Empty;

        [Required] 
        public required string Content { get; set; } = string.Empty;

        [Required]
        public DateTime Creation { get; set; } = DateTime.Now;
        // public DateTime Creation { get; set; }
    }
}
