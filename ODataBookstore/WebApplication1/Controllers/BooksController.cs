using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataBookstore.Controllers
{
    public class BooksController : ODataController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
