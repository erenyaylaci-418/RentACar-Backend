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
    public class CostumerManager : ICostumerService
    {
            ICostumerDal _costumerDal;

            public CostumerManager(ICostumerDal costumerDal)
            {
                _costumerDal = costumerDal;
            }

            public IResult Add(Costumer entity)
            {
                _costumerDal.Add(entity);
                return new SuccessResult(Messages.Added);
            }

            public IResult Delete(Costumer entity)
            {
                _costumerDal.Delete(entity);
                return new SuccessResult(Messages.Deleted);
            }

            public IDataResult<List<Costumer>> GetAll()
            {
                return new SuccessDataResult<List<Costumer>>(_costumerDal.GetAll(), Messages.Listed);
            }

            public IDataResult<Costumer> GetById(int Id)
            {
                return new SuccessDataResult<Costumer>(_costumerDal.Get(u => u.Id == Id));
            }

            public IResult Upgrade(Costumer entity)
            {
                _costumerDal.Update(entity);
                return new SuccessResult(Messages.Upgraded);
            }
        }
}
