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
    public class ServicesCategoriesManager : IServicesCategoriesService
    {
        private readonly IServicesCategoriesDal _servicesCategoriesDal;

        public ServicesCategoriesManager(IServicesCategoriesDal servicesCategoriesDal)
        {
            _servicesCategoriesDal = servicesCategoriesDal;
        }

        public void TDelete(ServicesCategories t)
        {
            _servicesCategoriesDal.Delete(t);
        }

        public ServicesCategories TGetByID(int id)
        {
            return _servicesCategoriesDal.GetByID(id);
        }

        public List<ServicesCategories> TGetList()
        {
            return _servicesCategoriesDal.GetList();
        }

        public void TInsert(ServicesCategories t)
        {
            _servicesCategoriesDal.Insert(t);
        }

        public void TUpdate(ServicesCategories t)
        {
            _servicesCategoriesDal.Update(t);
        }
    }
}
