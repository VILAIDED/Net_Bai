using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs;

public class MemberDto{
    public string Username { get; set; }
        public string Email { get; set; }
        public string Age {get;set;}
        public DateTime? DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string City { get; set; }
        public string Avatar { get; set; }

}
