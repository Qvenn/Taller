/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:26 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int op;
			Console.WriteLine("Ingrese un numero del mes: ");
			op=int.Parse(Console.ReadLine());
			if (op==1) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de enero ");
				Console.WriteLine("El mes de enero tiene 31 Días ");
			} else if (op==2) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de febrero ");
				Console.WriteLine("El mes de febrero tiene 28 Días ");
			} else if (op==3) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de marzo ");
				Console.WriteLine("El mes de marzo tiene 31 Días ");
			} else if (op==4) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de abril ");
				Console.WriteLine("El mes de abril tiene 30 Días ");
			} else if (op==5) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de mayo ");
				Console.WriteLine("El mes de mayo tiene 31 Días ");
			} else if (op==6) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de junio ");
				Console.WriteLine("El mes de junio tiene 30 Días ");
			} else if (op==7) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de julio ");
				Console.WriteLine("El mes de julio tiene 31 Días ");
			} else if (op==8) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de agosto ");
				Console.WriteLine("El mes de agosto tiene 31 Días ");
			} else if (op==9) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de septiembre ");
				Console.WriteLine("El mes de septiembre tiene 30 Días ");
			} else if (op==10) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el Mes de octubre ");
				Console.WriteLine("El Mes de octubre tiene 31 Días ");
			} else if (op==11) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de noviembre ");
				Console.WriteLine("El mes de noviembre tiene 30 Días ");
			} else if (op==12) {
				Console.WriteLine("El numero ingresado: "+op);
				Console.WriteLine("Es el mes de diciembre ");
				Console.WriteLine("El mes de diciembre tiene 31 Días ");
			} else {
				
				Console.WriteLine("El numero ingresado: "+op+" no se encuentra registrado, por favor ingresar del 1-12, segun el mes. ");
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}