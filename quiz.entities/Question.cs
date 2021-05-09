


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quiz.entities
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public int QuestionType { get; set; }
        public float Mark { get; set; }
        public int CategoryId { get; set; }
        public int ExamId { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
