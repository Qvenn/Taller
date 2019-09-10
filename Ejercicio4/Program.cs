/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			String nombre;
			int unidadconsumidos;
			double importetotal;
			
			Console.WriteLine("Ingresar nombre");
			nombre=Convert.ToString(Console.ReadLine());
			Console.WriteLine("Ingresar unidad consumidos ");
			unidadconsumidos= int.Parse(Console.ReadLine());
			Console.WriteLine("");
			if (unidadconsumidos<=199) {
				importetotal= 1.20;
				Console.WriteLine("El usuario "+nombre+" debe pagar un importe total de: "+importetotal);
			} else if (unidadconsumidos>=200 && unidadconsumidos<400) {
				importetotal= 1.50;
				Console.WriteLine("El usuario "+nombre+" debe pagar un importe total de: "+importetotal);
			} else if (unidadconsumidos>=400 && unidadconsumidos<600) {
				importetotal= 1.80;
				Console.WriteLine("El usuario "+nombre+" debe pagar un importe total de: "+importetotal);
			} else if (unidadconsumidos>=600 && unidadconsumidos>600) {
				importetotal= 2.00;
				Console.WriteLine("El usuario "+nombre+" debe pagar un importe total de: "+importetotal);
			} else {
				Console.WriteLine("El valor digitado no esta disponible");
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}