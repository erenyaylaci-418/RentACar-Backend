using Business.Abstract;
using Core.Utilities.Helpers;
using Entities.Concrete.ImageEntity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {

        public static IWebHostEnvironment _webHostEnviroment;
        ICarImageService _carImageService;

        string path = @"C:/Users/ErenYaylaci/Desktop/software camping/ReCapProject/Images";

        public CarImageController(IWebHostEnvironment webHostEnviroment, ICarImageService carImageService)
        {
            _webHostEnviroment = webHostEnviroment;
            _carImageService = carImageService;
        }
        
        [HttpPost("add")]
        public IActionResult ImageAdd([FromForm] CarImage carImage)
        {
            
                if (carImage.ImageFile.Length > 0)
                {
                    //_webHostEnviroment.WebRootPath + "\\CarImages\\";
                    //Path.Combine(_webHostEnviroment.WebRootPath, "CarImages");
                if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                        
                    string extension = Path.GetExtension(carImage.ImageFile.FileName);
                    string guidFileName = Guid.NewGuid().ToString()+extension;

                        using (var fileStream = new FileStream(Path.Combine(path,guidFileName),FileMode.Create))
                        {
                            carImage.ImageFile.CopyToAsync(fileStream);
                        }

                    carImage.ImageName = guidFileName;
                _carImageService.Add(carImage);
                return Ok();
                }

            return BadRequest();
        }
        [HttpGet("delete")]
        public IActionResult Delete(int id)
        {

            var carImage = _carImageService.GetById(id).Data;

            
            FileHelper.Delete(path+"/"+carImage.ImageName);
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       

    }
}
