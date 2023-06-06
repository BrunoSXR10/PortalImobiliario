using Portal.MODEL;

namespace Portal.BLL
{
    public class ImovelRepository
    {
        public static void Add(Imovel _imovel)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                DBContext19.Add(_imovel);
                DBContext19.SaveChanges();
            }
        }

        public static Imovel GetByID(int Id)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext19.Imovels.Single(p => p.Id == Id);
                return imovel;
            }
        }

        public static List<Imovel> GetAll()
        {
            using (var DBContext19 = new CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext())
            {
                var imovels = DBContext19.Imovels.ToList();
                return imovels;
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