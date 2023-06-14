using System;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionPharmacie
{
	public class VenteMedicament
	{
		public void Sell(List<Medicament> medicaments)
		{
			WriteLine("------  Menu de vente  ------");
			WriteLine();

            List<Medicament> medicamentVendu = new();
            GenererFacture facturePrint = new();

            int arret = 0;
            do
            {
                WriteLine("Tapez 1 pour continuer la vente et 0 pour quitter");

                //Controle de saisie
                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisie incorect! Veuillez saisir (0) ou (1)");
                }
            } while (arret != 0 && arret != 1);

            while (arret == 1)
            {
                WriteLine("Saisissez l'id du médicament :");
                int idvente = Convert.ToInt32(ReadLine()!);
                WriteLine("Saisissez la quantité :");
                int qnt = Convert.ToInt32(ReadLine()!);


                int index = medicaments.FindIndex(m => m.getID() == idvente);

                    if (index != -1)
                    {
                        Medicament medoc = medicaments[index];

                        if ((1 * qnt) > medoc.getStock())
                        {
                            WriteLine("Stock insuffisant ! veuillez réduire la quantité");
                        }
                        else
                        {
                            int nouv = medoc.getStock() - (1 * qnt);
                            medoc.SetStock(nouv);
                        }

                        medicaments[index] = medoc;
                        medicamentVendu.Add(medoc);
                    }

                WriteLine("Tapez 1 pour ajouter un autre médicament et 0 pour quitter");
                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisie incorect! Veuillez saisir (0) ou (1)");
                }
            }
            WriteLine("------ Fin de la vente -------");
            WriteLine();

            facturePrint.printFac(medicamentVendu);
        }

		public VenteMedicament()
		{
		}
	}
}

