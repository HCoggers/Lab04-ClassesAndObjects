﻿using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            string outcome = NewGame();
            Console.WriteLine($"The winner is: {outcome}");
        }

        /// <summary>
        /// Plays A two-person tic-tac-toe game in the console, using user input to determine a winner, if there is one.
        /// </summary>
        /// <returns>The winner, or a draw message</returns>
        public static string NewGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player p1 = new Player();
            Console.WriteLine("Player One, Please Enter your name:");
            p1.Name = Console.ReadLine();
            p1.Marker = "X";

            Player p2 = new Player();
            Console.WriteLine("Player Two, Please Enter your name:");
            p2.Name = Console.ReadLine();
            p2.Marker = "O";

            Game tictactoe = new Game(p1, p2);
            tictactoe.Play();

            if (tictactoe.Winner != null)
                return tictactoe.Winner.Name;
            else return "It was a DRAW!";
        }
    }
}
