using System;
using static System.Console;

namespace GestionPharmacie
{
	public class AjoutMedicament
	{
		public Medicament Add()
		{
			WriteLine("Saisissez le nom du medicament :");
			string name = ReadLine()!;
			WriteLine("Saisissez le prix :");
			double price = Convert.ToDouble(ReadLine()!);
			WriteLine("Quantité en stock :");
			int stock = Convert.ToInt32(ReadLine()!);

			Medicament med = new(name, price, stock);

			return med;
		}
		public AjoutMedicament()
		{
		}
	}
}

