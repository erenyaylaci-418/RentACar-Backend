using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAllService<T>
        where T:class,new()
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IResult Delete(T entity);
        IResult Upgrade(T entity);
        IDataResult<T> GetById(int Id);

    }
}
