using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarDal _carDal;
        public RentalManager(IRentalDal rentalDal, ICarDal carDal)
        {
            _rentalDal = rentalDal;
            _carDal = carDal;
        }

        public IResult Add(Rental rental)
        {
            foreach (var rent in _rentalDal.GetAll())
            {
                if (rent.CarId == rental.CarId && rent.ReturnDate == null)
                    return new ErrorResult("Could not add rental.");
            }
            _rentalDal.Add(rental);
            return new SuccessResult("Rental added.");
        }
    }
}
