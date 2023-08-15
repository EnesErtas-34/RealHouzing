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
    public class MyTeamManager : IMyTeamService
    {
        private readonly IMyTeamDal _myTeamDal;

        public MyTeamManager(IMyTeamDal myTeamDal)
        {
            _myTeamDal = myTeamDal;
        }

        public void TDelete(MyTeam t)
        {
            _myTeamDal.Delete(t);
        }

        public MyTeam TGetByID(int id)
        {
           return _myTeamDal.GetByID(id);
        }

        public List<MyTeam> TGetList()
        {
            return _myTeamDal.GetList();
        }

        public void TInsert(MyTeam t)
        {
           _myTeamDal.Insert(t);
        }

        public void TUpdate(MyTeam t)
        {
            _myTeamDal.Update(t);
        }
    }
}
