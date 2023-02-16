using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Commercial 
{
    class Categorie
    {

        private string codeCategorie;
        private string libCategorie;
       

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Categorie(string CodeCategorie, string LibCategorie)
        {

            this.codeCategorie = CodeCategorie;
            this.LibCategorie = LibCategorie;

        }

        public override string ToString()
        {

            return CodeCategorie + " " + LibCategorie;


        }

    }
}
