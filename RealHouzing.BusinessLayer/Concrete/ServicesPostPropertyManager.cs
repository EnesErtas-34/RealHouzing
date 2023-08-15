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
    public class ServicesPostPropertyManager : IServicesPostPropertyService
    {
        private readonly IServicesPostPropertyDal _servicesPostPropertyDal;

        public ServicesPostPropertyManager(IServicesPostPropertyDal servicesPostPropertyDal)
        {
            _servicesPostPropertyDal = servicesPostPropertyDal;
        }

        public void TDelete(ServicesPostProperty t)
        {
           _servicesPostPropertyDal.Delete(t);
        }

        public ServicesPostProperty TGetByID(int id)
        {
            return _servicesPostPropertyDal.GetByID(id);
        }

        public List<ServicesPostProperty> TGetList()
        {
            return _servicesPostPropertyDal.GetList();
        }

        public void TInsert(ServicesPostProperty t)
        {
            _servicesPostPropertyDal.Insert(t);
        }

        public void TUpdate(ServicesPostProperty t)
        {
            _servicesPostPropertyDal.Update(t);
        }
    }
}
