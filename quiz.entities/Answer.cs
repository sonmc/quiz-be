

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quiz.entities
{
    public class Answer
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
    }
}
