﻿using parcialTddPrimerCorte;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioRestaurante.Core.Domain
{
    public class ProductoSimple : Producto
    {
        private decimal Cantidad { get; set; }
        private string Utilidad { get; }
        string Estado { get; set; }
        private decimal CostoProducto { get; set; }
        private decimal PrecioVenta { get; set; }

        public ProductoSimple(decimal codigo, string nombre, string utilidad, decimal costo, decimal precio) : base(codigo, nombre, costo, precio)
        {
            Cantidad = 0;
            Utilidad = utilidad;
            Estado = "nodisponible";
        }


        public override string Registrar(decimal cantidadRegistro)
        {
            if (cantidadRegistro > 0)
            {
                Cantidad += cantidadRegistro;
                Estado = "disponible";
                return $"el registro del producto: {Nombre} fue realizado, cantidad: {cantidadRegistro} ";
            }
            return "la cantidad para el registro del productos es incorrecta";

        }

        public override string Retirar(decimal cantidadRetiro)
        {
            if (Estado.Equals("nodisponible"))
            {
                return "el producto que desea retirar no tiene existencia";
            }

            if (cantidadRetiro <= 0)
            {
                return "la cantidad para el registro de salida de productos es incorrecta";
            }

            if (Utilidad.Equals("preparación"))
            {
                return "el producto seleccionado no es para venta directa";
            }

            if (cantidadRetiro > Cantidad)
            {
                return "la cantidad solicitada es mayor que la cantidad registrada en el sistema";
            }

                Cantidad -= cantidadRetiro;
            registrarTransaccion(Costo, Precio, cantidadRetiro);

            if (Cantidad == 0)
            {
                Estado = "nodisponible";
            }

            return $"la salida del producto: {Nombre}, fue realizada, cantidad restante en inventario: {Cantidad} unidades";

        }

        private void registrarTransaccion(decimal costoProducto,decimal precioProducto, decimal cantidadProducto)
        {
            CostoProducto = costoProducto;
            PrecioVenta = precioProducto * cantidadProducto;
        }
    }
}
