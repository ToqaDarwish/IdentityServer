using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOne.Controller
{
    public class SecretController : ControllerBase
    {
        [Route("secret")]
        [Authorize]
        public string Index()
        {
            return "secret message from ApiOne";
        }
    }
}
