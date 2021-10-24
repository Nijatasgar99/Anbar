using DataAccess.interfaces;
using Entitiess.interfaces;
using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repostitories
{
    public class AnbarRepositer : IRepository<Anbar>

    {
        public bool Create(Anbar enntit)
        {
            try
            {
                Dbcontest.Anbars.Add(enntit);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Anbar enntit)
        {
            Dbcontest.Anbars.Remove(enntit);
            return true;
        }

        public Anbar Get(Predicate<Anbar> filter = null)
        {
            try
            {
                return filter == null ? Dbcontest.Anbars[0]
                    : Dbcontest.Anbars.Find(filter);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Anbar> GetAll(Predicate<Anbar> filter = null)
        {
            try
            {
                return filter == null ? Dbcontest.Anbars
                    : Dbcontest.Anbars.FindAll(filter);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Anbar enntit)
        {
            Anbar dbAnbar = Get(a => a.Seria == enntit.Seria);
            dbAnbar.Name = enntit.Name;
            dbAnbar.Area = enntit.Area;
            return true;
        }
    }
}
