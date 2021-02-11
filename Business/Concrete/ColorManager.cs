using Business.Abstract;
using Business.Constants;
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

        public IResult Add(Color entity)
        {
            if (entity.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.NameInvalid);
            }
            _colorDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

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
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == Id), Messages.Listed);
        }

        public IResult Upgrade(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.Upgraded);
        }
    }
}
