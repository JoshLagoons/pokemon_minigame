using static System.Console;

namespace pokemonTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputplayer1, inputBot;
            int randomNumber;
            bool playingAgain  = true;

            while(playingAgain)
            {
                    int scorePlayer = 0;
                    int scoreBot = 0;
            
                while(scorePlayer < 5 && scoreBot < 5)
                {
                     Write("Choose between a Fire type, Water type, and Grass type:    ");
                     inputplayer1 = ReadLine();
                     inputplayer1= inputplayer1.ToLower();
           

                     Random rnd = new Random();

                    randomNumber = rnd.Next(1,4);

                    switch(randomNumber)
                    {
                         case 1:
                         inputBot = "fire type";
                         WriteLine("The bot chose Fire type");
                         if(inputplayer1 == "fire")
                         {
                            WriteLine("both used same type so it's a DRAW\n\n");
                         }
                         else if (inputplayer1 == "water")
                         {
                            WriteLine("You win!! \n\n");
                            scorePlayer++;
                         }
                         else if (inputplayer1 == "grass")
                         {
                            WriteLine("Bot wins!! \n\n");
                            scoreBot++;
                         }
                        break;
                        case 2:
                         inputBot = "water type";
                         WriteLine("The bot chose Water type");
                        if(inputplayer1 == "water")
                        {
                           WriteLine("both used same type so it's a DRAW\n\n");
                        }
                        else if (inputplayer1 == "fire")
                        {
                            WriteLine("You win!! \n\n");
                            scorePlayer++;
                        }
                        else if (inputplayer1 == "grass")
                        {
                            WriteLine("Bot wins!! \n\n");
                            scoreBot++;
                        }
                        break;
                        case 3:
                        inputBot = "grass type";
                        WriteLine("The bot chose Grass type");
                        if(inputplayer1 == "grass")
                        {
                            WriteLine("both used same type so it's a DRAW\n\n");
                        }
                        else if (inputplayer1 == "fire")
                        {
                            WriteLine("You win!! \n\n");
                            scorePlayer++;
                        }
                        else if (inputplayer1 == "water")
                        {
                            WriteLine("Bot wins!! \n\n");
                            scoreBot++;
                        }
                        break;
                        default:
                        WriteLine("invalid try again");
                        break;
                    }
                    WriteLine("\n\nScores: Player 1:\t{0}\n\tBOT:\t\t{1}", scorePlayer,scoreBot);
                }
                       

                if(scorePlayer == 5)
                {
                    WriteLine("you officially won after 5 games");
                }
                else if(scoreBot == 5)
                {
                    WriteLine("you lost after 5 games :(");
                }
                    WriteLine("want to play again? y/n?");
                string loop = ReadLine();
                if(loop=="y")
                {
                    playingAgain = true;
                    Clear();
                }
                else if(loop=="n")
                {
                    playingAgain = false;
                }
                else
                {

                }
            
            }
        }
        
        
    }
}