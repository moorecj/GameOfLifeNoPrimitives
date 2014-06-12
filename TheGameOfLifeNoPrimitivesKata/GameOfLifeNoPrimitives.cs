using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLifeCells;
using TheGameOfLifeNoPrimitivesKata.Extensions;

namespace TheGameOfLifeNoPrimitivesKata
{
    [Serializable]
    public class GameOfLifeNoPrimitives
    {
        private List<Cell> Gamecells;

        public GameOfLifeNoPrimitives( List<Cell> initialGrid )
        {
            Gamecells = initialGrid.DeepClone();
        }

        public GameOfLifeNoPrimitives()
        {
            Gamecells = null;
        }
        
        public List<Cell> GetGame()
        {
            return (Gamecells);
        }

        public void Tick()
        {
            foreach(Cell c in Gamecells)
            {
                List<Cell> neighbors;

                neighbors = c.GetNeighbors();

                Cell neighbor1 = null;
                Cell neighbor2 = null;
                Cell neighbor3 = null;
                Cell neighbor4 = null;


                foreach( Cell n in neighbors)
                {

                    if( n.GetThisCellsState() != null)
                    {
                        if(neighbor1 == null)
                        {
                            neighbor1 = new Cell();
                        }
                        else if( neighbor2 == null)
                        {
                            neighbor2 = new Cell();
                        }
                        else if (neighbor3 == null)
                        {
                            neighbor3 = new Cell();
                        }
                        else if (neighbor4 == null)
                        {
                            neighbor4 = new Cell();
                        }
                    }


                }

                if( neighbor2 == null )
                {
                    c.FlagToBecomeDead(); 
                }

                if(neighbor4 != null )
                {
                    c.FlagToBecomeDead();
                }
                

            }

            UpdateAllCells();

        }


        public void UpdateAllCells()
        {

            foreach (Cell c in Gamecells)
            {
                c.Update();
            }

        }

    }
    
}


