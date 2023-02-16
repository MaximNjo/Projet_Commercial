using Projet_Commercial;
using System;

public class Service
{

	private string nomService;
    private int effectif;
    int[] tableau = new int[10];



    public string NomService { get => nomService; set => nomService = value; }
    public int Effectif { get => effectif; set => effectif = value; }
    public int[] Tableau { get => tableau; set => tableau = value; }



      
      

        public string CommercialAge()
        {
            Commercial commercialLePlusAge = null;
            int ageMax = int.MinValue;
            foreach (Commercial commercial in Commercial)
            {
                if (commercial != null && commercial.AnneeNaissance > ageMax)
                {
                    commercialLePlusAge = commercial;
                    ageMax = commercial.AnneeNaissance;
                }
            }
            return commercialLePlusAge;
        }
 


}

