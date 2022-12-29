using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut()]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete()]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
