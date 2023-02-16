using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Projet_Commercial
{
    class Program
    {

        private Commercial[] commerciaux; // tableau de commerciaux
        private int nbCommerciaux;



        static void Main(string[] args)
        {
            // Les 2 categories

            Categorie independant = new Categorie("A01", "salarie") ;
            Categorie salarie = new Categorie("A02","independant") ;

            // Les 3 commerciaux

            Commercial commercial1 = new Commercial("NJO BOJONGO ", "Maxime", 2004, new Categorie("A1", "indépendant"));
            Commercial commercial2 = new Commercial("GNAGNON ", "Joris", 1992, new Categorie("A2", "indépendant")); 
            Commercial commercial3 = new Commercial("HALLYDAY ", "Johnny", 1702, new Categorie("A3", "indépendant"));
   
            // 2 services 

            Service national = new Service();
            Service international = new Service();

      
            Console.WriteLine("Information commerciale 1 : " + commercial1);
            Console.WriteLine("Information commerciale 2 : " + commercial2);
            Console.WriteLine("Information commerciale 3 : " + commercial3);



        }

        public string Compare(string c, string c2)
        {

            if(c == c2)
            {

                Console.WriteLine("Vous portez le même nom de famille que quelqu'un ");

            } else
            {

                Console.WriteLine("Votre nom de famille est unique");

            }

            return c + c2;


        }
        public string AjouterCommercial(Commercial commercial)
        {
            if (effectif < commerciaux.Length)
            {
                commerciaux[effectif] = commercial;
                effectif++;

            }
        }


        public void AfficherCommerciaux()
            {
                Console.WriteLine("Commerciaux du service :");
                foreach (Commercial commercial in commerciaux)
                {
                    if (commercial != null)
                    {
                        Console.WriteLine({commercial.Nom};
                    }
                }
            }


        }


    
}
