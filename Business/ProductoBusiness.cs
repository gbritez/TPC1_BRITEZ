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

        public List<EProducto> getAll()
        {
            var lista = new List<EProducto>();
            try
            {                
                lista = productoService.getAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public void Insert(EProducto producto, int id)
        {
            try
            {
                productoService.Insert(producto, id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

    
}
