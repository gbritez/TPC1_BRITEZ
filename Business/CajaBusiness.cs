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
        private EHistorico _historico = new EHistorico();

        /// <summary>
        /// El valor booleano representa si es una compra (true) o venta (false)
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="ban"></param>
        public void Transaccion(List<EProducto> Producto, bool ban)
        {
            var Total = getTotal(Producto, ban);
            try
            {

                //Si es una compra checkeo si el producto ya existe y hago un Update
                if (prodService.CheckIfExists(Producto.First().id))
                {
                    if (ban)
                    {
                        prodService.UpdateStock(Producto.First().id, Producto.First().Cantidad, ban);
                    }
                    else
                    {
                        foreach (EProducto producto in Producto)
                        {
                            prodService.UpdateStock(producto.id, producto.Cantidad, ban);
                        }
                    }

                }
                //Caso contrario Inserto el nuevo producto.
                else
                {
                    prodService.Insert(Producto.First());
                }

                //Dependiendo si es compra o venta mando determinada tabla al historico
                if (ban)
                {
                    FillHistorico(Producto.First(), ban, Total);

                    _historico.nOperacion = cajaService.GetNextVal("COMPRA_HISTORICO");
                    cajaService.GrabarHistorico(_historico, "COMPRA_HISTORICO");
                }
                else
                {
                    _historico.nOperacion = cajaService.GetNextVal("VENTA_HISTORICO");
                    foreach (EProducto producto in Producto)
                    {
                        FillHistorico(producto, ban, Total);
                        cajaService.GrabarHistorico(_historico, "VENTA_HISTORICO");
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<EHistorico> GetHistorico(string tabla)
        {

            try
            {
                List<EHistorico> historico = cajaService.GetHistorico(tabla);
                return historico;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FillHistorico(EProducto producto, bool ban, decimal total)
        {
       
                _historico.cantidad = producto.Cantidad;
                _historico.descripcion = producto.tipo + " " + producto.marca;
                _historico.fecha = DateTime.Now;
                if (ban)
                {
                    _historico.precio = producto.precio;

                }
                else
                {
                    _historico.precio = producto.precioUnitario;
                }

            
            _historico.total = total;
        }

        private decimal getTotal(IList<EProducto> Producto, bool ban)
        {
            Decimal aux = 0;
            try
            {
                foreach (EProducto producto in Producto)
                {
                    if (ban)
                    {
                        aux += producto.precio * producto.Cantidad;
                        
                    }
                    else
                    {
                        aux += producto.precioUnitario * producto.Cantidad;
                    }

                }
                return aux;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
