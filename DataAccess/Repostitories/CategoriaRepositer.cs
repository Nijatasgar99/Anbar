using DataAccess.interfaces;
using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repostitories
{
    class CategoriaRepositer
    {
        public class AnbarRepositer : IRepository<Categoria>

        {
            public bool Create(Categoria enntit)
            {
                try
                {
                    Dbcontest.Categorias.Add(enntit);
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            public bool Delete(Categoria enntit)
            {
                Dbcontest.Categorias.Remove(enntit);
                return true;
            }

            public Categoria Get(Predicate<Categoria> filter = null)
            {
                try
                {
                    return filter == null ? Dbcontest.Categorias[0]
                        : Dbcontest.Categorias.Find(filter);

                }
                catch (Exception)
                {

                    throw;
                }
            }

            public List<Categoria> GetAll(Predicate<Categoria> filter = null)
            {
                try
                {
                    return filter == null ? Dbcontest.Categorias
                        : Dbcontest.Categorias.FindAll(filter);

                }
                catch (Exception)
                {

                    throw;
                }
            }

            public bool Update(Categoria enntit)
            {
                Categoria dbCategoria = Get(a => a.Seria == enntit.Seria);
                dbCategoria.Name = enntit.Name;
                dbCategoria.price = enntit.price;
                return true;
            }
}
