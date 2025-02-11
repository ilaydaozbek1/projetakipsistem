using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WEBPEROJEM.Models.ProjeTakip;

namespace WEBPEROJEM.Models.Personel
{
    public class PersonelBilgileri
    {//bu kısma başka özellikllerde eklenebilir. örneğin ; tecrübe yılı, hangi okul mezunu, ehliyetiş var mı, yabancı dili var mı, sigorta girişi
        public PersonelBilgileri()
        {
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int  PersonelBilgileriId { get; set; }
        [DisplayName ("E-POSTA")]//Display name özelliği ile görünümde görüenecek olan yazıları giriyoruz
        public string Eposta { get; set; }
        [DisplayName("ŞİFRE")]
        [StringLength (20,ErrorMessage ="Maksimum uzunluk 20 karakterden fazla olamaz")]
        public string Sifre { get; set; }
        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz")]
        public string Yetki { get; set; }
        [DisplayName("AD SOYAD")]//rakam girdirmesin**
        [StringLength(35, ErrorMessage = "Maksimum uzunluk 35 karakterden fazla olamaz")]
        public string AdSoyad { get; set; }
        [DisplayName("PERSONEL GORSELİ")]

        public string PersonelGörseli { get; set; }

        [DisplayName("TC KİMLİK NO")]//tc 11 den fazla girdirmesin sadece rakam girdirsin.**
        [StringLength(11, ErrorMessage = "Maksimum uzunluk 11 karakterden fazla olamaz")]
        public string TCNO { get; set; }
        [DisplayName("DEPARTMAN")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz")]
        public string Departman { get; set; }
        [DisplayName("GÖREVİ")]
        public string Gorev { get; set; }
        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }
        [DisplayName("TELEFON NUMARASI")]//tel no stili aktif olsun örnek: 0538 067 0928  sadece rakam girdirsin**
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz")]
        public string TelNo { get; set; }
        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }
        [DisplayName("MEDENİ HAL")] 

        public string MedeniHal { get; set; }
        [DisplayName("YAKINLIK BİLGİSİ")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz")]
        public string YakinBilgisi { get; set; }
        [DisplayName("YAKIN TC NO")]//tc 11 den fazla girdirmesin sadece rakam girdirsin.**
        [StringLength(11, ErrorMessage = "Maksimum uzunluk 11 karakterden fazla olamaz")]
        public string YakinTC { get; set; }
        [DisplayName("YAKIN AD SOYAD")]//rakam girdirmesin**
        [StringLength(35, ErrorMessage = "Maksimum uzunluk 35 karakterden fazla olamaz")]
        public string YakinAdSoyad { get; set; }
        [DisplayName("YAKIN TELEFON NUMARASI")]//tel no stili aktif olsun örnek: 0538 067 0928  sadece rakam girdirsin**
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz")]
        public string YakinTel { get; set; }
        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("İŞE GİRİŞ TARİHİ")]
        public DateTime? IseGirisTarihi { get; set; } 

        public virtual ICollection<PersonelProjeleri>PersonelProjeleris { get; set; }
    }
}