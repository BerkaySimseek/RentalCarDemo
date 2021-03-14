using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new ErrorDataResult<Car>(_carDal.Get(c => c.CarId == id));
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length <2 )
            {
                return new ErrorResult(Messages.ProductsNameInvalid);
            }

            if (car.DailyPrice <0)
            {
                return new ErrorResult(Messages.ProductsPriceInvalid);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.ProductsAdded);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.ProductsUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.ProductsDeleted);
        }

        public IDataResult<Car> GetByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ColorId == colorId));
        }

        public IDataResult<Car> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.BrandId == brandId));
        }

        public IDataResult<List<CarDetailsDTO>> GetDeails()
        {
            return new SuccessDataResult<List<CarDetailsDTO>>(_carDal.GetDeails());
        }
    }
}
