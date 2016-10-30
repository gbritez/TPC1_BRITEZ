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
       private ProveedorService service = new ProveedorService();

        public List <EProveedor> getAll()
        {
       
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

        public void Insert(EProveedor proveedor)
        {
            try
            {
                service.Insert(proveedor);
            }
            catch (Exception ex)
            {                
                
                throw ex;
            } 
        }
    }
}
