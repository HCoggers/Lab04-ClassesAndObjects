using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCheckForWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game testGame = new Game(p1, p2);

            Board testBoard = new Board();
            testBoard.GameBoard[0, 0] = "X";
            testBoard.GameBoard[0, 1] = "X";
            testBoard.GameBoard[0, 2] = "X";
            
            Assert.True(testGame.CheckForWinner(testBoard));

        }
    }
}
