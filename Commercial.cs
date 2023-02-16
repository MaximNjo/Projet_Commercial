// NJO BOJONGO MAXIME 

using System;
namespace Projet_Commercial
{
    public class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }



        public Commercial(string nom, string prenom, int anneeNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.AnneeNaissance = anneeNaissance;
        }


        public int CalculAge()
        {

            int difference = DateTime.Now.Year - this.AnneeNaissance;
            return difference;

        }


        public override string ToString()
        {

            return "Nom : " + this.nom + "Prenom : " + this.prenom + " Année de Naissance : " + this.anneeNaissance;

        }



    }

}