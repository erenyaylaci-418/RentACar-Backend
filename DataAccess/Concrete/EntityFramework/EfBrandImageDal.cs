using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.ImageEntity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandImageDal :EfEntityRepositoryBase<BrandImage,CarSystemDBContext> ,IBrandImageDal
    {
    }
}
