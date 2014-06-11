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

        }



        
    }
    
}
