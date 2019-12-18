using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase, ICommonController<UserAccount,int>
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_userService.FindAll());
        }
        [HttpGet("{keyword}/{page}/{pageSize}")]
        public async Task<IActionResult> GetAll(string keyword,int page,int pageSize)
        {
            return Ok(_userService.FindAllPaging(keyword,page,pageSize));
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserAccount userAccount)
        {
            _userService.Add(userAccount);
            try
            {
                _userService.Save();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();

            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UserAccount userAccount)
        {
            _userService.Add(userAccount);
            try
            {
                _userService.Save();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();

            }
        }
        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            _userService.Remove(id);
            try
            {
                _userService.Save();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();

            }
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_userService.FindById(id));
        }
    }
}