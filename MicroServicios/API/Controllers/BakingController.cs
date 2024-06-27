
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
        [Route("api/[controller]")]
        public class BakingController : ControllerBase
        {
            private readonly IAccountServices _accountServices;
            public BakingController(IAccountServices accountServices)
            {
                _accountServices = accountServices;
            }
            [HttpGet]
            public ActionResult<IEnumerable<Account>> Get()
            {
                var algo = _accountServices.GetAccounts();
                return Ok(_accountServices.GetAccounts());
            }


        }
    }
 
