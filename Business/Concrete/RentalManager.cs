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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

            public RentalManager(IRentalDal rentalDal)
            {
                _rentalDal = rentalDal;
            }

            public IResult Add(Rental entity)
            {
                _rentalDal.Add(entity);
                return new SuccessResult(Messages.Added);
            }

            public IResult Delete(Rental entity)
            {
                _rentalDal.Delete(entity);
                return new SuccessResult(Messages.Deleted);
            }

            public IDataResult<List<Rental>> GetAll()
            {
                return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
            }

            public IDataResult<Rental> GetById(int Id)
            {
                return new SuccessDataResult<Rental>(_rentalDal.Get(u => u.Id == Id));
            }

            public IResult Upgrade(Rental entity)
            {
                _rentalDal.Update(entity);
                return new SuccessResult(Messages.Upgraded);
            }
        }
}
