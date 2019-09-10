/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:44 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Char letra;
			Console.WriteLine("Ingrese una letra: ");
			letra=Char.Parse(Console.ReadLine());
			if (letra== 'a' || letra== 'e' || letra== 'i' || letra == 'o' || letra == 'u' || letra== 'A' || letra== 'E' || letra== 'I' || letra == 'O' || letra == 'U') {
				Console.WriteLine("La letra: "+letra+" Es una vocal ");
			} else {
				
				Console.WriteLine("La letra: "+letra+" Es una consonante ");
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}