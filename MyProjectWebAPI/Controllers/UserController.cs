using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using Entity;
using BL;
using System.Threading.Tasks;
using AutoMapper;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProjectWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {

        //BLClass bl = new BLClass();
        IUserBL _userBL;
        IMapper _mapper;
        public UserController(IUserBL userBL, IMapper mapper)
        {
            _userBL = userBL;
            _mapper = mapper;
        }
        // GET: api/<UserController>
        [HttpGet("{Email}/{Password}")]
        public async Task<ActionResult<User>> Get(string Email, string Password)
        {
            //M:/API/MyProjectWebAPI/MyProjectWebAPI/
            User user = await _userBL.GetBL(Email, Password);
            if (user != null)
                return Ok(user);
            return NoContent();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get1(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<User> Post([FromBody] UserDTO user)
        {
            {
                User userr = _mapper.Map<UserDTO, User>(user);
                return await _userBL.PostBL(userr);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] UserDTO userToUpdate)
        {
            { 
                await _userBL.PutBL(id, _mapper.Map<User>(userToUpdate));
            }

            
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
} 
