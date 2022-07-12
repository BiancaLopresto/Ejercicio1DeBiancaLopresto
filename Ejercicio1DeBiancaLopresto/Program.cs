using System;


class ejercicio1debiancalopresto
{

	static void Main(string[] args)
	{
		double multiplicacion;
		double numero1;
		double resultado;
		Console.Write("Ingrese los dolares: ");
		numero1 = Double.Parse(Console.ReadLine());
		multiplicacion = numero1 * 230;
		Console.WriteLine("Cantidad en pesos en el mercado oficial: " + multiplicacion);
		multiplicacion = numero1 * 280;
		Console.WriteLine("Cantidad de pesos en el mercado paralelo: " + multiplicacion);
		resultado = multiplicacion * 1.17;
		Console.WriteLine("Cantidad en euros con el dolar en mercado oficial: " + resultado);
		resultado = numero1 * 1.17;
		Console.WriteLine("Cantidad en euros con el dolar en mercado paralelo: " + resultado);
	}

}




