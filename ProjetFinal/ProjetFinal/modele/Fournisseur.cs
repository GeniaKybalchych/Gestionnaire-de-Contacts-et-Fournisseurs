using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Fournisseur : Contact
    {
        public string CodeScn { get; set; }

        public Fournisseur(string nom, string email, string codeScn) : base(nom, email)
        {
            CodeScn = codeScn;
            Type = "Fournisseur";
        }

        public void PasserCommande()
        {
            // Logique de commande ici
        }
    }
}
