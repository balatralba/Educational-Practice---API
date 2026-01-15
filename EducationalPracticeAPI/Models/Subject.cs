using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalPracticeAPI.Models
{
    [Table("subject")]
    public class Subject
    {
        [Key]
        [Column("subject_id")]
        public int SubjectId { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;
    }
}
