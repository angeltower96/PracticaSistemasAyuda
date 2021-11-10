using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace EjemploBanco.DataObjects
{
    public class Cuenta
    {
        public String IdCliente { get; set; }
        public String NombreCliente { get; set; }
        public Decimal Balance { get; set; }
    }
}