using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class De : Jeu
    {
        public int NbFaces;
        private Random random;

        public int Face { get; private set; }
        public override string ToString()
        {

            return base.ToString();
        }

        public virtual int Lancer()
        {
            NbFaces = random.Next(1, 6);
            return NbFaces;
        }
    }
}