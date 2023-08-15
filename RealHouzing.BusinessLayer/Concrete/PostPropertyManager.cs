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
    public class PostPropertyManager : IPostPropertyService
    {
        private readonly IPostPropertyDal _postPropertyDal;

        public PostPropertyManager(IPostPropertyDal postPropertyDal)
        {
            _postPropertyDal = postPropertyDal;
        }

        public void TDelete(PostProperty t)
        {
            _postPropertyDal.Delete(t);
        }

        public PostProperty TGetByID(int id)
        {
            return _postPropertyDal.GetByID(id);
        }

        public List<PostProperty> TGetList()
        {
           return _postPropertyDal.GetList();
        }

        public void TInsert(PostProperty t)
        {
            _postPropertyDal.Insert(t);
        }

        public void TUpdate(PostProperty t)
        {
           _postPropertyDal.Update(t);
        }
    }
}
