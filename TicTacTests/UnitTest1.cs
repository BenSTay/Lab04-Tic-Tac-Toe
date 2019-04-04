using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindWinner()
        {
            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = new string[,]
            {
                {"O", "X", "X" },
                {"O", "O", "X" },
                {"X", "X", "O" },
            };
            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void CanSwitchPlayers()
        {
            Player one = new Player() { IsTurn = true };
            Player two = new Player();
            Game game = new Game(one, two);
            game.SwitchPlayer();
            Assert.False(one.IsTurn);
        }

        [Fact]
        public void CanPlaceMarker()
        {
            Player player = new Player() { Marker = "X" };
            Game game = new Game(player, new Player());
            Position position = Player.PositionForNumber(5);
            game.Board.GameBoard[position.Row, position.Column] = player.Marker;
            Assert.Equal(game.Board.GameBoard[1, 1], player.Marker);
        }

        [Fact]
        public void NextPlayerWorks()
        {
            Player one = new Player() { Name = "Drake" };
            Player two = new Player() { Name = "Josh", IsTurn = true };
            Game game = new Game(one, two);
            Player result = game.NextPlayer();
            Assert.Equal(two.Name, result.Name);
        }
    }
}
