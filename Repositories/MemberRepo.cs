using Bookish.Models.Database;
namespace Bookish.Repositories
{
    public class MemberRepo
    {
        public List<MemberDbModel> GetAllMembers()
        {
            return new List<MemberDbModel>
            {
                new MemberDbModel
                {
                    Id = 1,
                    Name = "Tom Hardy",
                },
                 new MemberDbModel
                {
                    Id = 2,
                    Name = "Chris Hemsworth",
                },
                new MemberDbModel
                {
                    Id = 3,
                    Name = "Liv Tyler",
                }
            };
        }
    }
}