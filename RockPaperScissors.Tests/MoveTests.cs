using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Players;
using System;
using System.IO;
using FluentAssertions;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class Move_DefeatsTests
    {
        [TestMethod]
        public void Rock_Defeats_Scissors() =>
            Assert.IsTrue(Moves.Rock.Defeats(Moves.Scissors));
        

        [TestMethod]
        public void Scissors_Defeats_Paper() =>
            Assert.IsTrue(Moves.Scissors.Defeats(Moves.Paper));

        [TestMethod]
        public void Paper_Defeats_Rock() =>
            Assert.IsTrue(Moves.Paper.Defeats(Moves.Rock));
    }

    [TestClass]
    public class Move_DefeatedByTest
    {
        [TestMethod]
        public void Rock_DefeatedBy_PaperAndSpock() =>
             Moves.Rock.DefeatedBy().ShouldBeEquivalentTo(new[] { Moves.Paper, Moves.Spock });

        [TestMethod]
        public void Scissors_DefeatedBy_RockAndSpock() =>
            Moves.Scissors.DefeatedBy().ShouldBeEquivalentTo(new[] { Moves.Rock, Moves.Spock });


        [TestMethod]
        public void Paper_DefeatedBy_LizardAndScissors() =>
            Moves.Paper.DefeatedBy().ShouldBeEquivalentTo(new[] { Moves.Lizard, Moves.Scissors });

           
    }
}
