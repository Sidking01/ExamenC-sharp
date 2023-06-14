using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace GestionPharmacie
{
	public class GenererFacture
	{
		public void printFac(List<Medicament> medicaments)
		{
            WriteLine("Numero facture :");
            int n = Convert.ToInt32(ReadLine()!);
            WriteLine("Nom du client :");
            string clt = ReadLine()!;

			Facture facture = new(n,clt,medicaments);

            WriteLine("--------   Facture   --------"); 
            WriteLine($"Facture ID : {facture.numFac}");
            WriteLine($"Date : {facture.DateCreation}");
            WriteLine($"Client : {facture.client}");
            WriteLine();
            WriteLine("----- MEDICAMENT(s) -----");
            WriteLine();

            foreach (var med in medicaments)
			{
                WriteLine("Nom médicament:" + med.getName());
                WriteLine("------------------------");
                WriteLine("Prix unitaire:" + med.getPrice());
                WriteLine("------------------------");
                WriteLine();
            }

            ReadKey();
		}
		public GenererFacture()
		{
		}
	}
}

