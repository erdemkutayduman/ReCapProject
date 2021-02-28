﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            
        }
        
        [SecuredOperation("product.add")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarIdExists(car.CarId));

            if (result != null)
            {
                return result;
            }


            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        
        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessDataResult<Car>(Messages.CarDeleted);

        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandid));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorid));
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetail(Expression<Func<Car, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetail(filter));
        }
        
        public IResult Update(Car entity)
        {
            
            _carDal.Add(entity);
            return new SuccessResult(Messages.CarUpdated);
        }

        private IResult CheckIfCarIdExists(int carId)
        {
            var result = _carDal.GetAll(p => p.CarId == carId).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            return new SuccessResult();
        }
    }
}
