using DatingApp.API.DTOs;
 
namespace DatingApp.API.Service
{
    public interface IMemberService
    {
        List<MemberDto> GetMembers();
        MemberDto GetMemberByUsername(string username);
    }
}
