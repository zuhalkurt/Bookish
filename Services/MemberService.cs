using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public interface IMemberService
    {
        public List<Member> GetAllMembers();
    }
    public class MemberService : IMemberService
    {
        private IMemberRepo _members;

        public MemberService(IMemberRepo members)
        {
            _members = members;
        }

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