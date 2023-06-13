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
        public static void Add(Usuario _corretor)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                DBContext.Add(_corretor);
                DBContext.SaveChanges();
            }
        }

        public static Usuario GetByID(int Id)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext.Usuarios.Single(p => p.Id == Id);
                return corretor;
            }
        }

        public static Usuario GetByCpf(string cpf)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretorCPF = DBContext.Usuarios.Single(p => p.Cpf == cpf);
                return corretorCPF;
            }
        }


        public static List<Usuario> GetAll()
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext.Usuarios.ToList();
                return corretor;
            }
        }

        public static void Update(Usuario _corretor)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext.Usuarios.Single(p => p.Id == _corretor.Id);
                corretor.Nome = _corretor.Nome;
                corretor.Senha = _corretor.Senha;
                corretor.Cpf = _corretor.Cpf;
                corretor.Deputado = _corretor.Deputado;
                DBContext.SaveChanges();

            }
        }
        public static void Excluir(Usuario _corretor)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var corretor = DBContext.Usuarios.Single(p => p.Id == _corretor.Id);
                DBContext.Remove(corretor);
                DBContext.SaveChanges();
            }
        }
    }
}
