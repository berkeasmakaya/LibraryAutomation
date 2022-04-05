using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTypeController : ControllerBase
    {
        IBookTypeService _bookTypeService;
        public BookTypeController(IBookTypeService bookTypeService)
        {
            _bookTypeService = bookTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int bookTypeId)
        {
            var result = _bookTypeService.GetById(bookTypeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(BookType bookType)
        {
            var result = _bookTypeService.Add(bookType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(BookType bookType)
        {
            var result = _bookTypeService.Delete(bookType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(BookType bookType)
        {
            var result = _bookTypeService.Update(bookType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
