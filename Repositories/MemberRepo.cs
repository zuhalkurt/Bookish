using Bookish.Models.Database;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class MemberRepo
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