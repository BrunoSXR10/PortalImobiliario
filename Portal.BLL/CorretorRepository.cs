using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.BLL
{
    internal class CorretorRepository
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

        public static void Update(Imovel _imovel)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext19.Imovels.Single(p => p.Id == _imovel.Id);
                imovel.Descricao = _imovel.Descricao;
                imovel.Valor = _imovel.Valor;
                imovel.Localizacao = _imovel.Localizacao;
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
