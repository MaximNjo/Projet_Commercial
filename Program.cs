using System;
using System.Security.Cryptography.X509Certificates;

namespace Projet_Commercial
{
    class Program
    {
        static void Main(string[] args)
        {



            Commercial commerciaux = new Commercial("ROLLAND", "Stéphane", 1990);
            Console.WriteLine(commerciaux);




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


    }
}
