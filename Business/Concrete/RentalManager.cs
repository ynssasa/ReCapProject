using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var carToRent = _rentalDal.Get(r => r.CarId == rental.CarId);
            
            //added ile desc sıralamayı ayarla çünkü eklenecek araba ıd sinin en son hali önemli
            if (carToRent.ReturnDate.HasValue )
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.RentalNotAdded);
            

        }

        public IResult CheckRentalReturnDate(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
