using System;
using System.Text.RegularExpressions;

namespace Maison_Ex
{
    public class Bien
    {
        public string Adresse;
        public float Superficie;

        public Bien(string adresse, float superficie)
        {
            Adresse = adresse;
            Superficie = superficie;
        }

        public override string ToString()
        {
            string toString = String.Format($"Adresse = {this.Adresse}\n");
            toString += String.Format($"Superficie = {this.Superficie}\n");
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            return this.Superficie * facteur;
        }
    }
}