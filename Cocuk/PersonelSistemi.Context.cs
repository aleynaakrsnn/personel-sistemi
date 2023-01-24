﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cocuk
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OzOkulEntities1 : DbContext
    {
        public OzOkulEntities1()
            : base("name=OzOkulEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Birimler> Birimlers { get; set; }
        public virtual DbSet<Cocuk> Cocuks { get; set; }
        public virtual DbSet<Gorev> Gorevs { get; set; }
        public virtual DbSet<Personel1> Personel1 { get; set; }
        public virtual DbSet<Proje> Projes { get; set; }
        public virtual DbSet<Unvanlar> Unvanlars { get; set; }
    
        public virtual ObjectResult<BAra_Result> BAra(string birimAdi)
        {
            var birimAdiParameter = birimAdi != null ?
                new ObjectParameter("BirimAdi", birimAdi) :
                new ObjectParameter("BirimAdi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BAra_Result>("BAra", birimAdiParameter);
        }
    
        public virtual int BEkle(string birimAdi, Nullable<int> calisanSayisi)
        {
            var birimAdiParameter = birimAdi != null ?
                new ObjectParameter("BirimAdi", birimAdi) :
                new ObjectParameter("BirimAdi", typeof(string));
    
            var calisanSayisiParameter = calisanSayisi.HasValue ?
                new ObjectParameter("CalisanSayisi", calisanSayisi) :
                new ObjectParameter("CalisanSayisi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BEkle", birimAdiParameter, calisanSayisiParameter);
        }
    
        public virtual ObjectResult<BListele_Result> BListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BListele_Result>("BListele");
        }
    
        public virtual int BSil(Nullable<int> birimNo)
        {
            var birimNoParameter = birimNo.HasValue ?
                new ObjectParameter("BirimNo", birimNo) :
                new ObjectParameter("BirimNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BSil", birimNoParameter);
        }
    
        public virtual int BYenile(Nullable<int> birimNo, string birimAdi, Nullable<int> calisanSayisi)
        {
            var birimNoParameter = birimNo.HasValue ?
                new ObjectParameter("BirimNo", birimNo) :
                new ObjectParameter("BirimNo", typeof(int));
    
            var birimAdiParameter = birimAdi != null ?
                new ObjectParameter("BirimAdi", birimAdi) :
                new ObjectParameter("BirimAdi", typeof(string));
    
            var calisanSayisiParameter = calisanSayisi.HasValue ?
                new ObjectParameter("CalisanSayisi", calisanSayisi) :
                new ObjectParameter("CalisanSayisi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BYenile", birimNoParameter, birimAdiParameter, calisanSayisiParameter);
        }
    
        public virtual ObjectResult<CAra_Result> CAra(string adSoyad)
        {
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CAra_Result>("CAra", adSoyadParameter);
        }
    
        public virtual int CEkle(string adSoyad, string cinsiyet, Nullable<System.DateTime> dogumTarihi, Nullable<int> personelNo)
        {
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var dogumTarihiParameter = dogumTarihi.HasValue ?
                new ObjectParameter("DogumTarihi", dogumTarihi) :
                new ObjectParameter("DogumTarihi", typeof(System.DateTime));
    
            var personelNoParameter = personelNo.HasValue ?
                new ObjectParameter("PersonelNo", personelNo) :
                new ObjectParameter("PersonelNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CEkle", adSoyadParameter, cinsiyetParameter, dogumTarihiParameter, personelNoParameter);
        }
    
        public virtual ObjectResult<CListele_Result> CListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CListele_Result>("CListele");
        }
    
        public virtual int CSil(Nullable<int> cocukNo)
        {
            var cocukNoParameter = cocukNo.HasValue ?
                new ObjectParameter("CocukNo", cocukNo) :
                new ObjectParameter("CocukNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CSil", cocukNoParameter);
        }
    
        public virtual int CYenile(Nullable<int> cocukNo, string adSoyad, string cinsiyet, Nullable<System.DateTime> dogumTarihi, Nullable<int> personelNo)
        {
            var cocukNoParameter = cocukNo.HasValue ?
                new ObjectParameter("CocukNo", cocukNo) :
                new ObjectParameter("CocukNo", typeof(int));
    
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var dogumTarihiParameter = dogumTarihi.HasValue ?
                new ObjectParameter("DogumTarihi", dogumTarihi) :
                new ObjectParameter("DogumTarihi", typeof(System.DateTime));
    
            var personelNoParameter = personelNo.HasValue ?
                new ObjectParameter("PersonelNo", personelNo) :
                new ObjectParameter("PersonelNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CYenile", cocukNoParameter, adSoyadParameter, cinsiyetParameter, dogumTarihiParameter, personelNoParameter);
        }
    
        public virtual ObjectResult<GAra_Result> GAra(string gorevTanimi)
        {
            var gorevTanimiParameter = gorevTanimi != null ?
                new ObjectParameter("GorevTanimi", gorevTanimi) :
                new ObjectParameter("GorevTanimi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GAra_Result>("GAra", gorevTanimiParameter);
        }
    
        public virtual int GEkle(string gorevTanimi, string gorevAdi, Nullable<int> gorevPuani, Nullable<int> birimNo)
        {
            var gorevTanimiParameter = gorevTanimi != null ?
                new ObjectParameter("GorevTanimi", gorevTanimi) :
                new ObjectParameter("GorevTanimi", typeof(string));
    
            var gorevAdiParameter = gorevAdi != null ?
                new ObjectParameter("GorevAdi", gorevAdi) :
                new ObjectParameter("GorevAdi", typeof(string));
    
            var gorevPuaniParameter = gorevPuani.HasValue ?
                new ObjectParameter("GorevPuani", gorevPuani) :
                new ObjectParameter("GorevPuani", typeof(int));
    
            var birimNoParameter = birimNo.HasValue ?
                new ObjectParameter("BirimNo", birimNo) :
                new ObjectParameter("BirimNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GEkle", gorevTanimiParameter, gorevAdiParameter, gorevPuaniParameter, birimNoParameter);
        }
    
        public virtual ObjectResult<GListele_Result> GListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GListele_Result>("GListele");
        }
    
        public virtual int GSil(Nullable<int> gorevNo)
        {
            var gorevNoParameter = gorevNo.HasValue ?
                new ObjectParameter("GorevNo", gorevNo) :
                new ObjectParameter("GorevNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GSil", gorevNoParameter);
        }
    
        public virtual int GYenile(Nullable<int> gorevNo, string gorevTanimi, string gorevAdi, Nullable<int> gorevPuani, Nullable<int> birimNo)
        {
            var gorevNoParameter = gorevNo.HasValue ?
                new ObjectParameter("GorevNo", gorevNo) :
                new ObjectParameter("GorevNo", typeof(int));
    
            var gorevTanimiParameter = gorevTanimi != null ?
                new ObjectParameter("GorevTanimi", gorevTanimi) :
                new ObjectParameter("GorevTanimi", typeof(string));
    
            var gorevAdiParameter = gorevAdi != null ?
                new ObjectParameter("GorevAdi", gorevAdi) :
                new ObjectParameter("GorevAdi", typeof(string));
    
            var gorevPuaniParameter = gorevPuani.HasValue ?
                new ObjectParameter("GorevPuani", gorevPuani) :
                new ObjectParameter("GorevPuani", typeof(int));
    
            var birimNoParameter = birimNo.HasValue ?
                new ObjectParameter("BirimNo", birimNo) :
                new ObjectParameter("BirimNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GYenile", gorevNoParameter, gorevTanimiParameter, gorevAdiParameter, gorevPuaniParameter, birimNoParameter);
        }
    
        public virtual int PeAra(string adSoyad)
        {
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PeAra", adSoyadParameter);
        }
    
        public virtual int PeEkle(string adSoyad, string cinsiyet, Nullable<System.DateTime> baslamaTarihi, string vardiyaDurumu, Nullable<decimal> maas, Nullable<int> prim, Nullable<int> gorevNo, Nullable<int> unvanNo)
        {
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var baslamaTarihiParameter = baslamaTarihi.HasValue ?
                new ObjectParameter("BaslamaTarihi", baslamaTarihi) :
                new ObjectParameter("BaslamaTarihi", typeof(System.DateTime));
    
            var vardiyaDurumuParameter = vardiyaDurumu != null ?
                new ObjectParameter("VardiyaDurumu", vardiyaDurumu) :
                new ObjectParameter("VardiyaDurumu", typeof(string));
    
            var maasParameter = maas.HasValue ?
                new ObjectParameter("Maas", maas) :
                new ObjectParameter("Maas", typeof(decimal));
    
            var primParameter = prim.HasValue ?
                new ObjectParameter("Prim", prim) :
                new ObjectParameter("Prim", typeof(int));
    
            var gorevNoParameter = gorevNo.HasValue ?
                new ObjectParameter("GorevNo", gorevNo) :
                new ObjectParameter("GorevNo", typeof(int));
    
            var unvanNoParameter = unvanNo.HasValue ?
                new ObjectParameter("UnvanNo", unvanNo) :
                new ObjectParameter("UnvanNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PeEkle", adSoyadParameter, cinsiyetParameter, baslamaTarihiParameter, vardiyaDurumuParameter, maasParameter, primParameter, gorevNoParameter, unvanNoParameter);
        }
    
        public virtual int PEkle(string planAdi, string planBakanlik, Nullable<int> tarimNo, string planSorumlusu, string plantutanak, Nullable<decimal> planOdenek)
        {
            var planAdiParameter = planAdi != null ?
                new ObjectParameter("PlanAdi", planAdi) :
                new ObjectParameter("PlanAdi", typeof(string));
    
            var planBakanlikParameter = planBakanlik != null ?
                new ObjectParameter("PlanBakanlik", planBakanlik) :
                new ObjectParameter("PlanBakanlik", typeof(string));
    
            var tarimNoParameter = tarimNo.HasValue ?
                new ObjectParameter("TarimNo", tarimNo) :
                new ObjectParameter("TarimNo", typeof(int));
    
            var planSorumlusuParameter = planSorumlusu != null ?
                new ObjectParameter("PlanSorumlusu", planSorumlusu) :
                new ObjectParameter("PlanSorumlusu", typeof(string));
    
            var plantutanakParameter = plantutanak != null ?
                new ObjectParameter("Plantutanak", plantutanak) :
                new ObjectParameter("Plantutanak", typeof(string));
    
            var planOdenekParameter = planOdenek.HasValue ?
                new ObjectParameter("PlanOdenek", planOdenek) :
                new ObjectParameter("PlanOdenek", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PEkle", planAdiParameter, planBakanlikParameter, tarimNoParameter, planSorumlusuParameter, plantutanakParameter, planOdenekParameter);
        }
    
        public virtual ObjectResult<PeListele_Result> PeListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PeListele_Result>("PeListele");
        }
    
        public virtual int PeYenile(Nullable<int> personelNo, string adSoyad, string cinsiyet, Nullable<System.DateTime> baslamaTarihi, string vardiyaDurumu, Nullable<decimal> maas, Nullable<int> prim, Nullable<int> gorevNo, Nullable<int> unvanNo)
        {
            var personelNoParameter = personelNo.HasValue ?
                new ObjectParameter("PersonelNo", personelNo) :
                new ObjectParameter("PersonelNo", typeof(int));
    
            var adSoyadParameter = adSoyad != null ?
                new ObjectParameter("AdSoyad", adSoyad) :
                new ObjectParameter("AdSoyad", typeof(string));
    
            var cinsiyetParameter = cinsiyet != null ?
                new ObjectParameter("Cinsiyet", cinsiyet) :
                new ObjectParameter("Cinsiyet", typeof(string));
    
            var baslamaTarihiParameter = baslamaTarihi.HasValue ?
                new ObjectParameter("BaslamaTarihi", baslamaTarihi) :
                new ObjectParameter("BaslamaTarihi", typeof(System.DateTime));
    
            var vardiyaDurumuParameter = vardiyaDurumu != null ?
                new ObjectParameter("VardiyaDurumu", vardiyaDurumu) :
                new ObjectParameter("VardiyaDurumu", typeof(string));
    
            var maasParameter = maas.HasValue ?
                new ObjectParameter("Maas", maas) :
                new ObjectParameter("Maas", typeof(decimal));
    
            var primParameter = prim.HasValue ?
                new ObjectParameter("Prim", prim) :
                new ObjectParameter("Prim", typeof(int));
    
            var gorevNoParameter = gorevNo.HasValue ?
                new ObjectParameter("GorevNo", gorevNo) :
                new ObjectParameter("GorevNo", typeof(int));
    
            var unvanNoParameter = unvanNo.HasValue ?
                new ObjectParameter("UnvanNo", unvanNo) :
                new ObjectParameter("UnvanNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PeYenile", personelNoParameter, adSoyadParameter, cinsiyetParameter, baslamaTarihiParameter, vardiyaDurumuParameter, maasParameter, primParameter, gorevNoParameter, unvanNoParameter);
        }
    
        public virtual ObjectResult<PrAra_Result> PrAra(string projeAd)
        {
            var projeAdParameter = projeAd != null ?
                new ObjectParameter("ProjeAd", projeAd) :
                new ObjectParameter("ProjeAd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PrAra_Result>("PrAra", projeAdParameter);
        }
    
        public virtual int PrEkle(string projeAd, Nullable<System.DateTime> baslamaTarihi, Nullable<System.DateTime> bitisTarihi, Nullable<int> gorevNo)
        {
            var projeAdParameter = projeAd != null ?
                new ObjectParameter("ProjeAd", projeAd) :
                new ObjectParameter("ProjeAd", typeof(string));
    
            var baslamaTarihiParameter = baslamaTarihi.HasValue ?
                new ObjectParameter("BaslamaTarihi", baslamaTarihi) :
                new ObjectParameter("BaslamaTarihi", typeof(System.DateTime));
    
            var bitisTarihiParameter = bitisTarihi.HasValue ?
                new ObjectParameter("BitisTarihi", bitisTarihi) :
                new ObjectParameter("BitisTarihi", typeof(System.DateTime));
    
            var gorevNoParameter = gorevNo.HasValue ?
                new ObjectParameter("GorevNo", gorevNo) :
                new ObjectParameter("GorevNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PrEkle", projeAdParameter, baslamaTarihiParameter, bitisTarihiParameter, gorevNoParameter);
        }
    
        public virtual ObjectResult<PrListele_Result> PrListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PrListele_Result>("PrListele");
        }
    
        public virtual int PrSil(Nullable<int> projeNo)
        {
            var projeNoParameter = projeNo.HasValue ?
                new ObjectParameter("ProjeNo", projeNo) :
                new ObjectParameter("ProjeNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PrSil", projeNoParameter);
        }
    
        public virtual int PrYenile(Nullable<int> projeNo, string projeAd, Nullable<System.DateTime> baslamaTarihi, Nullable<System.DateTime> bitisTarihi, Nullable<int> gorevNo)
        {
            var projeNoParameter = projeNo.HasValue ?
                new ObjectParameter("ProjeNo", projeNo) :
                new ObjectParameter("ProjeNo", typeof(int));
    
            var projeAdParameter = projeAd != null ?
                new ObjectParameter("ProjeAd", projeAd) :
                new ObjectParameter("ProjeAd", typeof(string));
    
            var baslamaTarihiParameter = baslamaTarihi.HasValue ?
                new ObjectParameter("BaslamaTarihi", baslamaTarihi) :
                new ObjectParameter("BaslamaTarihi", typeof(System.DateTime));
    
            var bitisTarihiParameter = bitisTarihi.HasValue ?
                new ObjectParameter("BitisTarihi", bitisTarihi) :
                new ObjectParameter("BitisTarihi", typeof(System.DateTime));
    
            var gorevNoParameter = gorevNo.HasValue ?
                new ObjectParameter("GorevNo", gorevNo) :
                new ObjectParameter("GorevNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PrYenile", projeNoParameter, projeAdParameter, baslamaTarihiParameter, bitisTarihiParameter, gorevNoParameter);
        }
    
        public virtual ObjectResult<UAra_Result> UAra(string unvanAdi)
        {
            var unvanAdiParameter = unvanAdi != null ?
                new ObjectParameter("UnvanAdi", unvanAdi) :
                new ObjectParameter("UnvanAdi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UAra_Result>("UAra", unvanAdiParameter);
        }
    
        public virtual int UEkle(string unvanAdi)
        {
            var unvanAdiParameter = unvanAdi != null ?
                new ObjectParameter("UnvanAdi", unvanAdi) :
                new ObjectParameter("UnvanAdi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UEkle", unvanAdiParameter);
        }
    
        public virtual ObjectResult<UListele_Result> UListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UListele_Result>("UListele");
        }
    
        public virtual int USil(Nullable<int> unvanNo)
        {
            var unvanNoParameter = unvanNo.HasValue ?
                new ObjectParameter("UnvanNo", unvanNo) :
                new ObjectParameter("UnvanNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USil", unvanNoParameter);
        }
    
        public virtual int UYenile(Nullable<int> unvanNo, string unvanAdi)
        {
            var unvanNoParameter = unvanNo.HasValue ?
                new ObjectParameter("UnvanNo", unvanNo) :
                new ObjectParameter("UnvanNo", typeof(int));
    
            var unvanAdiParameter = unvanAdi != null ?
                new ObjectParameter("UnvanAdi", unvanAdi) :
                new ObjectParameter("UnvanAdi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UYenile", unvanNoParameter, unvanAdiParameter);
        }
    
        public virtual int PeSil(Nullable<int> personelNo)
        {
            var personelNoParameter = personelNo.HasValue ?
                new ObjectParameter("PersonelNo", personelNo) :
                new ObjectParameter("PersonelNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PeSil", personelNoParameter);
        }
    }
}