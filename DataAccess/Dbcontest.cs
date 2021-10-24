using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class Dbcontest
    {
        public static List<Anbar> Anbars { get;  }
        public static List<Categoria> Categorias { get; }
        static Dbcontest()
        {
            Anbars = new List<Anbar>();
            Categorias = new List<Categoria>();
        }
    }
}
