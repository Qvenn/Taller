/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:50 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int  precio;
			double descuento,total,descuentototal;
			Console.WriteLine("Ingrese el precio: ");
			precio=int.Parse(Console.ReadLine());
			if (precio>=200){
				descuento=0.15;
				descuentototal= precio*descuento;
				total= precio -descuentototal;
				Console.WriteLine("-Por la compra de un articulo superior o igual a $200 se le aplica un descuento del 15%, cuyo descuento es: "+"$"+descuentototal+" de: "+"$"+precio);
				Console.WriteLine("-Cuyo costo total es de: "+"$"+total);
			}else if (precio>100 && precio<200) {
				descuento=0.12;
				descuentototal=precio*descuento;
				total=precio-descuentototal;
				Console.WriteLine("-Por la compra de un articulo superior a $100 pero menor a $200 se le aplica un descuento del 12%, cuyo descuento es: "+"$"+descuentototal+" de: "+"$"+precio);
				Console.WriteLine("-Cuyo costo total es de: "+"$"+total);
				                  
			} else if (precio<100) {
				descuento=0.10;
				descuentototal=precio*0.10;
				total=precio-descuentototal;
				Console.WriteLine("-Por la compra de un articulo menor a $100 se le aplica un descuento del 10%, cuyo descuento es: "+"$"+descuentototal+" de: "+"$"+precio);
				Console.WriteLine("-Cuyo costo total es de: "+"$"+total);
			} else {
				Console.WriteLine("El precio ingresado no esta en la lista");
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}