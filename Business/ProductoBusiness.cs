﻿using System;
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
        private ProductoService productoService = new ProductoService();


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

        public EProducto GetByID(int ID)
        {
            try
            {
                return productoService.GetByID(ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<EProducto> GetByFilter(string filter, string busqueda)
        {
            try
            {
                var list = new List<EProducto>();
                list = productoService.GetByFilter(filter, busqueda);
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ETipos> GetTipos()
        {
            try
            {
                var Lista = new List<ETipos>();
                Lista = productoService.GetTipos();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    
}
