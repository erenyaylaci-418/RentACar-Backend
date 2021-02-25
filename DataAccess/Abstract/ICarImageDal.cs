using Core.DataAccess;
using Entities.Concrete.ImageEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarImageDal:IEntityRepository<CarImage>
    {
    }
}
