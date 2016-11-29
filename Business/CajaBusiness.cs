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
        public void Transaccion(List<EProducto> Producto, bool ban, decimal saldo)
        {
            var Total = getTotal(Producto, ban);
            try
            {
                FillHistorico(Producto, ban, Total);

                //Si es una compra, valido tener saldo.
                if (ban && Total > saldo)
                {
                    throw new Exception("No posee saldo suficiente para realizar esta transacción.");
                }
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
                    cajaService.GrabarHistorico(_historico, "COMPRA_HISTORICO");
                }
                else
                {
                    cajaService.GrabarHistorico(_historico, "VENTA_HISTORICO");
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
                cajaService.SetSaldoInicial(importe);
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

        private void FillHistorico(List<EProducto> Producto, bool ban, decimal total)
        {
            foreach (EProducto producto in Producto)
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
                        aux += producto.precioUnitario * producto.Cantidad;
                    }
                    else
                    {
                        aux += producto.precio * producto.Cantidad;
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
