using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using EjemploBanco.DataObjects;
using EjemploBanco.Models;
using Microsoft.Azure.Mobile.Server.Config;

namespace EjemploBanco.Controllers
{
    [MobileAppController]
    public class BalanceController : ApiController
    {
        // GET api/Balance
        public decimal Get()
        {
            MobileServiceContext context = new MobileServiceContext();

            string id = "FF20453B-1EBC-4966-B0CC-C2E85657D0A6";

            List<Cuenta> listaDeCuentas =
                context.Database.SqlQuery<Cuenta>("SELECT * FROM Cuenta WHERE IdCliente = @id", new SqlParameter("@id", id)).ToList();

            return listaDeCuentas[0].Balance;
        }

        // POST: api/Balance
        public decimal Post(Cuenta cuentaAConsultar)
        {
            MobileServiceContext context = new MobileServiceContext();
            List<Cuenta> cuentaCliente =
                context.Database.SqlQuery<Cuenta>("Select * From Cuenta Where IdCliente = @id", new SqlParameter("@id", cuentaAConsultar.IdCliente)).ToList();
            return cuentaCliente[0].Balance;
        }
    }
}
