using Core.Utilities.Results;
using Entities.Concrete.ImageEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService:IAllService<CarImage>
    {
        IDataResult<List<CarImage>> GetByCarId(int id);
    }
}
