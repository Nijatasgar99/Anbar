using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.interfaces
{
   public interface ICategory
    {
        Categoria Create(Categoria Categoria);
        Categoria Update(int Seria, Categoria categoria);
        Categoria Delete(int Seria );
        Categoria Get(int Seria);
        Categoria Get(string Name);
        List<Categoria> GetAll();
        List<Categoria> GetAll(int price);



    }
}
