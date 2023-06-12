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
        public static void Add(TbCorretor _corretor)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                DBContext19.Add(_corretor);
                DBContext19.SaveChanges();
            }
        }

        public static TbCorretor GetByID(int Id)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.TbCorretors.Single(p => p.IdCorretor == Id);
                return corretor;
            }
        }

        public static List<TbCorretor> GetAll()
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.TbCorretors.ToList();
                return corretor;
            }
        }

        public static void Update(TbCorretor _corretor)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.TbCorretors.Single(p => p.IdCorretor == _corretor.IdCorretor);
                corretor.Nome = _corretor.Nome;
                corretor.Senha = _corretor.Senha;
                corretor.Cpf = _corretor.Cpf;
                corretor.Deputado = _corretor.Deputado;
                corretor.DtNascimento = _corretor.DtNascimento;
                DBContext19.SaveChanges();

            }
        }
        public static void Excluir(TbCorretor _corretor)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext19.TbCorretors.Single(p => p.IdCorretor == _corretor.IdCorretor);
                DBContext19.Remove(corretor);
                DBContext19.SaveChanges();
            }
        }
    }
}
