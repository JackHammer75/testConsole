using System;


namespace testConsole
{
	class Program
	{
		static void Main(string[] args)

		{
			int valeur, nombre, nbre = 1;
			Console.Write("Entrez le nombre à chercher :");
			valeur = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.ReadLine();
			Console.Write("entrez un nombre:");
			nombre = int.Parse(Console.ReadLine());
			while (nombre != valeur)
			{
				if (nombre > valeur)
				{
					Console.WriteLine("c'est trop grand, bouffon!!");
				}
				else
				{
					Console.WriteLine("c'est trop ptit, comme ta bite!!");
				}

				//saisie d'un nouvel essai:
				Console.Write("entre un nouvel essai stp:");
				nombre = int.Parse(Console.ReadLine());
				nbre = nbre + 1;
			}
			
			
			Console.WriteLine("t'as trouvé en " + nbre + " fois!");
			Console.ReadLine();
		}
		
		
			
        
	}
}
