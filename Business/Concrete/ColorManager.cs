using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color entity)
        {
            if (entity.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.NameInvalid);
            }
            _colorDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Color> GetById(int Id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == Id), Messages.Listed);
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Upgrade(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.Upgraded);
        }
    }
}
