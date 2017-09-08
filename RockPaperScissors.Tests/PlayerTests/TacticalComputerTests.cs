using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Players;
using System.IO;
using FluentAssertions;

namespace RockPaperScissors.Tests.PlayerTests
{
    [TestClass]
    public class TacticalComputerTests
    {
        protected TacticalComputer Player;

        [TestInitialize]
        public void Setup()
        {
            Player = new TacticalComputer();
        }

        [TestMethod]
        public void PlayWithNoLastMove()
        {
            var move = Player.Play();

            move.Should().NotBeNull();

            Player.LastMove.Value.Should().Be(move);
        }


        [TestMethod]
        public void PlayWithLastMove()
        {

            Player.LastMove = Moves.Paper;

            var expectedMove = new[] {(int) Moves.Lizard, (int) Moves.Scissors };

            var actualMove = Player.Play();


            ((int)actualMove).Should().BeOneOf(expectedMove);

            Player.LastMove.Should().Be(actualMove);
        }
    }
}
