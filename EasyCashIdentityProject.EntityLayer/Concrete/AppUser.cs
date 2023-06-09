﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }//kasaba ilce anlamına geliyor
        public string City { get; set; }
        public string ImgageUrl { get; set; }
        public List<CustomerAccount> CustemerAccount { get; set; }
    }
}
