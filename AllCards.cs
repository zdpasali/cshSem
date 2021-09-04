using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHseminar
{
    public class AllCards
    {
        private const int Max = 52;
        //private Random rn;
        public List<Card> deck2 = new List<Card>();

        public Card choosen;

        //public List<Card> deck2;

        public AllCards()  //ili private
        {
            string[] broj = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] simbol1 = { "Hearts", "Clubs", "Diamonds", "Spades" }; //zamjenit sa UNICODE
            string[] simbol = { "\u2660", "\u2663", "\u2665", "\u2666" };

            //deck = new Card[Max];


            //foreach(var sim in simbol)
            //{
            //    deck2.Add(new Card(sim,))
            //}

            //for (int y = 0; y < Max; y++)
            for (int i = 0; i < 13; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    deck2.Add(new Card(broj[i], simbol[z]));
                }
            }



        }



        public int CardsLeftNum => deck2.Count;
        
        public string Choose()
        {
            //position in deck - random pozicija
            Random rn = new Random();
            int positionInDeck = rn.Next(CardsLeftNum);

            Card choosen = deck2[positionInDeck];
            deck2.RemoveAt(positionInDeck);

            

            return choosen.Rez();
            
        }

        


    }

    

}
