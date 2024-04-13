using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            //Obter um numero aleatorio de 1 a 4
            int value = random.Next(1, 5);

            //Se for 1, retornar a string Espadas
            if (value == 1) return "Spades";

            //Se for 2, retornar a string Coracoes
            if (value == 2) return "Hearts";

            //Se for 3, retornar a string Clubes
            if (value == 3) return "Clubs";

            //Se ainda nao retornamos, retornar a string Diamantes
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int Value = random.Next(1, 14);
            if (Value == 1) return "Ace"; 
            if (Value == 11) return "Jack";
            if (Value == 12) return "Queen";
            if (Value == 13) return "King";

            return Value.ToString();
        }
    }
}
