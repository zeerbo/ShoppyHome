using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ShoppyHomeServer.Models.Model.Spesa;

namespace ShoppyHomeServer.Controllers.Spesa
{
    public class CatalogoController : ICatalogoController
    {
        private Carrello _carrello;
        private ISession _session;

        public CatalogoController(Carrello carrello, ISession session)
        {
            _carrello = carrello;
            _session = session;
        }

        public Boolean AggiungiProdotto(ElementoCatalogo p)
        {
            return _carrello.AddProdotto(p);
        }

        public Catalogo GetCatalogo(Supermarket s)
        {
            Catalogo result;
            List<ElementoCatalogo> queryResult;
            using (ITransaction t = _session.BeginTransaction())
            {
                queryResult = _session.Query<ElementoCatalogo>().Where(c => c.IdNegozio == s.IdNegozio).ToList();
                result = new Catalogo(queryResult);
                t.Commit();
            }

            return result;
        }
    }
}
