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
        private List<Cell> cells;

        public GameOfLifeNoPrimitives(List<Cell> initialGrid)
        {
            cells = initialGrid.DeepClone();
        }

        public GameOfLifeNoPrimitives()
        {
            cells = null;
        }
        
        public List<Cell> GetGame()
        {
            return (cells);
        }

        public void Tick()
        {
            foreach(Cell c in cells)
            {
                List<Cell> neighbors;

                neighbors = c.GetNeighbors().DeepClone();

                Cell neighbor1 = null;

                Cell neighbor2 = null;

                Cell neighbor3 = null;

                Cell neighbor4 = null;

                foreach( Cell n in neighbors)
                {
                    if( n != null)
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
                             
                }
            }

          
            

        }



        
    }
    
}
