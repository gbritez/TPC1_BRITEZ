using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Entities;

namespace Business
{
    public class ClienteBusiness
    {
        private ClienteService service = new ClienteService();

        public List<ECliente> GetAll()
        {
            try
            {
                return service.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(ECliente cliente)
        {
            try
            {
                service.Insert(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ECliente> GetByFilter (string filter , string busqueda)
        {
            try
            {
                var Lista = service.GetByFilter(filter, busqueda);
                return Lista;
                                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    }