using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TheGameOfLifeNoPrimitivesKata;
using GameOfLifeCells;


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
    
        [Test]
        public void ALoneLiveCell_ResultsInNoCellsAfterOneTick()
        {
            List<Cell>initialCellConfig = new List<Cell>();

            initialCellConfig.Add(new Cell());

            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives( initialCellConfig );

            game.Tick();

            Assert.That(game.GetGame(), Is.Null);
        }

    }



}
