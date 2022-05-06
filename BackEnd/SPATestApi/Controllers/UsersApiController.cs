using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaBl;

namespace SPATestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        //=============Dependance Injecgtion ============//
        private readonly ISpaBl repo;
        public UsersApiController(ISpaBl info)
        {
            repo = info;
        } 
        //=============================================//

        // GET: api/UsersApi/5
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            try
            {
              return Ok(repo.GetUsers());
            }
            catch (Exception ex)
            {
                
                return StatusCode(422, ex.Message);
            }
        }
    }
}
