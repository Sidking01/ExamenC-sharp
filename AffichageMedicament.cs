using System;
using static System.Console;

namespace GestionPharmacie
{
	public class AffichageMedicament
	{
		public void print(List<Medicament> medicaments)
		{
			WriteLine("----- Liste des médicament -----");

			foreach(Medicament med in medicaments)
			{
				WriteLine("Numero :"+med.getID());
                WriteLine("Nom :" + med.getName());
                WriteLine("Prix :" + med.getPrice());
                WriteLine("Stock :" + med.getStock());
                WriteLine("------------------------");
            }

			ReadKey();
		}

		public AffichageMedicament()
		{
		}
	}
}

