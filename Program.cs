using System;
	
	namespace consola{ 
	
	public class Aritmetica
	{
		// atributos
		public float valor1 = 0;
		public float valor2 = 0;
		public float resultado = 0; 
		
		public static void Main(string[] args)
        {
			int opcion = 0;
			
			// menu
			Console.WriteLine(@$"
	1.Suma 
	2.Resta
	3.Multiplicacion
	4.Division ");
		
		Console.Write("\nSeleccione una operacion:"); 
		opcion = Convert.ToInt32(Console.ReadLine());
			
		// condiciones simples 
		if(opcion == 1)
		{ 
		SumaCL primerObjeto = new SumaCL();
		primerObjeto.CapturaSuma();
		primerObjeto.Suma();
		} 
		else if(opcion == 2)
		{ 
		RestaCL segundoObjeto = new RestaCL();
		segundoObjeto.CapturaResta();
		segundoObjeto.Resta();
		} 
		else if(opcion == 3)
		{ 
		MultiplicacionCL tercerObjeto = new MultiplicacionCL();
		tercerObjeto.CapturaMultiplicacion();
		tercerObjeto.Multiplicacion();
		} 
		else if(opcion == 4)
		{ 
		DivisionCL cuartoObjeto = new DivisionCL();
		cuartoObjeto.CapturaDivision();
		cuartoObjeto.Division();
		} 
			
		}
	}
		public class SumaCL: Aritmetica{
			// metodos
			public void CapturaSuma()
			{
				Console.WriteLine("Digite el valor 1:");
				valor1 = Single.Parse(Console.ReadLine());
				Console.WriteLine("Digite el valor 2:");
				valor2 = Single.Parse(Console.ReadLine());
			}
			public void Suma()
			{
				resultado = valor1 + valor2;
				Console.WriteLine("\nResultado Suma :" + resultado);
			} 
		} 
		public class RestaCL :Aritmetica{
			// metodos
			public void CapturaResta()
			{
				Console.WriteLine("Digite el valor 1:");
				valor1 = Single.Parse(Console.ReadLine());
				Console.WriteLine("Digite el valor 2:");
				valor2 = Single.Parse(Console.ReadLine());
			}
			public void Resta()
			{
				resultado = valor1 - valor2;
				Console.WriteLine("Resultado Resta :" + resultado);
			}
		} 
		public class MultiplicacionCL :Aritmetica{
			// metodos
			public void CapturaMultiplicacion()
			{
				Console.WriteLine("Digite el valor 1:");
				valor1 = Single.Parse(Console.ReadLine());
				Console.WriteLine("Digite el valor 2:");
				valor2 = Single.Parse(Console.ReadLine());
			}
			public void Multiplicacion()
			{
				resultado = valor1 * valor2;
				Console.WriteLine("Resultado Suma :" + resultado);
			}
		}
		public class DivisionCL :Aritmetica{
			// metodos
			public void CapturaDivision()
			{
				Console.WriteLine("Digite el valor 1:");
				valor1 = Single.Parse(Console.ReadLine());
				Console.WriteLine("Digite el valor 2:");
				valor2 = Single.Parse(Console.ReadLine());
			}
			public void Division()
			{
				resultado = valor1 / valor2;
				Console.WriteLine("Resultado Suma :" + resultado);
			}
	
		}
		
	} 