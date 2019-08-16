using Lasg.Entities;
using Lasg.Services;
using Lasg.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace Lasg.UI.Process
{

    public partial class EspecieProcess : ProcessComponent
    {
        public List<Especie> ListarTodos()
        {
            List<Especie> result = default(List<Especie>);
            var proxy = new EspecieService();

            try
            {
                result = proxy.ListarTodos();
            }
            catch (FaultException fex)
            {

                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public Especie Agregar(Especie especie)
        {
            Especie result = default(Especie);
            var proxy = new EspecieService();
            

            try
            {
                result = proxy.Agregar(especie);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }
        public IList<Especie> SelectAll()
        {
            var response = HttpGet<Especie>("api/EspecieServicesHttp/Listar", new Dictionary<string, object>(), MediaType.Json);
            return new List<Especie>();
        }
    }
}
