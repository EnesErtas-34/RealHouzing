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
    public class CoLivingManager : ICoLivingService
    {
        private readonly ICoLivingDal _coLivingDal;

        public CoLivingManager(ICoLivingDal coLivingDal)
        {
            _coLivingDal = coLivingDal;
        }

        public void TDelete(CoLiving t)
        {
            _coLivingDal.Delete(t);
        }

        public CoLiving TGetByID(int id)
        {
           return _coLivingDal.GetByID(id);
        }

        public List<CoLiving> TGetList()
        {
            return _coLivingDal.GetList();
        }

        public void TInsert(CoLiving t)
        {
            _coLivingDal.Insert(t);
        }

        public void TUpdate(CoLiving t)
        {
            _coLivingDal.Update(t);
        }
    }
}
