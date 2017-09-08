using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Tests.PlayerTests
{
    [TestClass]
    public class RandomComputerTests
    {
        protected RandomComputer Player;

        [TestInitialize]
        public void Setup()
        {
            Player = new RandomComputer();
        }


        [TestMethod]
        public void Play()
        {
            var move = Player.Play();

            Assert.IsNotNull(move);
        }
    }
}
