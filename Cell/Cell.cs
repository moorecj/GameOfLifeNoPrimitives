using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeCells
{
    [Serializable]
    public class Cell
    {
        private Cell thisCellsState;
        private Cell thisCellsNextState;

        private List<Cell> neighbors;


        public Cell()
        {
            neighbors = new List<Cell>();
        }

        public List<Cell> GetNeighbors()
        {
            return neighbors;
        }

        public Cell GetThisCellsState()
        {
            return thisCellsState;
        }

        public void Update( )
        {
            thisCellsState = thisCellsNextState;
        }

        public void SetAlive( )
        {

            thisCellsNextState = new Cell();

        }

        public void SetDead( )
        {

            thisCellsNextState = null;

        }
        
    }
}
