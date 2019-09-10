/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:19 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1,n2,adicion,sustraccion,multiplicacion,division,opcion;
            Console.WriteLine("Introduzca el primer numero");
            n1= int.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            Console.WriteLine("Itroduzca el segundo numero");
            n2=int.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            Console.WriteLine("Intruzca que operacion desea: ");
            Console.WriteLine("1- Adicion:  '+' ");
            Console.WriteLine("2- Sustraccion: '-' ");
            Console.WriteLine("3- Multiplicacion: '*' ");
            Console.WriteLine("4- Division: '/' ");
            opcion=int.Parse(Console.ReadLine());
            
            
            
            Console.WriteLine("");
            
            
            Console.WriteLine("Su eleccion fue: "+opcion);
            Console.WriteLine("");
            Console.WriteLine("");
            if (opcion==1) {
                adicion= n1+n2;
                Console.WriteLine("La suma entre "+n1+" y "+n2+" es igual a: "+adicion);
            } else if (opcion==2) {
                sustraccion=n1-n2;
                Console.WriteLine("La resta entre "+n1+" y "+n2+" es igual a: "+sustraccion);
            } else if (opcion==3) {
                multiplicacion= n1*n2;
                Console.WriteLine("La multiplicacion entre "+n1+" y "+n2+" es igual a: "+multiplicacion);
            } else if (opcion==4) {
                division=n1/n2;
                Console.WriteLine("La division entre "+n1+" y "+n2+" es igual a: "+division);
            } else {
                Console.WriteLine("El numero ingresado no esta disponible por favor, digite del 1 al 4 para realizar una operacion");
            } 
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}