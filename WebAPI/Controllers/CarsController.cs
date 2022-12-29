using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        
        
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut()]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete()]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
