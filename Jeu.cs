using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace ExemplePOO
{

    public class Jeu : Program
    {

        public readonly int NbManches = 5;
        public readonly int NbDes = 5;
        //List<De> Des = new List<De>();
        public static readonly List<De> Des = new List<De>() { }; //"PremierDe", "DeuxiemeDe", "TroisiemeDe", "QuatriemeDe", "CinquiemeDe"};
        public override string ToString()
        {
            Console.WriteLine("[{0}] [{1}] [{2}] [{3}] [{4}]"); // then, .remove last :D
            return base.ToString();
        }

        public int Relancer(int i) //int
        {
            int playerChoice = int.Parse(Console.ReadLine());
            var subList = Des[playerChoice];

            //i = new Piece(Des[]);
            return i;
        }

        public int Score() //int
        {
            int score = 0;
            int displayScore = 0;
            foreach (De i in Des)
            {
                score = score + i.NbFaces;
                displayScore = score;
                return displayScore;
            }
            return displayScore;
        }

        public void Run() //int
        {
            
            Console.WriteLine("Lequel voulez-vous relancer? : {0}, {1}, {2}, {3}, {4}, {5}");
            
        }

    
    }
}