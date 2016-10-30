using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Business
{
    public class ProductoBusiness
    {
        ProductoService productoService = new ProductoService();

        public List<EProducto> GetAll()
        {
            var lista = new List<EProducto>();
            try
            {                
                lista = productoService.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public void Insert(EProducto producto)
        {
            try
            {
                productoService.Insert(producto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

    
}
