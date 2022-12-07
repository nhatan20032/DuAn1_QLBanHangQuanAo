using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
   public class ViewThuongHieu
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
    }
}
