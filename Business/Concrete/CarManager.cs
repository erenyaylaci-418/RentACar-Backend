using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;
        IColorService _colorService;
        public CarManager(ICarDal carDal, IBrandService brandService,IColorService colorService)
        {
            _carDal = carDal;
            _brandService = brandService;
            _colorService = colorService;
        }
        //[SecuredOperation("admin,RentacarEmployee")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car entity)
        {
            _carDal.Add(entity);
            return new SuccessResult(Messages.Added);

        }
        [SecuredOperation("admin,RentacarEmployee")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }
        [CacheAspect]
        public SuccessDataResult<List<Car>> GetAllByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id),Messages.Listed);
        }
        [CacheAspect]
        public SuccessDataResult<List<Car>> GetAllByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id), Messages.Listed);
        }
        [CacheAspect]
        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == Id));
        }
        [CacheAspect]
        public SuccessDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        [SecuredOperation("admin,RentacarEmployee")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Upgrade(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult(Messages.Upgraded);
        }
        [CacheAspect]
        public SuccessDataResult<List<CarDetailDto>> GetAllByBrandIdByDto(int Id)
        {
            var result = _brandService.GetById(Id);
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(cto => cto.BrandName == result.Data.BrandName), Messages.Listed);
        }
        [CacheAspect]
        public SuccessDataResult<List<CarDetailDto>> GetAllByColorIdByDto(int Id)
        {
            var result = _colorService.GetById(Id);
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(cto => cto.ColorName == result.Data.ColorName), Messages.Listed);
        }
        [CacheAspect]
        public SuccessDataResult<List<CarDetailDto>> GetAllByCarIdByDto(int Id)
        {
          
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(cto => cto.CarId == Id), Messages.Listed);
        }
    }
}
