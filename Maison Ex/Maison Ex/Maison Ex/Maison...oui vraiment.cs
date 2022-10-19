using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Maison_Ex
{
    public class Maison : Bien
    {
        public int NbPiece;
        public bool Jardin;
        public Piece[] Pieces;
        public static readonly List<string> NomsPieces = new List<string> { "Kuisine", "Chambre", "Salle de Bain", "Salle", "Salle a Manger", "Garage", "Bureau", "Terrasse", "Dressing", "Une Double Basque", "Une Salle du Trone", "Un Observatoire", "Une Ecluse" };

        public Maison(string adresse, float superficie, int nbpiece, bool jardin) : base (adresse, superficie)
        {
            NbPiece = nbpiece;
            Jardin = jardin;
            Pieces = new Piece[NbPiece];

            Random ran = new Random();

            for(int i =0; i < NbPiece; i++)
            {
                Pieces[i] = new Piece(ran.Next(10, 30), NomsPieces[ran.Next(0, NomsPieces.Count)]);
                Superficie += Pieces[i].Superficie;
            }
        }

        public override string ToString()
        {
            string toString = base.ToString();
            toString = String.Format($"Nombre de Piece = {this.NbPiece}\n");
            for(int it = 0; it < this.NbPiece; it++) {
                toString += String.Format($"- {this.Pieces[it]}");
            }
            toString += String.Format("Présence de Jardin = {0}\n", this.Jardin ? "Oui" : "Non");
            toString += String.Format($"Valeur du bien = {this.EvaluationValeur()}$");
            return toString;
        }

        public new float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Jardin) facteur += 500;
            if (this.NbPiece > 3) facteur += 300;
            if (Regex.IsMatch(this.Adresse, @"\bGronde Argent\b")) facteur -= 300;

            return this.Superficie * facteur;
        }
    }
}
