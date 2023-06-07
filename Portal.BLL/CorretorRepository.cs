using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.BLL
{
    public static class CorretorRepository
    {
        public static void Add(Corretor _corretor)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                DBContext19.Add(_corretor);
                DBContext19.SaveChanges();
            }
        }

        public static Corretor GetByID(int Id)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.Corretors.Single(p => p.Id == Id);
                return corretor;
            }
        }

        public static List<Corretor> GetAll()
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.Corretors.ToList();
                return corretor;
            }
        }

        public static void Update(Corretor _corretor)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.Corretors.Single(p => p.Id == _corretor.Id);
                corretor.Nome = _corretor.Nome;
                corretor.Email = _corretor.Email;
                corretor.Telefone = _corretor.Telefone;
                corretor.Deputado = _corretor.Deputado;
                DBContext19.SaveChanges();

            }
        }
        public static void Excluir(Imovel _imovel)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext19.Imovels.Single(p => p.Id == _imovel.Id);
                DBContext19.Remove(imovel);
                DBContext19.SaveChanges();
            }
        }
    }
}
