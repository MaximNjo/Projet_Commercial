using System;
using System.Security.Cryptography.X509Certificates;

namespace Projet_Commercial
{
    class Program
    {
        static void Main(string[] args)
        {


            Commercial commercial1 = new Commercial("NJO BOJONGO ", "Maxime", 2004);
            Commercial commercial2 = new Commercial("GNAGNON ", "Joris", 1992); 
            Commercial commercial3 = new Commercial("HALLYDAY ", "Johnny", 1702);
   
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


    }
}
