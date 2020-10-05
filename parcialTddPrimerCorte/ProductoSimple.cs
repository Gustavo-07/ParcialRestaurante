using parcialTddPrimerCorte;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioRestaurante.Core.Domain
{
    public class ProductoSimple : Producto
    {
        public ProductoSimple(decimal codigo, string nombre, string utilidad, decimal costo, decimal precio) : base(codigo, nombre, utilidad, costo, precio)
        {
        }

        public override string Registrar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Cantidad = cantidad;
                Estado = "disponible";
                return $"el registro del producto: {Nombre} fue realizado, cantidad: {cantidad} ";
            }
            return "la cantidad para el registro del productos es incorrecta";

        }

        public override string Retirar(decimal cantidad)
        {
            if (Estado.Equals("nodisponible"))
            {

            }
        }
    }
}
