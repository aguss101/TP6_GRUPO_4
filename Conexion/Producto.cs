using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_4.Conexion
{
    public class Producto
    {

        public int _IdProducto;
        public string _NombreProducto;
        public string _CantidadPorUnidad;
        public decimal _PrecioUnitario;



        public Producto(int idProducto)
        {
            _IdProducto = idProducto;
        }

        public Producto(int idProducto, string NombreProducto, string CantidadPorUnidad, decimal PrecioUnitario)
        {
            _IdProducto = idProducto;
            _NombreProducto = NombreProducto;
            _CantidadPorUnidad = CantidadPorUnidad;
            _PrecioUnitario = PrecioUnitario;
        }


        public int idProducto
        {
            get
            {
                return _IdProducto;
            }

            set
            {
                _IdProducto = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return _NombreProducto;
            }
            set
            {
                _NombreProducto = value;
            }
        }

        public string CantidadPorUnidad
        {
            get
            {
                return _CantidadPorUnidad;
            }
            set
            {
                _CantidadPorUnidad = value;
            }
        }

        public decimal PrecioUnitario
        {
            get
            {
                return _PrecioUnitario;
            }
            set
            {
                _PrecioUnitario = value;
            }
        }

    }
}
