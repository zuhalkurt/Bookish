using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
       public class MemberService
    {
        public MemberRepo _members = new MemberRepo();   

        public List<Member> GetAllMembers()
        {
            var members = new List<Member>();
            var dbMembers = _members.GetAllMembers();

            foreach (var member in dbMembers)
            {
                 members.Add(
                    new Member
                    {
                        Name = member.Name,
                        Email = member.Email,
                        PhoneNumber = member.PhoneNumber
                    }
                );
            }
            return members;
        }
    }
}