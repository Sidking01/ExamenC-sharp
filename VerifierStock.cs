using System;
using static System.Console;
namespace GestionPharmacie
{
	public class VerifierStock
	{
		public void check(List<Medicament> medicaments)
		{
			foreach(var med in medicaments)
			{
				if (med.getStock() < 10)
				{
					WriteLine($"Le médicament {med.getName()} va bientot etre en rupture de stock !");
				}
				else
				{
					WriteLine("Stock bien approvisionner !");
				}
			}
		}
		public VerifierStock()
		{
		}
	}
}

