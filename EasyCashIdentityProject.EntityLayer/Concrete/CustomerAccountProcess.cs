using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    //Hesap hareketleini tutacagiz
    public class CustomerAccountProcess 
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; } //islem turu
        public decimal Amount { get; set; } // miktar
        public DateTime ProcessDate { get; set; } //islemtarihi
    }
}
