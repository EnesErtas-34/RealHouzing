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
    public class OurFieldManager : IOurFieldService
    {
        private readonly IOurFieldDal _ourFieldDal;

        public OurFieldManager(IOurFieldDal ourFieldDal)
        {
            _ourFieldDal = ourFieldDal;
        }

        public void TDelete(OurField t)
        {
            _ourFieldDal.Delete(t);
        }

        public OurField TGetByID(int id)
        {
            return _ourFieldDal.GetByID(id);
        }

        public List<OurField> TGetList()
        {
            return _ourFieldDal.GetList();
        }

        public void TInsert(OurField t)
        {
            _ourFieldDal.Insert(t);
        }

        public void TUpdate(OurField t)
        {
            _ourFieldDal.Update(t);
        }
    }
}
