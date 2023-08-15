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
    public class ExploreManager : IExploreService
    {
        private readonly IExploreDal _exploreDal;

        public ExploreManager(IExploreDal exploreDal)
        {
            _exploreDal = exploreDal;
        }

        public void TDelete(Explore t)
        {
            _exploreDal.Delete(t);
        }

        public Explore TGetByID(int id)
        {
            return _exploreDal.GetByID(id);
        }

        public List<Explore> TGetList()
        {
            return _exploreDal.GetList();
        }

        public void TInsert(Explore t)
        {
          _exploreDal.Insert(t);
        }

        public void TUpdate(Explore t)
        {
            _exploreDal.Update(t);
        }
    }
}
