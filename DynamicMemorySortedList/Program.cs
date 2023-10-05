using System;
using System.Collections.Generic;

class Program
	{
	static void Main()
		{
		SortedList<string, string> diccionario = new SortedList<string, string>();

		// Agregar palabras al diccionario
		diccionario.Add("hello", "hola");
		diccionario.Add("goodbye", "adiós");
		diccionario.Add("bicycle", "bicicleta");
		diccionario.Add("car", "coche");

	
		string palabraBuscada = "hello";
		if (diccionario.ContainsKey(palabraBuscada))
			{
			Console.WriteLine($"{palabraBuscada} en español es: {diccionario[palabraBuscada]}");
			}
		else
			{
			Console.WriteLine($"La palabra '{palabraBuscada}' no está en el diccionario.");
			}
		}
	}
