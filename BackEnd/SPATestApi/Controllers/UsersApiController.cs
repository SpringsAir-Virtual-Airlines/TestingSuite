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
        [HttpGet("GetUser")]
        public IActionResult GetUsers()
        {
            try
            {
              return Ok(repo.GetUsers());
            }
            catch (System.Exception)
            {
                
                throw new NotImplementedException("This is a working progress");
            }
        }
    }
}
