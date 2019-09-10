/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:48 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1,n2,n3;
			Console.WriteLine("Ingresar un numero: ");
			n1=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresar segundo numero: ");
			n2=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresar tercer numero: ");
			n3=int.Parse(Console.ReadLine());
			if (n1>n2 && n1>n3){
				Console.WriteLine("El numero: "+n1+" Es la mayor de los tres numeros");
				
			}else if (n2>n1 && n2>n3) {
				Console.WriteLine("El numero: "+n2+" Es la mayor de los tres numeros");
				
			} else if (n3>n1 && n3>n2) {
				Console.WriteLine("El numero: "+n3+" Es la mayor de los tres numeros");
				
			} else if (n1==n2 && n1!=n3){
				Console.WriteLine("El numero: "+n1+" y "+n2+" son iguales, el tercer numero es: "+n3);
			} else if (n1!=n2 && n1==n3) {
				Console.WriteLine("El numero: "+n1+" y "+n3+" Son iguales, el segundo numero es: "+n2); 
			} else if (n2==n1 && n2!=n3) {
				Console.WriteLine("El numero: "+n2+" y "+n1+" Son iguales, el tercer numero es: "+n3);
			} else if (n2!=n1 && n2==n3) {
				Console.WriteLine("El numero: "+n2+" y "+n3+" Son iguales, el primero numero es: "+n1);
			} else if (n3==n1 && n3!=n2) {
				Console.WriteLine("El numero: "+n3+" y "+n1+" Son iguales, el segundo numero es: "+n2);
			} else if (n3!=n1 && n3==n2) {
				Console.WriteLine("El numero: "+n3+" y "+n2+" Son iguales, el primer numero es: "+n1);
			
			} else {
				Console.WriteLine("Todos los numeros son iguales"); }
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}