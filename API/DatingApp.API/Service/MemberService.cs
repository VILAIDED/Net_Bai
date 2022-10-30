using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using DatingApp.API.Enities;
using DatingApp.API.Profiles;

namespace DatingApp.API.Service
{
    public class MemberService : IMemberService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public MemberService(DataContext context,IMapper mapper){
            _mapper = mapper;
            _context = context;
        }
        public MemberDto GetMemberByUsername(string username)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.Username == username);
            if(user == null) return null;

          return _mapper.Map<User,MemberDto>(user);
        }

        public List<MemberDto> GetMembers()
        {
            return _context.AppUsers.ProjectTo<MemberDto>(_mapper.ConfigurationProvider).ToList();
            // return _mappper.Map<List<User>,List<MemberDto>
        }
    }
}