
using Microsoft.EntityFrameworkCore; 
namespace quiz.entities
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionExam> QuestionExam { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
