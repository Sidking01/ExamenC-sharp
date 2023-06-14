using System;
namespace GestionPharmacie
{
	public class Facture
	{
		public int numFac { get; set; }
		public string? client { get; set; }
		public DateTime DateCreation { get; set; }
		public List<Medicament>? facLine;

		public Facture(int id,string leclient,List<Medicament> laliste)
		{
			numFac = id;
			client = leclient;
			DateCreation = DateTime.Today;
			facLine = laliste;
		}

		public Facture()
		{

		}
	}
}

