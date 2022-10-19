using System;
using System.Text.RegularExpressions;

namespace Maison_Ex
{
    public class Terrain : Bien
    {
        public int CotéCloture;
        public bool Rivier;

        public Terrain(string adresse, float superficie, int cloture, bool rivier) : base(adresse,superficie)
        {
            CotéCloture = cloture;
            Rivier = rivier;
        }

        public override string ToString()
        {
            string toString = String.Format($"Nombre de Coté = {this.CotéCloture}\n");
            toString += String.Format("Présence d'une Rivière = {0}\n", this.Rivier ? "Oui" : "Non");
            toString += String.Format($"Valeur du bien = {this.EvaluationValeur()}$ \n");
            toString += String.Format($"Prix pour finir Cloture = {this.CoutFinirCloture()}");
            return toString;
        }

        public new float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Rivier) facteur -= 500;
            if (this.CotéCloture > 3) facteur += 300;
            if (Regex.IsMatch(this.Adresse, @"\bGronde Argent\b")) facteur -= 300;
            if (Regex.IsMatch(this.Adresse, @"\bMillenia\b")) facteur += 1000;

            return this.Superficie * facteur;
        }

        public float CoutFinirCloture()
        {
            return this.CotéCloture * 300f;
        }
    }
}
