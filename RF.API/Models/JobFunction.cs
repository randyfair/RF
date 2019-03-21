namespace RF.API.Models
{
    public class JobFunction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}