using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Players;
using System;
using System.IO;

namespace RockPaperScissors.Tests
{
    public abstract class PlayerTestsBase
    {
        protected abstract Player Player { get; }

        protected abstract Moves Move { get; }

        [TestMethod]
        public void PlaysTheChoiceThatWouldHaveBeatenItsLastChoice()
        {
            var move = Player.Play();

            Assert.AreEqual(Move, move);
        }
    }
}
