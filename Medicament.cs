using System;
namespace GestionPharmacie
{
	public class Medicament
	{
		static int idEncounter = 0;
		private int IdMed { get; set; }
		public int getID()
		{
			return IdMed;
		}
		private string nameMed { get; set; }
		public string getName()
		{
			return nameMed;
		}
		private double priceMed { get; set; }
		public double getPrice()
		{
			return priceMed;
		}
		private int stockMed { get; set; }
		public int getStock()
		{
			return stockMed;
		}
		public void SetStock(int nouv)
		{
			stockMed = nouv;
		}

		public Medicament(string name,double price,int stock)
		{
			idEncounter++;
			IdMed = idEncounter;
			nameMed = name;
			priceMed = price;
			stockMed = stock;
		}
	}
}

