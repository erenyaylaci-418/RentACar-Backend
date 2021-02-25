using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete.ImageEntity;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandImageManager : IBrandImageService
    {
        //TODO

        public IResult Add(BrandImage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BrandImage entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BrandImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<BrandImage> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Upgrade(BrandImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
