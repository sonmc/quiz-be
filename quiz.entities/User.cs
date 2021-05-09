
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quiz.entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Role { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
