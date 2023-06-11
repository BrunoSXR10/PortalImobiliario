using Portal.MODEL;

namespace Portal.BLL
{
    public class ImovelRepository
    {
        public static void Add(TbImovel _imovel)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                DBContext19.Add(_imovel);
                DBContext19.SaveChanges();
            }
        }  

        public static TbImovel GetByID(int Id)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext19.TbImovels.Single(p => p.IdImovel == Id);
                return imovel;
            }
        }

        public static List<TbImovel> GetAll()
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovels = DBContext19.TbImovels.ToList();
                return imovels;
            }
        }

        
        public static void Update(TbImovel _imovel)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext19.TbImovels.Single(p => p.IdImovel == _imovel.IdImovel);
                imovel.Descricao = _imovel.Descricao;
                imovel.Valor = _imovel.Valor;
                DBContext19.SaveChanges();

            }
        }
        
        public static void Excluir(TbImovel _imovel)
        {
            using (var DBContext19 = new CUsersBrunoSourceReposBrunosxr10PortalimobiliarioPortalDalDatabaseDatabaseMdfContext())
            {
                var imovel = DBContext19.TbImovels.Single(p => p.IdImovel == _imovel.IdImovel);
                DBContext19.Remove(imovel);
                DBContext19.SaveChanges();
            }
        }

    }
}