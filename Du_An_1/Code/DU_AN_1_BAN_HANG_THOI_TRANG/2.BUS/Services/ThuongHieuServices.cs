using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ThuongHieuServices : IThuongHieuServices
    {
        private IThuongHieuReps _ithuongHieuReps;
        private List<ThuongHieu> _lstthuongHieus;
        public ThuongHieuServices()
        {
            _ithuongHieuReps = new ThuongHieuReps();
            _lstthuongHieus = new List<ThuongHieu>();
        }
        public bool Add(ThuongHieu obj)
        {
          _ithuongHieuReps.Add(obj);
            return true;

        }

        public bool Delete(ThuongHieu obj)
        {
            _ithuongHieuReps.Delete(obj);
            return true;
        }

        public List<ThuongHieu> GetAll()
        {
            _lstthuongHieus = _ithuongHieuReps.GetAll();
            return _lstthuongHieus;
        }

        public List<ThuongHieu> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _ithuongHieuReps.GetAll().Where(c => c.Ten.ToLower().StartsWith(input.ToLower()) || c.Ma.ToLower().StartsWith(input.ToLower())).ToList();
        }

        //public List<ViewThuongHieu> GetThuongHieu()
        //{
        //    List<ViewThuongHieu> _lstthuonghieu = new List<ViewThuongHieu>();
        //   _lstthuonghieu = (from a in _ithuongHieuReps.GetAll() select new ViewThuongHieu() { thuongHieu = a }).ToList();
        //    return _lstthuonghieu;
        //}

        public bool Update(ThuongHieu obj)
        {
            _ithuongHieuReps.Update(obj);
            return true;
        }
    }
}
