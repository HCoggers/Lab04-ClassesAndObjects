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

        [Fact]
        public void CanSwitchPlayers()
        {
            Player p1 = new Player
            {
                IsTurn = true
            };
            Player p2 = new Player
            {
                IsTurn = false
            };
            Game testGame = new Game(p1, p2);

            testGame.SwitchPlayer();

            Assert.Equal(p2, testGame.NextPlayer());
        }

        [Fact]
        public void CanConvertIndexToPosition()
        {
            Position testP = Player.PositionForNumber(3);
            Assert.True(0 == testP.Row && 2 == testP.Column);
        }

        [Fact]
        public void CannotConvertIndexAboveNine()
        {
            Assert.Null(Player.PositionForNumber(10));
        }
    }
}
