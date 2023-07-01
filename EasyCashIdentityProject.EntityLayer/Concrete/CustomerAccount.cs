using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    //Musteri Hesbi
    public class CustomerAccount
    {
        public int CustemerAccountID { get; set; }
        public string CustemerAccountNumber { get; set; }//musteri hesap numarasi
        public string CustemerAccountCurrency { get; set; } //doviz cinsi
        public decimal CustemerAccountBalance { get; set; } // bakiye
        public string CustemerAccountBankBranch { get; set; } //banka subesi
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
