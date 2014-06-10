using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TheGameOfLifeNoPrimitivesKata;


namespace GameOfLifeNoPrimitivesTests
{
    [TestFixture]
    public class GameOfLifeNoPrimitveTests
    {
        [Test]
        public void AGameWithNoCells_ResultsInAGameWithNoCellsAfterOneTick()
        {

            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives();

            Assert.That( game.GetGame(), Is.Null);
        }
    }
}
