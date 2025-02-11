using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using WEBPEROJEM.Models.Personel;// ICollectıon kullanırken PersonelBilgileri kısmını çağırmak için yolu eklendi.

namespace WEBPEROJEM.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri() //PersonelBilgileris koleksiyonunun null olmasını önlemekiçin oluşturulur
        {
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }
        [Key]
        public int PersonelProjeId { get; set; }
        [DisplayName("PROJE BAŞLIK")]
        [StringLength(50, ErrorMessage = "Maksimum uzunluk 50 karakterden fazla olamaz")]
        public string ProjeBaslik { get; set; }
        public string ProjeAciklama { get; set; }
        public DateTime OluşturulmaTarihi { get; set; }
        [DisplayName("ÖNCELİK DURUMU")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz")]
        public string OncelikDurumu { get; set; }
        public int TamamlanmaOrani { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public bool TamamlanmaDurumu { get; set; }

        //bir personelin birden fazla projesi bir projenin de birden fazla personeli olabilir. bu nedenle ICollectıon kullanacağız.
        public virtual ICollection<PersonelBilgileri>PersonelBilgileris { get; set; }
    }
}