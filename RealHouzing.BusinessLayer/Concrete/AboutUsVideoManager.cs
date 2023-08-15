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
    public class AboutUsVideoManager : IAboutUsVideoService
    {
        private readonly IAboutUsVideoDal _aboutUsVideoDal;

        public AboutUsVideoManager(IAboutUsVideoDal aboutUsVideoDal)
        {
            _aboutUsVideoDal = aboutUsVideoDal;
        }

        public void TDelete(AboutUsVideo t)
        {
            _aboutUsVideoDal.Delete(t);
        }

        public AboutUsVideo TGetByID(int id)
        {
            return _aboutUsVideoDal.GetByID(id);
        }

        public List<AboutUsVideo> TGetList()
        {
            return _aboutUsVideoDal.GetList();
        }

        public void TInsert(AboutUsVideo t)
        {
            _aboutUsVideoDal.Insert(t);
        }

        public void TUpdate(AboutUsVideo t)
        {
            _aboutUsVideoDal.Update(t);
        }
    }
}
