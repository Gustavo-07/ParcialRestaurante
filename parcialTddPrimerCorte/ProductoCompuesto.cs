using parcialTddPrimerCorte;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioRestaurante.Core.Domain
{
    public class ProductoCompuesto : Producto
    {
        private List<ProductoSimple> Ingredientes;
        private decimal NumeroIngredientes { get; }

        public ProductoCompuesto(decimal codigo, string nombre, decimal costo, decimal precio) : base(codigo, nombre, costo, precio)
        {
            NumeroIngredientes = 0;
        }

        public string Retirar(decimal codigo, string nombre, decimal numeroIngredientes)
        {

            return "";
        }

        public void AgregarIngrediente(ProductoSimple ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }
    }
}
