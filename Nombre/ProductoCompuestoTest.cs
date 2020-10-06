using NUnit.Framework;
using System;

namespace InventarioRestaurante.Core.Domain.Test
{
    class ProductoCompuestoTest
    {

        [SetUp]
        public void Setup()
        {
        }

        //Escenario 05: Puede retirar cantidad mayor a cero producto compuesto
        //HU2: COMO USUARIO QUIERO REGISTRAR LA SALIDA DE PRODUCTOS.
        //Criterio de Aceptación:
        //3  En caso de un producto compuesto la cantidad de la salida se le disminuirá
        //   a la cantidad existente de cada uno de su ingrediente.
        //Ejemplo
        //Dado El usuario diligencia la salida de un perro caliente(
        //  código 002, nombre “pan perro caliente”, utilidad “preparación” costo 1000, precio 1500 cantidad 4.
        //  código 003, nombre “salchicha”, utilidad “preparación” costo 1000, precio 2000 cantidad 5.
        //  código 004, nombre “lamina de queso”, utilidad “preparación” costo 1000, precio 2500 cantidad 3.
        //Cuando Va a retirar una cantidad de 2.
        //Entonces El sistema presentará el mensaje "producto retirado exitosamente".

        [Test]
        public void NoPuedeRetirarCantidadMayorQueCeroProductoCompuestoTest()
        {
            //Preparar
            var productoCompuesto = new ProductoCompuesto(codigo: 001, nombre: "perro caliente", costo: 0, precio: 0);

            var productoSimple = new ProductoSimple(codigo: 002, nombre: "pan perro caliente", utilidad: "preparacion", costo: 1000, precio: 1500);
            productoSimple.Registrar(4);
             productoCompuesto.AgregarIngrediente(productoSimple);

            var productoSimple1 = new ProductoSimple(codigo: 003, nombre: "salchicha", utilidad: "preparacion", costo: 1000, precio: 2000);
            productoSimple1.Registrar(5);
            productoCompuesto.AgregarIngrediente(productoSimple1);


            var productoSimple2 = new ProductoSimple(codigo: 004, nombre: "lamina de queso", utilidad: "preparacion", costo: 1000, precio: 2500);
            productoSimple2.Registrar(3);
            productoCompuesto.AgregarIngrediente(productoSimple2);
            //Accion
            var resultado = productoCompuesto.Retirar(2);

            //Validación o verificación 
            Assert.AreEqual("producto retirado exitosamente", resultado);
        }


    }
}
