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
        public void InitialGameHasNoCells()
        {

            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives();

            Assert.That( game.GetGame(), Is.Null);
        }
    
        [Test]
        public void ALoneLiveCell_ResultsInNoCellsAfterOneTick()
        {
            List<Cell>initialCellConfig = new List<Cell>();

            initialCellConfig.Add(new Cell());
            initialCellConfig[0].SetAlive();

            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives( initialCellConfig );

            game.Tick();

            Assert.That(game.GetGame()[0].GetThisCellsState(), Is.Null);
        }



        [Test]
        public void ACellWithTwoOrThreeNeighbors_ResultsInALivingCellAfterOneTick()
        {

            List<Cell> initialCellConfig = new List<Cell>();

            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());

            //build the web of neighbors
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[5]);

            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[5]);

            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[4]);

            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[7]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[7]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[0].SetAlive();
            initialCellConfig[1].SetAlive();
            initialCellConfig[2].SetDead();
            initialCellConfig[3].SetDead();
            initialCellConfig[4].SetAlive();
            initialCellConfig[5].SetDead();
            initialCellConfig[6].SetDead();
            initialCellConfig[7].SetDead();
            initialCellConfig[8].SetDead();
            

            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives(initialCellConfig);

            game.Tick();

            Assert.That(game.GetGame()[0].GetThisCellsState(), Is.Not.Null);

        }

        [Test]
        public void ACellWithMoreThenThreeNeighbors_ResultsInALivingCellAfterOneTick()
        {

            List<Cell> initialCellConfig = new List<Cell>();

            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());

            //build the web of neighbors
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[5]);

            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[5]);

            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[4]);

            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[7]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[7]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[0].SetAlive();
            initialCellConfig[1].SetAlive();
            initialCellConfig[2].SetAlive();
            initialCellConfig[3].SetAlive();
            initialCellConfig[4].SetAlive();
            initialCellConfig[5].SetDead();
            initialCellConfig[6].SetDead();
            initialCellConfig[7].SetDead();
            initialCellConfig[8].SetDead();


            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives(initialCellConfig);

            game.Tick();


            Assert.That(game.GetGame()[1].GetThisCellsState(), Is.Null);
            Assert.That(game.GetGame()[4].GetThisCellsState(), Is.Null);


        }

        [Test]
        public void ADeadCellWithExactlyThreeNeighbors_ResultsInALivingCellAfterOneTick()
        {

            List<Cell> initialCellConfig = new List<Cell>();

            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());
            initialCellConfig.Add(new Cell());

            //build the web of neighbors
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[0].GetNeighbors().Add(initialCellConfig[5]);

            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[1].GetNeighbors().Add(initialCellConfig[5]);

            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[2].GetNeighbors().Add(initialCellConfig[4]);

            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[7]);
            initialCellConfig[3].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[2]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[7]);
            initialCellConfig[4].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[0]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[1]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[5].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[6].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[5]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[6]);
            initialCellConfig[7].GetNeighbors().Add(initialCellConfig[8]);

            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[3]);
            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[4]);
            initialCellConfig[8].GetNeighbors().Add(initialCellConfig[7]);

            initialCellConfig[0].SetAlive();
            initialCellConfig[1].SetAlive();
            initialCellConfig[2].SetAlive();
            initialCellConfig[3].SetAlive();
            initialCellConfig[4].SetAlive();
            initialCellConfig[5].SetDead();
            initialCellConfig[6].SetDead();
            initialCellConfig[7].SetDead();
            initialCellConfig[8].SetDead();


            GameOfLifeNoPrimitives game = new GameOfLifeNoPrimitives(initialCellConfig);

            Assert.That(game.GetGame()[5].GetThisCellsState(), Is.Null);

            game.Tick();

            Assert.That(game.GetGame()[5].GetThisCellsState(), Is.Not.Null);



        }



      

    }



}
