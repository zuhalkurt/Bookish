namespace Bookish.Models.Database
{
    public class MemberDbModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public int? PhoneNumber { get; set; }
    }
}