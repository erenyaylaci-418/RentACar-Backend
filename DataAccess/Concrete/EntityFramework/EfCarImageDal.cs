using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.ImageEntity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : IEntityRepositoryBase<CarImage, CarSystemDBContext>, ICarImageDal
    {
    }
}
