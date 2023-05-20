using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama__27._04.Context;
using Uygulama__27._04.Models;

namespace Uygulama__27._04.Reprository
{
    internal class KisiReprository
    {
        RehberDb RehberDb;
        public KisiReprository()
        {
            RehberDb = new RehberDb();
        }

        public List<Kisi> KisileriGetir()
        { 
        return RehberDb.Kisiler.ToList();
        }

        public int KisiEkle(Kisi kisi)
        { 
            RehberDb.Add(kisi);
            return RehberDb.SaveChanges();    
        }

        public List<Kisi> KisiAra(string ad)
        {
            var kisiler=RehberDb.Kisiler.Where(v => v.Ad.Contains(ad) || v.Soyad.Contains(ad));
            return kisiler.ToList();
        
        }

        public int Guncelle(Kisi kisi , int id)
        {
            Kisi kisiDb = RehberDb.Kisiler.Find(id);
            kisiDb.Ad = kisi.Ad;
            kisiDb.Soyad = kisi.Soyad;
            kisiDb.Telefon = kisi.Telefon;
            return RehberDb.SaveChanges();
        }


    }
}
