using NUnit.Framework;
using System;

namespace InventarioRestaurante.Core.Domain.Test
{
    public class ProductoSimpleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Escenario 01: Cantidad de entrada superior a cero 
        //HU1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS.
        //Criterio de Aceptación:
        //1  La cantidad de la entrada de debe ser mayor a 0.
        //Ejemplo
        //Dado El usuario diligencia una entrada de 15 unidades a un  
        //producto código 001, nombre “gaseosa litro”, utilidad “ventaDirecta” costo 2000, precio 5000.
        //Cuando Va a registrar una cantidad mayor a 0.
        //Entonces El sistema presentará el mensaje “el registro del producto: “gaseosa litro”, fue realizado, cantidad: 15 ”.

        [Test]
        public void PuedeRegistrarCantidadEntradaSuperiorCeroTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(codigo: 001, nombre: "gaseosa litro", utilidad: "ventaDirecta", costo: 2000, precio: 5000);

            //Accion
            var resultado = productoSimple.Registrar(15);

            //Validación o verificación 
            Assert.AreEqual("el registro del producto: gaseosa litro fue realizado, cantidad: 15 ",resultado);
         }

        //Escenario 02: Cantidad de entrada igual a cero
        //HU1: COMO USUARIO QUIERO REGISTRAR LA ENTRADA PRODUCTOS.
        //Criterio de Aceptación:
        //1  La cantidad de la entrada de debe ser mayor a 0.
        //Ejemplo
        //Dado El usuario diligencia una entrada de 0 unidades a un  
        //producto código 001, nombre “gaseosa litro”, utilidad “ventaDirecta” costo 2000, precio 5000.
        //Cuando Va a registrar una cantidad de 0.
        //Entonces El sistema presentará el mensaje “la cantidad para el registro del productos es incorrecta”.

        [Test]
        public void NoPuedeRegistrarCantidadEntradaCeroTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(codigo: 001, nombre: "gaseosa litro", utilidad: "ventaDirecta", costo: 2000, precio: 5000);

            //Accion
            var resultado = productoSimple.Registrar(0);

            //Validación o verificación 
            Assert.AreEqual("la cantidad para el registro del productos es incorrecta", resultado);
        }

        //Escenario 03: Puede retirar cantidad mayor a cero producto simple
        //HU1: COMO USUARIO QUIERO REGISTRAR LA SALIDA DE PRODUCTOS.
        //Criterio de Aceptación:
        //1  La cantidad de la salida de debe ser mayor a 0.
        //Ejemplo
        //Dado El usuario diligencia una salida de 5 unidades a un producto: código 001, 
        //     nombre “gaseosa litro”, utilidad “ventaDirecta” costo 2000, precio 5000. 
        //     Con una cantidad de 15 unidades en el sistema.
        //Cuando Va a registrar una cantidad de 5.
        //Entonces El sistema presentará el mensaje “la salida del producto: “gaseosa litro”,
        //         fue realizada, cantidad en inventario: 10 unidades.

        [Test]
        public void PuedeRetirarCantidadMayorCeroProductoSimpleTest()
        {
            //Preparar
            var productoSimple = new ProductoSimple(codigo: 001, nombre: "gaseosa litro", utilidad: "ventaDirecta", costo: 2000, precio: 5000);
            productoSimple.Registrar(15);
            //Accion
            var resultado = productoSimple.Retirar(5);

            //Validación o verificación 
            Assert.AreEqual("la salida del producto: gaseosa litro, fue realizada, cantidad restante en inventario: 10 unidades.", resultado);
        }
    }
}