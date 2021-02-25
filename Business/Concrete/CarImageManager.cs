using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.ImageEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage entity)
        {
            _carImageDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(CarImage entity)
        {
            _carImageDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            var result = _carImageDal.GetAll();
            return new SuccessDataResult<List<CarImage>>(result);
        }

        public IDataResult<CarImage> GetById(int Id)
        {
            CarImage result = _carImageDal.Get(c=>c.Id == Id);
            return new SuccessDataResult<CarImage>(result);
        }

        public IResult Upgrade(CarImage entity)
        {
            _carImageDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
