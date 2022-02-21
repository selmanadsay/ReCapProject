using Business.Abstract;
using Business.Concrete.Constans;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
           _carDal= carDal; 
        }
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }



        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //business codes
            if (car.DailyPrice < 0)
            {
                return new ErrorResult("fiyat 0 dan büyük olmalı");
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAddedd);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p => p.BrandId == id));
        } 

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p => p.ColorId == id)) ;
        }


        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarAddedd);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDelete);

        }
    }
}
