using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;
namespace Business
{
    public class ProveedorBusiness
    {
        public List <EProveedor> getAll()
        {
            var service = new ProveedorService();
            try
            {
                var Lista = service.getAll();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
