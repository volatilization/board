using Board.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Board.Services
{
    public class AdvertRepository
    {
        DatabaseService databaseService = new DatabaseService();

        public void Save(Advert advert)
        {
            databaseService.Adverts.Add(advert);
            databaseService.SaveChanges();
        }

        public Advert Get(int advertId)
        {
            return databaseService.Adverts.Find(advertId);
        }

        public void Update(Advert advert)
        {
            databaseService.Adverts.AddOrUpdate(advert);
            databaseService.SaveChanges();
        }

        public void Rremove(int advertId)
        {
            Advert advert = databaseService.Adverts.Find(advertId);
            databaseService.Adverts.Remove(advert);
            databaseService.SaveChanges();
        }

        public IList<Advert> GetAll()
        {
            return databaseService.Adverts.ToList();
        }
    }
}