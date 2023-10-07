using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Contact
    {
        public string Nom { get; set; }
        public string Email { get; set; }

        public string Type { get; set; }

        public Contact(string nom, string email)
        {
            Nom = nom;
            Email = email;
            Type = "Contact";

        }

        public override string ToString()
        {
            return $"Nom: {Nom}, Type: {Type}, Email: {Email}";
        }
    }
}

