using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WEBPEROJEM.Models.Personel;
using WEBPEROJEM.Models.ProjeTakip;

namespace WEBPEROJEM.Models.DataContext
{
    public class ProjeTakipDBContext: DbContext//bunun entiti yapısıyla ilişkili olup veritabanı oluşturacağı için "DbContext" ekliyoruz.Yukarıya Data.Enttiy ekliyor
    {
        public ProjeTakipDBContext(): base("ProjeTakipDB")//base diyerek connection string tarafında vereceğimiz ismi veriyoruz.
        {
        
        }
        public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; }
        public DbSet<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}