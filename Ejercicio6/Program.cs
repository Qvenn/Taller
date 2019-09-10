/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:47 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double Fn,n;
			Console.WriteLine("Ingresar la potencia que desea elevar ");
			n=Convert.ToDouble(Console.ReadLine());
			Fn=1/(Math.Sqrt(5))*(Math.Pow((1+Math.Sqrt(5)/2),n)-Math.Pow((1-Math.Sqrt(5)/2),n));
			Console.WriteLine("El resultado de Fn es: "+Fn);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}