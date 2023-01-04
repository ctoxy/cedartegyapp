using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController: BaseApiController
    {
       private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
            
        }
        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(42);

            if (thing == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok();
        }

        [HttpGet("servererror")]
        public ActionResult<string> GetServerError()
        {            
                var thing = _context.Products.Find(42);

                var thingToReturn = thing.ToString();

                return Ok();
        }

        [HttpGet("badRequest")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }
        [HttpGet("badRequest/{id}")]
        public ActionResult<string> GetNotFoundRequest(int id)
        {
            return Ok();
        }           
    }
}