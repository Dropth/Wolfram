/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolfram {
    class Program {
        static void Main (string [] args) {

            Console.Write("Entrer la règle");
            //int regle = Console.ReadLine();


            //String masque = Convert.ToString(regle,2);

            int [] ligne = new int [6];
            Random r = new Random();

            for (int i = 0 ; i < ligne.Length ; i++) {

                if (r.NextDouble() > 0.5)
                    ligne [i] = 1;
                else
                    ligne [i] = 0;
            }



        }

        public static int calculVoisin(int deb, int pos, int[] l) {

            int voisin;

            if (deb == 1)
                voisin = 1;
            else
                voisin = 0;

            if(pos == 0) {

                for(int i = pos + 1 ; i < 3 ; i++) {

                    if (l [i] == 1)
                        voisin++;
                }

                for(int j = l.Length ; j > l.Length-2 ; j--) {

                    if (l [j] == 1)
                        voisin++;
                }
            }
            else {

                if (pos == 1) {

                    for (int i = pos+1 ; i < 3 ; i++) {

                        if (l [i] == 1)
                            voisin++;
                    }

                    if (l [pos - 1] == 1)
                        voisin++;

                    for (int j = l.Length ; j > l.Length - 1 ; j--) {

                        if (l [j] == 1)
                            voisin++;
                    }
                }
                else {

                    for (int i = pos + 1 ; i < pos+3 ; i++) {

                        if (l [i] == 1)
                            voisin++;
                    }

                    for (int j = pos + 1 ; j > -1 ; j--) {

                        if (l [j] == 1)
                            voisin++;
                    }

                }
            }

            return voisin;
        }

        public static void calculRegle (String regle, int[] ligne) {

            //int regle = Console.ReadLine();
            //String masque = Convert.ToString(regle,2);
        }
    }
}*/
