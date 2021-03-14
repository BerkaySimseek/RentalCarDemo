using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrate;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car); 
        IDataResult<Car> GetByColorId(int colorId);
        IDataResult<Car> GetByBrandId(int brandId);
        IDataResult<List<CarDetailsDTO>> GetDeails();
    }
}
