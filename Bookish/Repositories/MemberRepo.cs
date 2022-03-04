using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories
{
    public interface IMemberRepo
    {
        public List<MemberDbModel> GetAllMembers();
    }
    public class MemberRepo : IMemberRepo
    {
        private BookishContext context = new BookishContext();
        public List<MemberDbModel> GetAllMembers()
        {
            return context
             .Members
             .ToList();
        } 
    }
}