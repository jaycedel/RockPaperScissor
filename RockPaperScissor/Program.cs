using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;


namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Choose between Rock, Paper and Scissors:   ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();
            Random rnd = new();
            randomInt = rnd.Next(1,4);
            //testing adding comment only
            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose Rock");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Draw!!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Player wins!! \n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS") 
                    {
                        Console.WriteLine("CPU Wins!!\n\n");
                        scoreCPU++; 
                     }
                        break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose Paper");

                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU wins!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Draw!! \n\n");
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("PLayer Wins!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose Scissor");

                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Player wins!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU wins!! \n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS") 
                    {
                        Console.WriteLine("Draw!!\n\n");
               
                    }
                    break;

                default:
                    break;

                
            }



        }
    }
}
