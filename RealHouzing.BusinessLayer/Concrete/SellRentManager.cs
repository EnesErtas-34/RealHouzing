using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class SellRentManager : ISellRentService
    {
        private readonly ISellRentDal _sellRentDal;

        public SellRentManager(ISellRentDal sellRentDal)
        {
            _sellRentDal = sellRentDal;
        }

        public void TDelete(SellRent t)
        {
            _sellRentDal.Delete(t);
        }

        public SellRent TGetByID(int id)
        {
            return _sellRentDal.GetByID(id);
        }

        public List<SellRent> TGetList()
        {
            return _sellRentDal.GetList();
        }

        public void TInsert(SellRent t)
        {
            _sellRentDal.Insert(t);
        }

        public void TUpdate(SellRent t)
        {
            _sellRentDal?.Update(t);
        }
    }
}
