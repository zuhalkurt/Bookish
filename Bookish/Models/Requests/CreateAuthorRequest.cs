using Bookish.Models.Database;

namespace Bookish.Models.Requests
{
    public class CreateAuthorRequest
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
    }
}