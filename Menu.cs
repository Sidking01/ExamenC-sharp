using System;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionPharmacie
{
    public class Menu
    {
        public void MenuProgram()
        {
            int choix;
            List<Medicament> lesMedicaments = new List<Medicament>();
            AjoutMedicament adding = new();
            AffichageMedicament aff = new();
            VenteMedicament vente = new();
            VerifierStock verification = new();

            do
            {
                WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                WriteLine("+        Bienvenu, veuillez choisir l'action à effectuer :      +");
                WriteLine("+                1, Ajouter un médicament                       +");
                WriteLine("+                2, Afficher un médicament                      +");
                WriteLine("+                3, Vente de médicament                         +");
                WriteLine("+                4, Vérifier le stock                           +");
                WriteLine("+                5, Quitter                                     +");
                WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                choix = Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    //cas 1 permet d'ajouter un médicament 
                    case 1:
                        int arret = 0;
                        do
                        {
                            WriteLine("Voulez-vous ajouter un médicament ?");
                            WriteLine("Tapez 1 pour ajouter et 0 pour quitter");

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
                            var medicament = adding.Add();
                            lesMedicaments.Add(medicament);
                            WriteLine("Ajout effectué avec succes !");

                            WriteLine();
                            Console.WriteLine("Voulez vous créer une autre facture ?");
                            Console.WriteLine("Tapez 1.pour créer et 0.pour quitter");
                            arret = Convert.ToInt32(Console.ReadLine());
                        }

                        break;
                    case 2:
                        aff.print(lesMedicaments);
                        break;
                    case 3:
                        vente.Sell(lesMedicaments);
                        break;
                    case 4:
                        verification.check(lesMedicaments);
                        break;
                }
            } while (choix != 5);
        }
    }
}

