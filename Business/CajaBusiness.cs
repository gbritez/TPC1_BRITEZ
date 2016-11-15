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
        private CajaService cajaService = new CajaService();

        /// <summary>
        /// El valor booleano representa si es una compra (true) o venta (false)
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="ban"></param>
        public void Transaccion(EProducto producto, bool ban, decimal saldo)
        {
            try
            {
                //Si es una compra, valido tener saldo.
                if (ban && producto.precio * producto.stock > saldo )
                {
                    throw new Exception("No posee saldo suficiente para realizar esta transacción.");
                }
                //Si es una venta y no existe el producto...
                if (!ban && !prodService.CheckIfExists(producto.id))
                {
                    throw new Exception("El producto no existe en la base de datos.");
                }

                //Si es una compra checkeo si el producto ya existe y hago un Update
                if (prodService.CheckIfExists(producto.id))
                {
                    prodService.UpdateStock(producto.id, producto.stock, ban);
                }
                //Caso contrario Inserto el nuevo producto.
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

        public decimal GetSaldo()
        {
            try
            {
                return cajaService.Get();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void SetSaldo(decimal importe)
        {
            try
            {
                cajaService.SetSaldo(importe);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
