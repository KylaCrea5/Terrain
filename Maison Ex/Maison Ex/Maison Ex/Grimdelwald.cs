using System;
using System.Text.RegularExpressions;

namespace Maison_Ex
{
    public class Propriétaire
    {
        public string Nom;
        public string Prenom;
        public Bien[] Habitation = new Bien[0]; 

        public Propriétaire(string nom, string prenom, Bien[] habitation)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Habitation = habitation;
        }

        private string ListedesBien()
        {
            string lalistedesbien = "";
            
            foreach(Bien B in this.Habitation)
            {
                lalistedesbien += String.Format("-{0}", B.GetType().Name == "Maison" ? "Une" + $" {B.GetType().Name}" + $" au {B.Adresse}\n" : "Un" + $" {B.GetType().Name}"  + $" au {B.Adresse}\n");
            }

            return lalistedesbien;
        }

        public override string ToString()
        {
            string toString = String.Format($"{Nom} {Prenom} " + "{0}", this.Habitation ?.Length != 0 ? "posséde\n" : "ne posséde rien\n");
            toString += ListedesBien();

            return toString;
        }
    }
}
