using System;

namespace parcialTddPrimerCorte
{
    public abstract class Producto
    {
        protected Producto(decimal codigo, string nombre, string utilidad, decimal costo, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = 0;
            Utilidad = utilidad;
            Costo = costo;
            Precio = precio;
            Estado = "nodisponible";
        }

        public decimal Codigo { get; }
        public string Nombre { get; }
        public decimal Cantidad { get; set; }
        public string Utilidad{ get; }
        public decimal Costo { get; }
        public decimal Precio { get; }
        public string Estado { get; set;  }

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
