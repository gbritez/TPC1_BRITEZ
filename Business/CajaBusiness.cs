using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Entities;

namespace Business
{   
    public class CajaBusiness
    {
        private ProductoService prodService = new ProductoService();

        /// <summary>
        /// El valor booleano representa si es una compra (true) o venta (false)
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="ban"></param>
        public void Transaccion (EProducto producto, bool ban)
        {
            try
            {
                if(!ban && !prodService.CheckIfExists(producto.id))
                {
                    throw new Exception("El producto no existe en la base de datos.");
                }

                if (prodService.CheckIfExists(producto.id))
                {
                    prodService.UpdateStock(producto.id,producto.stock, ban);
                }
                else
                {
                    prodService.Insert(producto);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}
