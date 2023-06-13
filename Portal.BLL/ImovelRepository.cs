using Portal.MODEL;

namespace Portal.BLL
{
    public class ImovelRepository
    {
        public static void Add(Imv _imovel)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                DBContext.Add(_imovel);
                DBContext.SaveChanges();
            }
        }  

        public static Imv GetByID(int Id)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext.Imvs.Single(p => p.Id == Id);
                return imovel;
            }
        }

        public static List<Imv> GetAll()
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovels = DBContext.Imvs.ToList();
                return imovels;
            }
        }

        
        public static void Update(Imv _imovel)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext.Imvs.Single(p => p.Id == _imovel.Id);
                imovel.Descricao = _imovel.Descricao;
                imovel.Valor = _imovel.Valor;
                DBContext.SaveChanges();

            }
        }
        
        public static void Excluir(Imv _imovel)
        {
            using (var DBContext = new CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext.Imvs.Single(p => p.Id == _imovel.Id);
                DBContext.Remove(imovel);
                DBContext.SaveChanges();
            }
        }

    }
}