using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class DeTruque : De
    {
        public override int Lancer()
        {
            Random obtainSix = new Random();
            int chance = obtainSix.Next(1, NbFaces);

            if (chance <= 3) // probability of 50%
            {
                int resultat = 6;
                return resultat;
            }
            else
            {
                Random obtainFive = new Random();
                int chance2 = obtainFive.Next(1, NbFaces);

                if (chance2 <= 2) // probability of 17%
                {
                    int resultat = 5;
                    return resultat;
                }
                else
                {
                    Random obtainOneTwoThreeFour = new Random();
                    int chance3 = obtainOneTwoThreeFour.Next(1, NbFaces);

                    if (chance3 <= 1) //One chance out of 12
                    {
                        int resultat = obtainOneTwoThreeFour.Next(1, 4);
                        return resultat;
                    }
                }
            }
            return Lancer(); //to prevent error
        }
    }
}