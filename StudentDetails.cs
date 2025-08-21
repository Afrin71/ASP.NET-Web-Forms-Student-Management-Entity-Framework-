namespace EntityFramework
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("TestConnection")
        {
        }
        public DbSet<StudentDetails> StudentDbset { get; set; }
    }
    public class StudentDetails
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int? Age { get; set; }
    }
}
