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
    public class ProgressBarManager : IProgressBarService
    {
        private readonly IProgressBarDal _progressBarDal;

        public ProgressBarManager(IProgressBarDal progressBarDal)
        {
            _progressBarDal = progressBarDal;
        }

        public void TDelete(ProgressBar t)
        {
            _progressBarDal.Delete(t);
        }

        public ProgressBar TGetByID(int id)
        {
            return _progressBarDal.GetByID(id);
        }

        public List<ProgressBar> TGetList()
        {
            return _progressBarDal.GetList();
        }

        public void TInsert(ProgressBar t)
        {
           _progressBarDal.Insert(t);
        }

        public void TUpdate(ProgressBar t)
        {
           _progressBarDal.Update(t);
        }
    }
}
