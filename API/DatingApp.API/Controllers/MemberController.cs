using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using DatingApp.API.Enities;
using DatingApp.API.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/members")]
    [ApiController]
    public class MemberController : BaseController
    {
        private readonly DataContext _context;
        private readonly IMemberService _memberService;
        public MemberController(DataContext dataContext,IMemberService memberService){
            _memberService = memberService;
            _context = dataContext;
        }
        [HttpGet]
        public IActionResult Get(){
            return Ok(_memberService.GetMembers());
        }

        [HttpGet("{username}")]
        public IActionResult GetMember(String username){
            return Ok(_memberService.GetMemberByUsername(username));
        }
    }
}