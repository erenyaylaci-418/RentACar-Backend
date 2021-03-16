using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IAllService<Car>
    {
        SuccessDataResult<List<CarDetailDto>> GetCarDetails();
        SuccessDataResult<List<Car>> GetAllByColorId(int Id);
        SuccessDataResult<List<Car>> GetAllByBrandId(int Id);
        SuccessDataResult<List<CarDetailDto>> GetAllByBrandIdByDto(int ıd);
        SuccessDataResult<List<CarDetailDto>> GetAllByColorIdByDto(int ıd);
        SuccessDataResult<List<CarDetailDto>> GetAllByCarIdByDto(int Id);
    }
}
