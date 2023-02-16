// NJO BOJONGO MAXIME 

using System;
namespace Projet_Commercial
{
    class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;
        private Categorie nouveau;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public Categorie Nouveau { get => nouveau; set => nouveau = value; }

        

        public Commercial(string nom, string prenom, int anneeNaissance, Categorie nouveau)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.AnneeNaissance = anneeNaissance;
            this.Nouveau = nouveau;
        }


        public int CalculAge()
        {

            int difference = DateTime.Now.Year - this.AnneeNaissance;
            return difference;

        }


        public override string ToString()
        {

            return "Nom : " + this.nom + "Prenom : " + this.prenom + " Année de Naissance : " + this.anneeNaissance + "Nouveau :  " + this.nouveau;

        }



    }

}