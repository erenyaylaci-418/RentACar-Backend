using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car entity)
        {
            _carDal.Add(entity);
            return new SuccessResult(Messages.Added);

        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public SuccessDataResult<List<Car>> GetAllByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id),Messages.Listed);
        }

        public SuccessDataResult<List<Car>> GetAllByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id), Messages.Listed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == Id));
        }

        public SuccessDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Upgrade(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult(Messages.Upgraded);
        }
    }
}
