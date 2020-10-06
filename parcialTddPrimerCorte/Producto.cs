using System;

namespace parcialTddPrimerCorte
{
    public abstract class Producto
    {
        protected Producto(decimal codigo, string nombre, decimal costo, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Costo = costo;
            Precio = precio;

        }

        public decimal Codigo { get; }
        public string Nombre { get; }
        public decimal Costo { get; }
        public decimal Precio { get; }

        public virtual string Registrar(decimal Cantidad)
        {
            return "";
        }

        public virtual string Retirar(decimal cantidad)
        {
            return "";
        }

}
}
