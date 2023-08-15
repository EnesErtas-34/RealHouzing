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
    public class AboutFeatureManager : IAboutFeatureService
    {
        private readonly IAboutFeatureDal _aboutFeatureDal;

        public AboutFeatureManager(IAboutFeatureDal aboutFeatureDal)
        {
            _aboutFeatureDal = aboutFeatureDal;
        }

        public void TDelete(AboutFeature t)
        {
            _aboutFeatureDal.Delete(t);
        }

        public AboutFeature TGetByID(int id)
        {
            return _aboutFeatureDal.GetByID(id);
        }

        public List<AboutFeature> TGetList()
        {
            return _aboutFeatureDal.GetList();
        }

        public void TInsert(AboutFeature t)
        {
            _aboutFeatureDal.Insert(t);
        }

        public void TUpdate(AboutFeature t)
        {
            _aboutFeatureDal.Update(t);
        }
    }
}
