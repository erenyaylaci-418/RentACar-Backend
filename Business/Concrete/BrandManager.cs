using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [SecuredOperation("admin,RentacarEmployee")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Brand entity)
        {
            if (entity.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.NameInvalid);
            }
            _brandDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
        [SecuredOperation("admin,RentacarEmployee")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);


        }
        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.Listed);
        }
        [CacheAspect]
        public IDataResult<Brand> GetById(int Id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == Id));
        }

        [SecuredOperation("admin,RentacarEmployee")]
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Upgrade(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.Upgraded);
        }
    }
}
