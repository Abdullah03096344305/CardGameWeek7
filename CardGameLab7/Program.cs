using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameLab7.BL;
using System.Threading.Tasks;

namespace CardGameLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Enter 1 to Play the Game: ");
                Console.WriteLine("Enter 2 to Exit from the Game: ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    bool gameRunning = true;
                    int score = 0;
                    Deck obj = new Deck();

                    obj.shuffle();

                    Card card1 = obj.dealCard();
                    while (gameRunning)
                    {
                        int remain_check = obj.cardsLeft();
                        Card card2 = obj.dealCard();
                        Console.WriteLine("*********************************");
                        Console.WriteLine(card1.toString());
                        Console.WriteLine("");
                        Console.WriteLine("*** Remaining Cards *** " + remain_check);
                        Console.WriteLine("Enter 1 if the next card is higher.  ");
                        Console.WriteLine("Enter 2 if the next card if lower. ");

                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if(card_check == 1)
                        {
                            if(card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("Sorry You Lose Press Any key to Continue... ");
                                Console.WriteLine("The card was " + card2.toString());
                                Console.WriteLine("Your Score is " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if(card_check == 2)
                        {
                            if (card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("Sorry You Lose Press Any key to Continue... ");
                                Console.WriteLine("The card was " + card2.toString());
                                Console.WriteLine("Your Score is " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if(obj.cardsLeft() == 0 && card2 == null)
                        {
                            gameRunning = false;
                            Console.WriteLine("Congrats you scored Maximum ");
                            Console.ReadKey();
                            break;
                        }
                    }
                }


               

            }
            while (option != 2);
            
        }
    }
}
