using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DebugOnProdC31.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LicensesController : ControllerBase
    {
        public string Mit()
        {
            return "blah blah blah";
        }
    }
}