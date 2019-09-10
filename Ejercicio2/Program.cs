/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 10/09/2019
 * Time: 05:21 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int b,altura,opcio,radio;
            double area;
            Console.WriteLine("Ingrese 1 para el area del circulo ");
            Console.WriteLine("Ingrese 2 para el area del rectangulo ");
            Console.WriteLine("Ingrese 3 para el area del triangulo");
            Console.WriteLine("");
            Console.WriteLine("Digite su opcion" );
            opcio= int.Parse(Console.ReadLine());  
            Console.WriteLine("");
            if (opcio==1) {
            Console.WriteLine("Digite el radio del circulo: ");
            radio=int.Parse(Console.ReadLine());
            area= Math.PI*radio*(Math.Pow(radio,2));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("El area del circulo es: "+area);
            } else if (opcio==2){
           
            Console.WriteLine("Digite la base del triangulo" );
            b= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite la altura del triangulo" );
            altura=int.Parse(Console.ReadLine());
            
            area= b*altura;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El area del del rectangulo es: "+area);
			} else if (opcio==3) {
            	Console.WriteLine("Digite la base del triangulo");
            	b=int.Parse(Console.ReadLine());
            	Console.WriteLine("Digite la altura del triangulo");
            	altura= int.Parse(Console.ReadLine());
            	area=(b*altura)/2;
            	Console.WriteLine("---------------------------------------");
            	Console.WriteLine("El area del triangulo es: "+area);
            } else{
            	Console.WriteLine("La opcion ingresada no esta disponible, por favor ingresar del 1-3");
            }
			// TODO: Implement Functionality Here
			Console.WriteLine("");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}