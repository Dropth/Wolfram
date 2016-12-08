using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolfram {
    class Test {
        const int VOISINNAGE = 2;
        const int TAILLE = 300;
        const int ITE = 300;
        const int regle = 62;
        static void Main (string [] args) {
            int [] grille = new int [TAILLE];
            int [] temp = new int [TAILLE];

            Random r = new Random();
            for (int i = 0 ; i < TAILLE ; i++) {
                if (r.NextDouble() > 0.5)
                    grille [i] = 1;
                else
                    grille [i] = 0;
            }
            //grille[150] = 1;
            afficherGrille(grille);
            for (int i = 0 ; i < ITE ; i++) {
                for (int j = 0 ; j < TAILLE ; j++) {
                    temp [j] = calculEtatCellule(j,grille);
                }
                grille = new int [TAILLE];
                grille = temp;
                afficherGrille(grille);
                temp = new int [TAILLE];
            }
            Console.Read();
        }

        static int calculEtatCellule (int cell,int [] grille) {
            int ret = 0;
            int voisinAllume = calculVoisin(cell,grille);
            String masque = Convert.ToString(regle,2);
            //masque = masque + "0";
            while (masque.Length - 1 < VOISINNAGE * 2 + 1)
                masque = "0" + masque;
            char [] masq = masque.ToCharArray();
            Array.Reverse(masq);
            if (masq [voisinAllume].Equals('1'))
                ret = 1;
            return ret;
        }

        static int calculVoisin (int cell,int [] grille) {
            int nbAllume = 0;
            int cellTemp = cell;
            int iDroite = VOISINNAGE;
            int iGauche = VOISINNAGE;

            while (iDroite > 0) {
                cellTemp--;
                iDroite--;
                if (cellTemp == -1)
                    cellTemp = TAILLE - 1;
                if (grille [cellTemp] == 1)
                    nbAllume++;
            }
            cellTemp = cell;

            while (iGauche > 0) {
                cellTemp++;
                iGauche--;
                if (cellTemp == TAILLE)
                    cellTemp = 0;
                if (grille [cellTemp] == 1)
                    nbAllume++;
            }
            if (grille [cell] == 1)
                nbAllume++;
            return nbAllume;
        }

        static void afficherGrille (int [] grille) {
            for (int j = 0 ; j < TAILLE ; j++) {
                if (grille [j] == 1) {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    Console.ResetColor();
                }
                else {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
        }
    }
}
