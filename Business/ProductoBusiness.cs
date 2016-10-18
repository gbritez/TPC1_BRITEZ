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
        public List<EProducto> getAll()
        {
            var lista = new List<EProducto>();
            try
            {
                var productoService = new ProductoService();
                lista = productoService.getAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }
    }
}
